using Accounting.Application.Interface.Context;
using Accounting.Application.Interface.FacadPattern;
using Accounting.Application.Interface.LanguageKeyValue.Commands.InsertNewLanguageKeyValue;
using Accounting.Application.Interface.LanguageKeyValue.Queries;
using Accounting.Application.Services.LanguageKeyValue.Commands.InsertNewLanguageKeyValue;
using Accounting.Application.Services.LanguageKeyValue.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Services.FacadPattern
{
    public class LanguageKeyValueFacad: ILanguageKeyValueFacad
    {
        private readonly IDataBaseContext _context;
        public LanguageKeyValueFacad(IDataBaseContext conetxt)
        {
            _context = conetxt;
        }
        private IInsertNewLanguageKeyValueService _insertNewLanguageKeyValueService;
        public IInsertNewLanguageKeyValueService insertNewLanguageKeyValueService
        {
            get {
                return _insertNewLanguageKeyValueService = _insertNewLanguageKeyValueService ?? new InsertNewLanguageKeyValueService(_context);
            }
        }

        private IGetAllLanguageKeyValueService _getAllLanguageKeyValueService;
        public IGetAllLanguageKeyValueService getAllLanguageKeyValueService
        {
            get{
                return _getAllLanguageKeyValueService = _getAllLanguageKeyValueService ?? new GetAllLanguageKeyValueService(_context);
            }
        }

    }
}
