using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace rsms
{
    /// <summary>
    /// Summary description for Services
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Services : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [System.Web.Script.Services.ScriptMethod()]
        [System.Web.Services.WebMethod]
        public string[] GetParentID(string prefixText, int count)
        {
            DataTable dt = new DataTable();
            DataColumn dc = new DataColumn("Name", typeof(String));
            dt.Columns.Add(dc);

            DataRow dr = dt.NewRow();

            dr[0] = "Adil";
            dr[0] = "Ahmer";
            dr[0] = "Kamran";
            dr[0] = "Fasih";
            dr[0] = "Azeem";
            dr[0] = "Rana";
            dr[0] = "Humza";
            dr[0] = "Waleed";
            dr[0] = "Faizan Rafiq";
            dr[0] = "Mohsin";
            dr[0] = "Ahsan";
            dr[0] = "Arshad Ahmed";
            dr[0] = "Uncle Majboor";

            dt.Rows.Add(dr);

            //DataTable dt = null;
            DataView dv = null;
            List<string> suggestions = new List<string>();
            //dt = (DataTable)HttpContext.Current.Session["ParentID"];

            if ((dt != null))
            {
                dv = dt.Copy().DefaultView;
                dv.RowFilter = "Name like  '%" + prefixText + "%' ";
                dv.Sort = "ID Asc";

                string c = prefixText;
                double Num = 0;
                bool isNum = double.TryParse(c, out Num);
                int indx = 0;

                foreach (DataRowView dvr in dv)
                {
                    if (indx <= count)
                    {
                        suggestions.Add(AjaxControlToolkit.AutoCompleteExtender.CreateAutoCompleteItem(dvr["Name"].ToString(), dvr["Name"].ToString()));
                        indx += 1;
                    }

                }
            }
            return suggestions.ToArray();
        }
        
    }
}
