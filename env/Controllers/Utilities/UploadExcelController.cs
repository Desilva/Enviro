using env.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace env.Controllers.Utilities
{
    public class UploadExcelController : Controller
    {
        //
        // GET: /UploadExcel/

        public ActionResult Index()
        {
            return PartialView();
        }

        [HttpPost]
        public string Index(HttpPostedFileBase userfile)
        {
            // extract only the fielname
            var fileName = Path.GetFileName(userfile.FileName);
            string err = "";
            // store the file inside ~/App_Data/uploads folder
            var path = Path.Combine(Server.MapPath("~/App_Data/uploads"), fileName);
            userfile.SaveAs(path);
            err = SaveNonHazardousRecord(path);
            return err;
        }

        private string SaveNonHazardousRecord(string path)
        {
            ExcelReader excel = new ExcelReader();
            List<string> err = excel.LoadNonHazardousRecord(path);
            return excel.generateError(err);
        }

    }
}
