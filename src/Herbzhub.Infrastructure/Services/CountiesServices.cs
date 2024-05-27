using Herbzhub.Data;
using Herbzhub.Infrastructure.Helper;
using Herbzhub.Infrastructure.Interface;
using Herbzhub.Models.Response;
using Microsoft.EntityFrameworkCore;

namespace Herbzhub.Infrastructure.Services
{
    public class CountiesServices : ICountiesService
    {
        private readonly DbApplicationContext _context;
        public CountiesServices(DbApplicationContext dbApplicationContext) {
            _context = dbApplicationContext;
        }

        public async Task<BaseResponse<List<GenericNameResponse>>> GetCounties()
        {
            var counties = await _context.Counties.ToListAsync();
            var response = counties.Select(c => new GenericNameResponse
            {
                Id = c.Id,
                Name = c.Name,
            }).ToList();

            return new BaseResponse<List<GenericNameResponse>>(true, "Counties retrieved successfully", response);
        }

        public async Task<BaseResponse<List<GenericNameResponse>>> State()
        {
            var state = await _context.States.ToListAsync();

            var response = state.Select(s => new GenericNameResponse
            {
                Id = s.Id,
                Name = s.Name,
            }).ToList();
            return new BaseResponse<List<GenericNameResponse>>(true,"State retrieved successfully",response);
        }


        public async Task<BaseResponse<List<GenericNameResponse>>> RoleType()
        {
            var roles = await _context.Roles
                .Where(d => d.RoleName == "Manufacturer" || d.RoleName == "Dispensary")
                .ToListAsync();

            var response = roles.Select(c => new GenericNameResponse
            {
                Id = c.Id,
                Name = c.RoleName
            }).ToList();

            return new BaseResponse<List<GenericNameResponse>>
            {
                Data = response,
                Success = true,
                Message = "Roles retrieved successfully."
            };
        }


    }
}
