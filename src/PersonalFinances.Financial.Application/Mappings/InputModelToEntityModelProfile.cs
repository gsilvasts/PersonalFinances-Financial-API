using AutoMapper;
using PersonalFinances.Financial.Application.InputModel;

namespace PersonalFinances.Financial.Application.Mappings
{
    public class InputModelToEntityModelProfile : Profile
    {
        public InputModelToEntityModelProfile()
        {
            CreateMap<ExpenseInputModel, ExpenseInputModel>();
        }
    }
}
