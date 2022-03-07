using Accounting.Application.Services.User.Forms;
using Accounting.Common;

namespace Accounting.Application.Services.User.Commands.RegisterUser
{
    public class ValidateUserRegister
    {
        public List<ValidatorCheck> CheckUserFields(UserRegisterFrm userRegister)
        {
            List<ValidatorCheck> lstvalidatorChecks = new List<ValidatorCheck>();
            ValidatorCheck validatorCheck = new ValidatorCheck();
            if (userRegister.Email == null || userRegister.Email == string.Empty)
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
