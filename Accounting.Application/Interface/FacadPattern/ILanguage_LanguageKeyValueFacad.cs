using Accounting.Application.Interface.Language.Commands.InsertNewLanguage;
using Accounting.Application.Interface.Language_LanguageKeyValue.Commands.NewLanguage_LanguageKeyValue;
using Accounting.Application.Interface.Language_LanguageKeyValue.Queries.GetLanguageAndLanguageKeyValueEqualAll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Interface.FacadPattern
{
    public interface ILanguage_LanguageKeyValueFacad
    {
        IInsertNewLanguage_LanguageKeyValueService insertNewLanguage_LanguageKeyValueService { get; }
        IGetLanguageAndLanguageKeyValueEqualAllService getLanguageAndLanguageKeyValueEqualAllService { get; }
        IGetLanguageAndLanguageKeyValueEqualWithLanguageIdService getLanguageAndLanguageKeyValueEqualWithLanguageIdService { get; }
        IGetLanguageAndLanguageKeyValueEqualWithLanguageNameService getLanguageAndLanguageKeyValueEqualWithLanguageNameService { get; }
    }
}
