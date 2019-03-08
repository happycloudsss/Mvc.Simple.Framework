using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Models.Login;

namespace Web.Validator.Login
{
    public class LoginValidator:AbstractValidator<LoginModel>
    {
        public LoginValidator()
        {
            RuleFor(l => l.Username).Length(1, 5).WithMessage("Username between 1-5 charactors");
            RuleFor(l => l.Password).Length(1, 5).WithMessage("Password between 1-5 charactors");
        }
    }
}