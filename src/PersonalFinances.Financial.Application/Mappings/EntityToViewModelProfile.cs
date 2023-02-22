using AutoMapper;
using PersonalFinances.Financial.Application.ViewModels;
using PersonalFinances.Financial.Domain.Entities;

namespace PersonalFinances.Financial.Application.Mappings
{
    public class EntityToViewModelProfile : Profile
    {
        public EntityToViewModelProfile()
        {
            CreateMap<Expense, ExpenseViewModel>()
                .ForMember(dst => dst.Category,
                map=> map.MapFrom(src=> src.Category.Name));
        }
    }
}
