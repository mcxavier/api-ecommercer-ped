using api_ecommercer_ped.application.UseCases.CreateOrder;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace api_ecommercer_ped.application.UseCases.GetOrder
{
    public sealed class GetOrderValidator : AbstractValidator<GetOrderRequest>
    {
        //public GetOrderrValidator()
        //{
        //    //RuleFor(x => x.Email)
        //    //    .NotEmpty().WithMessage("Email is required.")
        //    //    .EmailAddress().WithMessage("Invalid email format.");
        //    //RuleFor(x => x.Name)
        //    //    .NotEmpty().WithMessage("Name is required.")
        //    //    .MinimumLength(2).WithMessage("Name must be at least 2 characters long.")
        //    //    .MaximumLength(100).WithMessage("Name cannot exceed 100 characters.");
        //}
    }
}