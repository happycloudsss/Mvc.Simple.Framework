using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Validator.Login;

namespace Web.Models.Login
{
    [Validator(typeof(LoginValidator))]
    public class LoginModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}