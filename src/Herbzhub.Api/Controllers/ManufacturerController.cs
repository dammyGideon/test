using Herbzhub.Infrastructure.Interface;
using Herbzhub.Models.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Herbzhub.Api.Controllers
{
   
    public class ManufacturerController : BaseController
    {
        private  string _imageFolderPath;
        private IWebHostEnvironment _env;
        private readonly IManufacturerService _manufacturerService;
        public ManufacturerController(IManufacturerService manufacturerService,IWebHostEnvironment env) {
            _manufacturerService = manufacturerService;
            _env = env;
        }
       


        [HttpPost]
        public async Task<IActionResult> ManufacturerOnboarding([FromForm] ManufactureRequest request)
        {
         
            var response = await _manufacturerService.CreateManufacturer(request);

            // Return the response
            if (response.Success)
            {
                return CreatedAtAction(nameof(ManufacturerOnboarding), new { id = response.Data }, response);
            }

            return BadRequest(response);
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

            return filename; 
        }

    }
}
