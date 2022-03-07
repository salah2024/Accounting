using Accounting.Application.Interface.Context;
using Accounting.Application.Interface.FacadPattern;
using Accounting.Application.Services.Language.Queries.GetAllLanguage;
using Accounting.Application.Services.Language_LanguageKeyValue.Queries.GetLanguageAndLanguageKeyValueEqualAll;
using Accounting.Common.Dto;
using ICSharpCode.Decompiler.Util;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.Site.Controllers
{
    [Route("api/[controller]/{action}")]
    [ApiController]
    public class LanguageController : Controller
    {
        private readonly IDataBaseContext _context;
        private readonly ILanguageFacad _Language;
        private readonly ILanguage_LanguageKeyValueFacad _Language_LanguageKeyValueFacad;
        public LanguageController(IDataBaseContext context, ILanguageFacad Language,
            ILanguage_LanguageKeyValueFacad Language_LanguageKeyValueFacad)
        {
            _context = context;
            _Language = Language;
            _Language_LanguageKeyValueFacad= Language_LanguageKeyValueFacad;
        }
        [HttpGet("{LanguageName}")]
        public IActionResult FillResourceFile(string LanguageName)
        {
            RequestLanguageAndLanguageKeyValueLanguageNameDto Request = new RequestLanguageAndLanguageKeyValueLanguageNameDto()
            {
                LanguageName = LanguageName,
            };
            string str = @"Resource\ApplicationResource." + LanguageName + ".resx";
            ResultDto<List<ResultLanguageAndLanguageKeyValueEqualDto>> result = _Language_LanguageKeyValueFacad.getLanguageAndLanguageKeyValueEqualWithLanguageNameService.GetLanguageAndLanguageKeyValueEqualWithLanguageName(Request);
            if (result.IsSuccess)
            {
                List<ResultLanguageAndLanguageKeyValueEqualDto> lstLanguageAndLanguageKeyValueEqual = result.Data;
                foreach (var item in lstLanguageAndLanguageKeyValueEqual)
                {
                    using (ResXResourceWriter resx = new ResXResourceWriter(str))
                    {
                        resx.AddResource(item.LanguageKeyValueName, item.Equal);
                        resx.Close();
                    }
                }
            }
            return View();
        }

        [HttpGet("{LanguageName}")]
        public IActionResult ChangeLanguage(string LanguageName)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(LanguageName)),
                new CookieOptions()
                {
                    Expires = DateTime.UtcNow.AddYears(1),
                });
            return View();
        }
        //public IActionResult FillResourceFile()
        //{
        //    ResultDto<List<ResultGetAllLanguageDto>> Result = _Language.getAllLanguageService.GetAllLanguage();
        //    if (Result.IsSuccess)
        //    {
        //        List<ResultGetAllLanguageDto> lstResultGetAllLanguage = Result.Data;

        //        foreach (var item in lstResultGetAllLanguage)
        //        {
        //            string str = @"Resource\" + item.LanguageName + ".resx";
        //            using (ResXResourceWriter resx = new ResXResourceWriter(str))
        //            {
        //                resx.AddResource("Key1", "Value1");
        //                resx.AddResource("Key2", "Value2");
        //                resx.AddResource("Key3", "Value3");

        //                resx.Close();
        //            }

        //        }
        //    }
        //    return View();
        //}
    }
}
