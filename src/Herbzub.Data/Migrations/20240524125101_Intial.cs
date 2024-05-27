using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Herbzhub.Data.Migrations
{
    /// <inheritdoc />
    public partial class Intial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    State = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Counties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Counties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CountryCode = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SecondaryEmail = table.Column<string>(type: "text", nullable: false),
                    HomePhone = table.Column<string>(type: "text", nullable: false),
                    WorkPhone = table.Column<string>(type: "text", nullable: false),
                    EmergencyContact = table.Column<string>(type: "text", nullable: false),
                    EmergencyContactPhone = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "DriverEmploymentDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmploymentStatus = table.Column<string>(type: "text", nullable: false),
                    HireDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EmployeeID = table.Column<string>(type: "text", nullable: false),
                    EmploymentContractType = table.Column<string>(type: "text", nullable: false),
                    BackgroundCheckStatus = table.Column<string>(type: "text", nullable: false),
                    HealthClearanceStatus = table.Column<string>(type: "text", nullable: false),
                    TrainingRecords = table.Column<string>(type: "text", nullable: false),
                    DeliveryZone = table.Column<string>(type: "text", nullable: false),
                    AvailableHours = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverEmploymentDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LicenseNumber = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    LicenseExpiryDate = table.Column<DateOnly>(type: "date", nullable: false),
                    LicenseState = table.Column<string>(type: "text", nullable: false),
                    DrivingCertification = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleName = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Abbreviation = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Username = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    HashPassword = table.Column<string>(type: "text", nullable: false),
                    MobileNumber = table.Column<string>(type: "text", nullable: false),
                    IsMFAEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerAudits",
                columns: table => new
                {
                    CustomerAuditId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    AccountVerified = table.Column<bool>(type: "boolean", nullable: false),
                    LastOrderDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAudits", x => x.CustomerAuditId);
                    table.ForeignKey(
                        name: "FK_CustomerAudits_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerLegalDocuments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    IdProof = table.Column<byte[]>(type: "bytea", nullable: false),
                    MedicalMarijuanaCard = table.Column<byte[]>(type: "bytea", nullable: false),
                    Prescription = table.Column<byte[]>(type: "bytea", nullable: true),
                    GovernmentIdNumber = table.Column<string>(type: "text", nullable: false),
                    GovernmentIdType = table.Column<string>(type: "text", nullable: false),
                    GovernmentIdProof = table.Column<byte[]>(type: "bytea", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerLegalDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerLegalDocuments_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerMedicalInformation",
                columns: table => new
                {
                    CustomerMedicalInformationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    PatientId = table.Column<string>(type: "text", nullable: false),
                    MedicalCondition = table.Column<string>(type: "text", nullable: false),
                    Allergies = table.Column<string>(type: "text", nullable: true),
                    CurrentMedication = table.Column<string>(type: "text", nullable: true),
                    DoctorName = table.Column<string>(type: "text", nullable: false),
                    DoctorContact = table.Column<string>(type: "text", nullable: false),
                    PrimaryCarePhysician = table.Column<string>(type: "text", nullable: true),
                    PhysicianContact = table.Column<string>(type: "text", nullable: true),
                    TreatmentHistory = table.Column<string>(type: "text", nullable: true),
                    KnownHealthIssues = table.Column<string>(type: "text", nullable: true),
                    MedicalMarijuanaCardNumber = table.Column<string>(type: "text", nullable: false),
                    CardExpirationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerMedicalInformation", x => x.CustomerMedicalInformationId);
                    table.ForeignKey(
                        name: "FK_CustomerMedicalInformation_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerPreferencesNotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    ProductPreferences = table.Column<string>(type: "text", nullable: true),
                    LifestylePreferences = table.Column<string>(type: "text", nullable: true),
                    AdditionalNotes = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerPreferencesNotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerPreferencesNotes_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DriverVehicleInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VehicleMake = table.Column<string>(type: "text", nullable: false),
                    DriverId = table.Column<int>(type: "integer", nullable: false),
                    VehicleModel = table.Column<string>(type: "text", nullable: false),
                    VehicleYear = table.Column<int>(type: "integer", nullable: false),
                    VehicleLicensePlate = table.Column<string>(type: "text", nullable: false),
                    VehicleRegistrationNumber = table.Column<string>(type: "text", nullable: false),
                    VehicleColor = table.Column<string>(type: "text", nullable: false),
                    VehicleInsuranceProvider = table.Column<string>(type: "text", nullable: false),
                    VehicleInsuranceExpiryDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    InsurancePolicyNumber = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverVehicleInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DriverVehicleInformation_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dispensaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    FederalLicenseNumber = table.Column<string>(type: "text", nullable: false),
                    StateLicenseNumber = table.Column<string>(type: "text", nullable: false),
                    LicenseExpiryDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ComplianceStatus = table.Column<string>(type: "text", nullable: true),
                    EnvironmentalComplianceStatus = table.Column<string>(type: "text", nullable: true),
                    LincenseUpload = table.Column<string>(type: "text", nullable: false),
                    BusinessName = table.Column<string>(type: "text", nullable: false),
                    BusinessType = table.Column<string>(type: "text", nullable: false),
                    OwnerName = table.Column<string>(type: "text", nullable: false),
                    OwnerContact = table.Column<string>(type: "text", nullable: false),
                    NumberOfEmployees = table.Column<string>(type: "text", nullable: false),
                    BusinessRegistrationNumber = table.Column<string>(type: "text", nullable: false),
                    AnnualRevenue = table.Column<string>(type: "text", nullable: true),
                    OperatingHours = table.Column<string>(type: "text", nullable: false),
                    DeliveryServiceAvailable = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dispensaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dispensaries_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonalIdentifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AuthenticationEntityId = table.Column<int>(type: "integer", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    MiddleName = table.Column<string>(type: "text", nullable: true),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: false),
                    Gender = table.Column<string>(type: "text", nullable: true),
                    IDentificationIdUpload = table.Column<string>(type: "text", nullable: false),
                    social_security_number = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalIdentifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonalIdentifications_Users_AuthenticationEntityId",
                        column: x => x.AuthenticationEntityId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SMSVerificationCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AuthenticationEntityId = table.Column<int>(type: "integer", nullable: false),
                    phone_number = table.Column<string>(type: "text", nullable: false),
                    verification_code = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMSVerificationCodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SMSVerificationCodes_Users_AuthenticationEntityId",
                        column: x => x.AuthenticationEntityId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuditFeedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DispensaryId = table.Column<int>(type: "integer", nullable: false),
                    LastInspectionDate = table.Column<string>(type: "text", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ComplianceAuditLog = table.Column<string>(type: "text", nullable: true),
                    CustomerFeedback = table.Column<string>(type: "text", nullable: true),
                    CustomerSatisfactionIndex = table.Column<double>(type: "double precision", nullable: true),
                    AverageRating = table.Column<double>(type: "double precision", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditFeedbacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuditFeedbacks_Dispensaries_DispensaryId",
                        column: x => x.DispensaryId,
                        principalTable: "Dispensaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContactInformations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DispensaryId = table.Column<int>(type: "integer", nullable: false),
                    BusinessAddress = table.Column<string>(type: "text", nullable: false),
                    BusinessCity = table.Column<string>(type: "text", nullable: false),
                    BusinessState = table.Column<string>(type: "text", nullable: false),
                    BusinessZipCode = table.Column<string>(type: "text", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false),
                    BusinessPhone = table.Column<string>(type: "text", nullable: false),
                    BusinessEmail = table.Column<string>(type: "text", nullable: false),
                    OperatingHour = table.Column<string>(type: "text", nullable: false),
                    WebsiteUrl = table.Column<string>(type: "text", nullable: true),
                    SocialMediaProfiles = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInformations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactInformations_Dispensaries_DispensaryId",
                        column: x => x.DispensaryId,
                        principalTable: "Dispensaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FinancialInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TaxId = table.Column<string>(type: "text", nullable: false),
                    BankAccountNumber = table.Column<string>(type: "text", nullable: false),
                    BankName = table.Column<string>(type: "text", nullable: false),
                    DispensaryId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FinancialInformation_Dispensaries_DispensaryId",
                        column: x => x.DispensaryId,
                        principalTable: "Dispensaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InventoryManagements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DispensaryId = table.Column<int>(type: "integer", nullable: false),
                    InventoryTrackingSystem = table.Column<string>(type: "text", nullable: true),
                    ProductCatalog = table.Column<string>(type: "text", nullable: true),
                    SupplierInformation = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryManagements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InventoryManagements_Dispensaries_DispensaryId",
                        column: x => x.DispensaryId,
                        principalTable: "Dispensaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SecurityMeasures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DispensaryId = table.Column<int>(type: "integer", nullable: false),
                    SecurityMeasuresDetails = table.Column<string>(type: "text", nullable: true),
                    EmergencyResponsePlan = table.Column<string>(type: "text", nullable: true),
                    HealthSafetyRecords = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecurityMeasures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SecurityMeasures_Dispensaries_DispensaryId",
                        column: x => x.DispensaryId,
                        principalTable: "Dispensaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonalIdentificationId = table.Column<int>(type: "integer", nullable: false),
                    StreetAddress = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    StateId = table.Column<int>(type: "integer", nullable: false),
                    ZipCode = table.Column<string>(type: "text", nullable: false),
                    CountiesId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Counties_CountiesId",
                        column: x => x.CountiesId,
                        principalTable: "Counties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Addresses_PersonalIdentifications_PersonalIdentificationId",
                        column: x => x.PersonalIdentificationId,
                        principalTable: "PersonalIdentifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Addresses_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Counties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Adair" },
                    { 2, "Andrew" },
                    { 3, "Atchison" },
                    { 4, "Audrain" },
                    { 5, "Barry" },
                    { 6, "Barton" },
                    { 7, "Bates" },
                    { 8, "Benton" },
                    { 9, "Bollinger" },
                    { 10, "Boone" },
                    { 11, "Buchanan" },
                    { 12, "Butler" },
                    { 13, "Caldwell" },
                    { 14, "Callaway" },
                    { 15, "Camden" },
                    { 16, "Cape Girardeau" },
                    { 17, "Carroll" },
                    { 18, "Carter" },
                    { 19, "Cass" },
                    { 20, "Cedar" },
                    { 21, "Chariton" },
                    { 22, "Christian" },
                    { 23, "Clark" },
                    { 24, "Clay" },
                    { 25, "Clinton" },
                    { 26, "Cole" },
                    { 27, "Cooper" },
                    { 28, "Crawford" },
                    { 29, "Dade" },
                    { 30, "Dallas" },
                    { 31, "Daviess" },
                    { 32, "DeKalb" },
                    { 33, "Dent" },
                    { 34, "Douglas" },
                    { 35, "Dunklin" },
                    { 36, "Franklin" },
                    { 37, "Gasconade" },
                    { 38, "Gentry" },
                    { 39, "Greene" },
                    { 40, "Grundy" },
                    { 41, "Harrison" },
                    { 42, "Henry" },
                    { 43, "Hickory" },
                    { 44, "Holt" },
                    { 45, "Howard" },
                    { 46, "Howell" },
                    { 47, "Iron" },
                    { 48, "Jackson" },
                    { 49, "Jasper" },
                    { 50, "Jefferson" },
                    { 51, "Johnson" },
                    { 52, "Knox" },
                    { 53, "Laclede" },
                    { 54, "Lafayette" },
                    { 55, "Lawrence" },
                    { 56, "Lewis" },
                    { 57, "Lincoln" },
                    { 58, "Linn" },
                    { 59, "Livingston" },
                    { 60, "Macon" },
                    { 61, "Madison" },
                    { 62, "Maries" },
                    { 63, "Marion" },
                    { 64, "McDonald" },
                    { 65, "Mercer" },
                    { 66, "Miller" },
                    { 67, "Mississippi" },
                    { 68, "Moniteau" },
                    { 69, "Monroe" },
                    { 70, "Montgomery" },
                    { 71, "Morgan" },
                    { 72, "New Madrid" },
                    { 73, "Newton" },
                    { 74, "Nodaway" },
                    { 75, "Oregon" },
                    { 76, "Osage" },
                    { 77, "Ozark" },
                    { 78, "Pemiscot" },
                    { 79, "Perry" },
                    { 80, "Pettis" },
                    { 81, "Phelps" },
                    { 82, "Pike" },
                    { 83, "Platte" },
                    { 84, "Polk" },
                    { 85, "Pulaski" },
                    { 86, "Putnam" },
                    { 87, "Ralls" },
                    { 88, "Randolph" },
                    { 89, "Ray" },
                    { 90, "Reynolds" },
                    { 91, "Ripley" },
                    { 92, "St. Charles" },
                    { 93, "St. Clair" },
                    { 94, "St. Francois" },
                    { 95, "St. Louis" },
                    { 96, "Ste. Genevieve" },
                    { 97, "Saline" },
                    { 98, "Schuyler" },
                    { 99, "Scotland" },
                    { 100, "Scott" },
                    { 101, "Shannon" },
                    { 102, "Shelby" },
                    { 103, "Stoddard" },
                    { 104, "Stone" },
                    { 105, "Sullivan" },
                    { 106, "Taney" },
                    { 107, "Texas" },
                    { 108, "Vernon" },
                    { 109, "Warren" },
                    { 110, "Washington" },
                    { 111, "Wayne" },
                    { 112, "Webster" },
                    { 113, "Worth" },
                    { 114, "Wright" },
                    { 115, "City of St. Louis" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryCode", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "United States", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(6629) },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Canada", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(6635) },
                    { 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "United Kingdom", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(6637) },
                    { 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nigeria", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(6639) },
                    { 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Togo", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(6640) }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "RoleName", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manufacturer", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9778) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manufacturer Driver", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9793) },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dispensary", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9795) },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer Driver", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9796) },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9798) }
                });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "Abbreviation", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "AL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alabama", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7722) },
                    { 2, "AK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alaska", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7746) },
                    { 3, "AZ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arizona", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7748) },
                    { 4, "AR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arkansas", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7750) },
                    { 5, "CA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "California", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7752) },
                    { 6, "CO", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colorado", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7756) },
                    { 7, "CT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Connecticut", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7758) },
                    { 8, "DE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delaware", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7760) },
                    { 9, "FL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Florida", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7762) },
                    { 10, "GA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Georgia", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7765) },
                    { 11, "HI", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hawaii", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7767) },
                    { 12, "ID", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Idaho", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7769) },
                    { 13, "IL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Illinois", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7771) },
                    { 14, "IN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Indiana", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7773) },
                    { 15, "IA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iowa", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7775) },
                    { 16, "KS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kansas", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7777) },
                    { 17, "KY", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kentucky", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7779) },
                    { 18, "LA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Louisiana", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7783) },
                    { 19, "ME", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maine", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7784) },
                    { 20, "MD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maryland", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7786) },
                    { 21, "MA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Massachusetts", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7807) },
                    { 22, "MI", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michigan", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7810) },
                    { 23, "MN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minnesota", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7812) },
                    { 24, "MS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mississippi", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7814) },
                    { 25, "MO", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Missouri", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7816) },
                    { 26, "MT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Montana", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7818) },
                    { 27, "NE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nebraska", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7820) },
                    { 28, "NV", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nevada", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7821) },
                    { 29, "NH", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "New Hampshire", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7823) },
                    { 30, "NJ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "New Jersey", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7825) },
                    { 31, "NM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "New Mexico", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7827) },
                    { 32, "NY", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "New York", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7829) },
                    { 33, "NC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "North Carolina", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7831) },
                    { 34, "ND", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "North Dakota", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7835) },
                    { 35, "OH", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ohio", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7837) },
                    { 36, "OK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oklahoma", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7839) },
                    { 37, "OR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oregon", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7841) },
                    { 38, "PA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pennsylvania", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7842) },
                    { 39, "RI", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rhode Island", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7844) },
                    { 40, "SC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "South Carolina", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7846) },
                    { 41, "SD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "South Dakota", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7848) },
                    { 42, "TN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tennessee", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7850) },
                    { 43, "TX", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Texas", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7852) },
                    { 44, "UT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Utah", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7853) },
                    { 45, "VT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vermont", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7855) },
                    { 46, "VA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Virginia", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7857) },
                    { 47, "WA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Washington", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7859) },
                    { 48, "WV", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "West Virginia", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7861) },
                    { 49, "WI", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wisconsin", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7863) },
                    { 50, "WY", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wyoming", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7865) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "HashPassword", "IsMFAEnabled", "MobileNumber", "UpdatedAt", "Username" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", "$2a$11$YwI.nH70kvs4ZVBxky9bBeYMCo4RUElPaEB2/yfThSwVq4YFj6V/q", false, "1234567890", new DateTime(2024, 5, 24, 12, 50, 58, 954, DateTimeKind.Utc).AddTicks(9852), "admin" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "Id", "CreatedAt", "Name", "State", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "New York City", "New York", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8799) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Los Angeles", "California", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8817) },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicago", "Illinois", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8820) },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Houston", "Texas", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8821) },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phoenix", "Arizona", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8823) },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philadelphia", "Pennsylvania", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8827) },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Antonio", "Texas", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8829) },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Diego", "California", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8831) },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dallas", "Texas", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8833) },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Jose", "California", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8836) },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Austin", "Texas", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8838) },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jacksonville", "Florida", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8840) },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fort Worth", "Texas", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8842) },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Columbus", "Ohio", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8844) },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Francisco", "California", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8846) },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charlotte", "North Carolina", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8848) },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Indianapolis", "Indiana", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8850) },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seattle", "Washington", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8993) },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Denver", "Colorado", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8996) },
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Washington", "District of Columbia", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8998) },
                    { 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Boston", "Massachusetts", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9000) },
                    { 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "El Paso", "Texas", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9002) },
                    { 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nashville", "Tennessee", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9004) },
                    { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Detroit", "Michigan", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9006) },
                    { 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oklahoma City", "Oklahoma", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9007) },
                    { 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Portland", "Oregon", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9009) },
                    { 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Las Vegas", "Nevada", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9011) },
                    { 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Memphis", "Tennessee", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9013) },
                    { 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Louisville", "Kentucky", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9015) },
                    { 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Baltimore", "Maryland", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9017) },
                    { 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milwaukee", "Wisconsin", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9019) },
                    { 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Albuquerque", "New Mexico", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9021) },
                    { 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tucson", "Arizona", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9023) },
                    { 34, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fresno", "California", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9026) },
                    { 35, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sacramento", "California", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9028) },
                    { 36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kansas City", "Missouri", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9030) },
                    { 37, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Long Beach", "California", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9032) },
                    { 38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mesa", "Arizona", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9034) },
                    { 39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Atlanta", "Georgia", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9036) },
                    { 40, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colorado Springs", "Colorado", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9038) },
                    { 41, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Virginia Beach", "Virginia", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9040) },
                    { 42, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Raleigh", "North Carolina", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9041) },
                    { 43, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Omaha", "Nebraska", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9043) },
                    { 44, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miami", "Florida", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9045) },
                    { 45, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oakland", "California", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9047) },
                    { 46, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minneapolis", "Minnesota", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9049) },
                    { 47, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tulsa", "Oklahoma", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9051) },
                    { 48, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wichita", "Kansas", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9053) },
                    { 49, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "New Orleans", "Louisiana", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9054) },
                    { 50, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arlington", "Texas", new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9056) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "RoleId", "UserId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CountiesId",
                table: "Addresses",
                column: "CountiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_PersonalIdentificationId",
                table: "Addresses",
                column: "PersonalIdentificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_StateId",
                table: "Addresses",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditFeedbacks_DispensaryId",
                table: "AuditFeedbacks",
                column: "DispensaryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContactInformations_DispensaryId",
                table: "ContactInformations",
                column: "DispensaryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAudits_CustomerId",
                table: "CustomerAudits",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerLegalDocuments_CustomerId",
                table: "CustomerLegalDocuments",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerMedicalInformation_CustomerId",
                table: "CustomerMedicalInformation",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerPreferencesNotes_CustomerId",
                table: "CustomerPreferencesNotes",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dispensaries_UserId",
                table: "Dispensaries",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DriverVehicleInformation_DriverId",
                table: "DriverVehicleInformation",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_FinancialInformation_DispensaryId",
                table: "FinancialInformation",
                column: "DispensaryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InventoryManagements_DispensaryId",
                table: "InventoryManagements",
                column: "DispensaryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonalIdentifications_AuthenticationEntityId",
                table: "PersonalIdentifications",
                column: "AuthenticationEntityId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SecurityMeasures_DispensaryId",
                table: "SecurityMeasures",
                column: "DispensaryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SMSVerificationCodes_AuthenticationEntityId",
                table: "SMSVerificationCodes",
                column: "AuthenticationEntityId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "AuditFeedbacks");

            migrationBuilder.DropTable(
                name: "cities");

            migrationBuilder.DropTable(
                name: "ContactInformations");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "CustomerAudits");

            migrationBuilder.DropTable(
                name: "CustomerLegalDocuments");

            migrationBuilder.DropTable(
                name: "CustomerMedicalInformation");

            migrationBuilder.DropTable(
                name: "CustomerPreferencesNotes");

            migrationBuilder.DropTable(
                name: "DriverEmploymentDetails");

            migrationBuilder.DropTable(
                name: "DriverVehicleInformation");

            migrationBuilder.DropTable(
                name: "FinancialInformation");

            migrationBuilder.DropTable(
                name: "InventoryManagements");

            migrationBuilder.DropTable(
                name: "SecurityMeasures");

            migrationBuilder.DropTable(
                name: "SMSVerificationCodes");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Counties");

            migrationBuilder.DropTable(
                name: "PersonalIdentifications");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Dispensaries");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
