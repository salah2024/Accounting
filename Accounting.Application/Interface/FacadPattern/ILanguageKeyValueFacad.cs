using Accounting.Application.Interface.LanguageKeyValue.Commands.InsertNewLanguageKeyValue;
using Accounting.Application.Interface.LanguageKeyValue.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Interface.FacadPattern
{
    public interface ILanguageKeyValueFacad
    {
        IInsertNewLanguageKeyValueService insertNewLanguageKeyValueService { get; }
        IGetAllLanguageKeyValueService getAllLanguageKeyValueService { get; }
    }
}
