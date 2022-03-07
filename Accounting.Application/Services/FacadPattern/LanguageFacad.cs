using Accounting.Application.Interface.Context;
using Accounting.Application.Interface.FacadPattern;
using Accounting.Application.Interface.Language.Commands.InsertNewLanguage;
using Accounting.Application.Interface.Language.Queries.GetAllLanguage;
using Accounting.Application.Services.Language.Commands.InsertNewLanguage;
using Accounting.Application.Services.Language.Queries.GetAllLanguage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Services.FacadPattern
{
    public class LanguageFacad: ILanguageFacad
    {
        private readonly IDataBaseContext _context;
        public LanguageFacad(IDataBaseContext context)
        {
            _context = context;
        }

        private IInsertNewLanguageService _insertNewLanguageService;
        public IInsertNewLanguageService insertNewLanguageService
        {
            get
            {
                return _insertNewLanguageService = _insertNewLanguageService ?? new InsertNewLanguageService(_context);
            }
        }

        private IGetAllLanguageService _getAllLanguageService;
        public IGetAllLanguageService getAllLanguageService
        {
            get
            {
                return _getAllLanguageService = _getAllLanguageService ?? new GetAllLanguageService(_context);
            }
        }

        private IGetAllLanguageWithLanguageIdService _getAllLanguageWithLanguageIdService;
        public IGetAllLanguageWithLanguageIdService getAllLanguageWithLanguageIdService
        {
            get
            {
                return _getAllLanguageWithLanguageIdService = _getAllLanguageWithLanguageIdService ?? new GetAllLanguageWithLanguageIdService(_context);
            }
        }
    }
}
