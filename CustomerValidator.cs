using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x=>x.CustomerCity).NotEmpty().WithMessage("City can not be blank!");
            RuleFor(x=>x.CustomerName).NotEmpty().WithMessage("Customer Name can not be blank!");
        }
    }
}
