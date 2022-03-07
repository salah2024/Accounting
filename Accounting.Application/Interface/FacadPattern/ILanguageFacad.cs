using Accounting.Application.Interface.Language.Commands.InsertNewLanguage;
using Accounting.Application.Interface.Language.Queries.GetAllLanguage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Interface.FacadPattern
{
    public interface ILanguageFacad
    {
        IInsertNewLanguageService insertNewLanguageService { get; }
        IGetAllLanguageService getAllLanguageService { get; }
        IGetAllLanguageWithLanguageIdService getAllLanguageWithLanguageIdService { get; }
    }
}
