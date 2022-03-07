using Accounting.Application.Interface.Context;
using Accounting.Domain.Entities.UserManager;
using EndPoint.Site.Resource;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EndPoint.Site.Controllers
{
    [Route("api/[controller]/{action}")]
    [ApiController]
    public class Role111Controller : Controller
    {
        private readonly IDataBaseContext _context;

        private readonly LocalizationService _localizationService;
        public Role111Controller(IDataBaseContext context, LocalizationService localizationService)
        {
            _context = context;
            _localizationService = localizationService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult showPage()
        {
            return View();
        }
        // GET: api/<RoleController>
        [HttpGet]
        public ActionResult GetAllRoles()
        {
            List<clsRole> lstRole=_context.Roles.ToList();
            return new JsonResult(lstRole);
        }
        // GET: api/<RoleController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { _localizationService.GetLocalizedHtmlString("value1"), "value2" };
        }

        // GET api/<RoleController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RoleController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RoleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RoleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
