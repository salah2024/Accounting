using Accounting.Application.Interface.Context;
using Accounting.Application.Interface.FacadPattern;
using Accounting.Application.Interface.Language_LanguageKeyValue.Commands.NewLanguage_LanguageKeyValue;
using Accounting.Application.Interface.Language_LanguageKeyValue.Queries.GetLanguageAndLanguageKeyValueEqualAll;
using Accounting.Application.Services.Language_LanguageKeyValue.Commands.NewLanguage_LanguageKeyValue;
using Accounting.Application.Services.Language_LanguageKeyValue.Queries.GetLanguageAndLanguageKeyValueEqualAll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Services.FacadPattern
{
    public class Language_LanguageKeyValueFacad: ILanguage_LanguageKeyValueFacad
    {
        private readonly IDataBaseContext _context;
        public Language_LanguageKeyValueFacad(IDataBaseContext context)
        {
            _context = context;
        }

        private IInsertNewLanguage_LanguageKeyValueService _insertNewLanguage_LanguageKeyValueService;
        public IInsertNewLanguage_LanguageKeyValueService insertNewLanguage_LanguageKeyValueService
        {
            get
            {
                return _insertNewLanguage_LanguageKeyValueService = _insertNewLanguage_LanguageKeyValueService ?? new InsertNewLanguage_LanguageKeyValueService(_context);
            }
        }

        private IGetLanguageAndLanguageKeyValueEqualAllService _getLanguageAndLanguageKeyValueEqualAllService;
        public IGetLanguageAndLanguageKeyValueEqualAllService getLanguageAndLanguageKeyValueEqualAllService
        {
            get
            {
                return _getLanguageAndLanguageKeyValueEqualAllService = _getLanguageAndLanguageKeyValueEqualAllService ?? new GetLanguageAndLanguageKeyValueEqualAllService(_context);
            }
        }

        private IGetLanguageAndLanguageKeyValueEqualWithLanguageIdService _getLanguageAndLanguageKeyValueEqualWithLanguageIdService;
        public IGetLanguageAndLanguageKeyValueEqualWithLanguageIdService getLanguageAndLanguageKeyValueEqualWithLanguageIdService
        {
            get
            {
                return _getLanguageAndLanguageKeyValueEqualWithLanguageIdService = _getLanguageAndLanguageKeyValueEqualWithLanguageIdService ?? new GetLanguageAndLanguageKeyValueEqualWithLanguageIdService(_context);
            }
        }
        private IGetLanguageAndLanguageKeyValueEqualWithLanguageNameService _getLanguageAndLanguageKeyValueEqualWithLanguageNameService;
        public IGetLanguageAndLanguageKeyValueEqualWithLanguageNameService getLanguageAndLanguageKeyValueEqualWithLanguageNameService
        {
            get
            {
                return _getLanguageAndLanguageKeyValueEqualWithLanguageNameService = _getLanguageAndLanguageKeyValueEqualWithLanguageNameService ?? new GetLanguageAndLanguageKeyValueEqualWithLanguageNameService(_context);
            }
        }

    }
}
