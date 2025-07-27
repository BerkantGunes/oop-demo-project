using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator() // constructor
        {
            // Rules
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Product Name can not be blank!");
            RuleFor(x => x.ProductName).MinimumLength(3).WithMessage("Product Name at least 3 Characters!");
            RuleFor(x => x.Stock).NotEmpty().WithMessage("Product Stock can not be blank!");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Product Price can not be blank!");

        }
    }
}
