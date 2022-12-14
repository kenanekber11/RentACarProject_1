using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p => p.BrandID).NotEmpty();
            RuleFor(p => p.ColorID).NotEmpty();
            RuleFor(p => p.Description).MinimumLength(3);
            RuleFor(p => p.DailyPrice).GreaterThan(0);

        }

    }
}
