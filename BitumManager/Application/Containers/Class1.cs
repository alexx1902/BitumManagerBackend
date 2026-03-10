using FluentValidation;
using System.ComponentModel.DataAnnotations;

namespace Bitum.Application.Containers
{
    public class CreateContainerValidator : AbstractValidator<CreateContainerDTO>
    {
        public CreateContainerValidator()
        {
            RuleFor(x=> x.Capacity).NotEmpty();
        }
    }
}
