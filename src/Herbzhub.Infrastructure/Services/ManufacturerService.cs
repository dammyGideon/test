using Herbzhub.Data;
using Herbzhub.Data.Models;
using Herbzhub.Infrastructure.Helper;
using Herbzhub.Infrastructure.Interface;
using Herbzhub.Models.Request;
using Herbzhub.Models.Response;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herbzhub.Infrastructure.Services
{
    public class ManufacturerService : IManufacturerService
    {
        private string _imageFolderPath;
        private readonly IWebHostEnvironment _env;
        private readonly DbApplicationContext _context;

        public ManufacturerService(DbApplicationContext context, IWebHostEnvironment env) { 
            _context = context;
            _env = env;
        }
        public async Task<BaseResponse<string>> CreateManufacturer(ManufactureRequest request)
        {
            if (request.Password != request.ConfirmPassword)
            {
                return new BaseResponse<string>
                {
                    Success = false,
                    Message = "Your passwords do not match."
                };
            }

            var password = PasswordHandler.EncryptPassword(request.Password);

            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    User userDetails = new()
                    {
                        Email = request.Email,
                        Username = request.UserName,
                        HashPassword = password,
                        MobileNumber = request.PhoneNumber,
                    };
                    _context.Users.Add(userDetails);
                    await _context.SaveChangesAsync();

                    PersonalIdentification personalIdentification = new()
                    {
                        FirstName = request.FirstName,
                        LastName = request.LastName,
                        Gender = request.Gender,
                        AuthenticationEntityId = userDetails.Id,
                        IDentificationIdUpload = await Uploads(request.IdCards.File, "/Resource/PersonalInfo", request.UserName)
                    };
                    _context.PersonalIdentifications.Add(personalIdentification);
                    await _context.SaveChangesAsync();

                    Address address = new()
                    {
                        PersonalIdentificationId = personalIdentification.Id,
                        StreetAddress = request.AddressRequest.streetAddress,
                        City = request.AddressRequest.usersCity,
                        ZipCode = request.AddressRequest.userZipCode,
                        StateId = request.AddressRequest.usersState,
                        CountiesId = request.AddressRequest.countiesId,
                    };
                    _context.Addresses.Add(address);
                    await _context.SaveChangesAsync();

                    Dispensary dispensary = new()
                    {
                        FederalLicenseNumber = request.licenses.FederalLicense,
                        StateLicenseNumber = request.licenses.StateLicense,
                        LicenseExpiryDate = request.licenses.ExpiringDate,
                        LincenseUpload = await Uploads(request.licenses.UploadLicense, "/Resource/PersonalInfo", request.UserName),
                        BusinessName = request.BusinessDetails.BusinessName,
                        BusinessType = request.BusinessDetails.BusinessType,
                        OwnerName = request.BusinessDetails.OwnName,
                        OwnerContact = request.BusinessDetails.OwnerContact,
                        NumberOfEmployees = request.BusinessDetails.NumberOfEmployees,
                        BusinessRegistrationNumber = request.BusinessDetails.BusinessRegistrationNumber,
                        AnnualRevenue = request.BusinessDetails.AnnualRevenue,
                        UserId = userDetails.Id,
                        
                    };
                    _context.Dispensaries.Add(dispensary);
                    await _context.SaveChangesAsync();

                    ContactInformation contactInformation = new()
                    {
                        DispensaryId = dispensary.Id,
                        BusinessAddress = request.BusinessLocation.BusinessAddress,
                        BusinessEmail = request.BusinessLocation.BusinessEmail,
                        BusinessCity = request.BusinessLocation.BusinessCity,
                        BusinessState = request.BusinessLocation.BusinessState,
                        BusinessPhone= request.BusinessLocation.BusinessPhoneNumber,
                        BusinessZipCode = request.BusinessLocation.BusinessPostalCode,
                        Country = request.BusinessLocation.BusinessCountry,
                        OperatingHour = request.OperatingHours
                    };
                    _context.ContactInformations.Add(contactInformation);
                    await _context.SaveChangesAsync();

                    FinancialInformation financialInformation = new()
                    {
                        DispensaryId = dispensary.Id,
                        TaxId = request.BankDetails.TaxId,
                        BankAccountNumber = request.BankDetails.BankAccount,
                        BankName = request.BankDetails.BankName,
                    };
                    _context.FinancialInformation.Add(financialInformation);
                    await _context.SaveChangesAsync();

                    await transaction.CommitAsync();

                    return new BaseResponse<string>
                    {
                        Success = true,
                        Message = "Manufacture request created successfully.",
                        Data = "Some meaningful data or an ID"
                    };
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    // Log the detailed exception
                    Console.WriteLine(ex); // Replace with your logging mechanism
                    return new BaseResponse<string>
                    {
                        Success = false,
                        Message = $"An error occurred: {ex.Message} - {ex.InnerException?.Message ?? "No inner exception"}"
                    };
                }
            }
        }

        private async Task<string> Uploads(IFormFile file, string path, string name)
        {
            _imageFolderPath = Path.Combine(_env.ContentRootPath, path);
            if (!Directory.Exists(_imageFolderPath))
            {
                Directory.CreateDirectory(_imageFolderPath);
            }

            if (file == null || file.Length == 0)
            {
                throw new ArgumentNullException(nameof(file), "No file uploaded");
            }

            string filename = $"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}";
            string filePath = Path.Combine(_imageFolderPath, filename);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return filename; // Assuming you want to return the filename
        }

    }
}
