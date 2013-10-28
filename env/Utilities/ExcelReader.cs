using env.Models;
using env.Models.Wrapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Web;
using Excel = Microsoft.Office.Interop.Excel;

namespace env.Utilities
{
    public class ExcelReader
    {
        private star_energy_enviroEntities db = new star_energy_enviroEntities();

        #region non hazardous record
        public List<string> LoadNonHazardousRecord(string filename)
        {
            Excel.Application app;
            Excel.Workbook book;
            Excel.Range ShtRange;
            List<object> temp;
            List<string> err;
            int i, j = 0;
            bool add = true;

            app = new Excel.Application();
            book = app.Workbooks.Open(Filename: filename);
            err = new List<string>();
            try
            {
                foreach (Excel.Worksheet sheet in book.Sheets)
                {
                    ShtRange = sheet.UsedRange;
                    string a = sheet.Name;
                    for (i = 2; i <= ShtRange.Rows.Count; i++)
                    {
                        temp = new List<object>();
                        for (j = 1; j <= ShtRange.Columns.Count; j++)
                        {
                            if ((ShtRange.Cells[i, j] as Excel.Range).Value2 == null)
                            {
                                if (j == 1)
                                    add = false;
                                temp.Add("");
                            }
                            else
                                temp.Add((ShtRange.Cells[i, j] as Excel.Range).Value2.ToString());
                        }

                        string errTemp = "";
                        if (add) errTemp = saveNonHazardousRecord(temp);
                        if (errTemp != "")
                        {
                            err.Add(errTemp);
                        };
                        add = true;
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
            finally
            {
                book.Close(true, Missing.Value, Missing.Value);
                app.Quit();
            }

            return err;
        }

        private string saveNonHazardousRecord(List<object> data)
        {
            string err = "";
            try
            {
                DateTime date = DateTime.FromOADate(Double.Parse(data[0].ToString()));
                string name = data[1].ToString();
                type_of_waste tw = db.type_of_waste.Where(p => p.name == name).FirstOrDefault();
                int? id_type = null;
                if (tw == null)
                {
                    err += "Type of waste of " + data[1].ToString() + " not found.";
                }
                else
                {
                    id_type = tw.id;
                }

                double waste_in = 0;
                Double.TryParse(data[2].ToString(), out waste_in);
                double waste_out = 0;
                Double.TryParse(data[3].ToString(), out waste_out);
                CultureInfo provider = CultureInfo.InvariantCulture;
                double total = 0;

                List<NonHazardousWasteRecordWrapper> all = db.non_hazardous_record.Where(p => p.date == date).Select(p => new NonHazardousWasteRecordWrapper { id = p.id, waste_in = p.waste_in, waste_out = p.waste_out, id_type = p.id_type, date = p.date }).ToList();
                if (all.Count() != 0)
                {
                    total = all.Sum(p => p.waste_in).Value + waste_in;
                    foreach (NonHazardousWasteRecordWrapper a in all)
                    {
                        non_hazardous_record nn = new non_hazardous_record
                        {
                            id = a.id,
                            date = a.date,
                            waste_in = a.waste_in,
                            waste_out = a.waste_out,
                            id_type = a.id_type,
                            recycle_rate = a.waste_out / total * 100
                        };
                        db.Entry(nn).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                }
                else
                {
                    total = waste_in;
                }

                var s = new non_hazardous_record
                {
                    date = date,
                    waste_in = waste_in,
                    waste_out = waste_out,
                    id_type = id_type,
                    recycle_rate = waste_out / total * 100
                };

                db.non_hazardous_record.Add(s);
                db.SaveChanges();
            }
            finally
            {

            }
            return err;
        }

        #endregion

        public string generateError(List<string> err)
        {
            string html = "";
            if (err.Count > 0)
            {
                html += "<b>LOG</b>";
                html += "<br/>";
                html += "<ul>";
                foreach (string x in err)
                {
                    html += "<li>";
                    html += x;
                    html += "</li>";
                }
                html += "</ul>";
            }
            return html;
        }
    }
}