using AutoMapper;
using IdentityWebApplication.Entity;
using IdentityWebApplication.Models.Employee;

namespace IdentityWebApplication.Mapping
{
    public class Profiles : Profile
    {
        public Profiles()
        {
            CreateMap<EmployeeEntity, InsertEmployeeRequest>();
            CreateMap<InsertEmployeeRequest, EmployeeEntity>();
            CreateMap<EmployeeEntity, ViewEmployeeModel>()
                .ForMember(e =>
                    e.Id, e => e.MapFrom(src => src.Id));
        }
    }
}
