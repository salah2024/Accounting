using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Reflection;
using System.Resources;
using System.Xml.Linq;

namespace EndPoint.Site.Controllers
{
        [Route("api/[controller]/{action}")]
        [ApiController]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //XDocument xd;
            //using (FileStream fs = new FileStream(@"Resource\fa-IR.resx"
            //                        , FileMode.Open, FileAccess.Read))
            //{
            //    xd = XDocument.Load(fs);
            //}
            //XElement elm;

            //// Loop some data source here and build up your resx file

            //elm = new XElement("data"
            //, new XAttribute("name", "Key2")
            //, new XAttribute(XNamespace.Xml + "space", "preserve")
            //, new XElement("value", "salah"));


            //xd.Root.Add(elm);

            //// end loop

            //xd.Save(@"Resource\fa-IR.resx");

            //IResourceWriter writer = new ResourceWriter("myResources.resources");

            //// Adds resources to the resource writer.
            //writer.AddResource("String 1", "First String");

            //writer.AddResource("String 2", "Second String");

            //writer.AddResource("String 3", "Third String");

            //// Writes the resources to the file or stream, and closes it.
            //writer.Close();



            //string str = @"Resource\fa-IR.resx";
            //using (ResXResourceWriter resx = new ResXResourceWriter(str))
            //{
            //    resx.AddResource("Key1", "Value1");
            //    resx.AddResource("Key2", "Value2");
            //    resx.AddResource("Key3", "Value3");

            //    resx.Close();
            //}

            //RemoveResEntry(str, "name5");
            return View();
        }
    }
}
