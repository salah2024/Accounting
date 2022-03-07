using Accounting.Application.Services.User.Forms;
using Accounting.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Services.User.Commands.RegisterUserAdmin
{
    public class ValidateUserWithRolesRegister
    {
        public List<ValidatorCheck> CheckUserWithRolesFields(UserRegisterWithRolesFrm Request)
        {
            List<ValidatorCheck> lstvalidatorChecks = new List<ValidatorCheck>();
            ValidatorCheck validatorCheck = new ValidatorCheck();
            if (Request.Email == null || Request.Email == string.Empty)
            {
                validatorCheck.FieldName = "ایمیل";
                validatorCheck.FieldDataBaseName = "email";
                validatorCheck.FieldError = "ایمیل نبایستی خالی باشد";
                lstvalidatorChecks.Add(validatorCheck);
            }
            return lstvalidatorChecks;
        }
    }
}
