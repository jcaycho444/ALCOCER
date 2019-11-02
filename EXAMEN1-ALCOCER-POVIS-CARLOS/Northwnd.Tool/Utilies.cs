using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwnd.Tool
{
    public class Utilies
    {

        public static string HTMLEncode(String strHTML)
        {
            try
            {
                string strHTMLEncode = string.Empty;
                strHTMLEncode = System.Net.WebUtility.HtmlEncode(strHTML);
                return strHTMLEncode;
            }
            catch (Exception)
            {

                return strHTML;
            }
        }
        public static string HTMLDecode(String strHTML)
        {
            try
            {
                string strHTMLEncode = string.Empty;
                strHTMLEncode = System.Net.WebUtility.HtmlDecode(strHTML);
                return strHTMLEncode;
            }
            catch (Exception)
            {

                return strHTML;
            }
        }

        //DATE
        public static DateTime FormatDate(string strDate)
        {
            DateTime datDate = new DateTime();
            try
            {

                if (!DateTime.TryParse(strDate, out datDate))
                {
                    datDate = Convert.ToDateTime(strDate, System.Globalization.CultureInfo.GetCultureInfo("en-Us").DateTimeFormat);
                }

            }
            catch (Exception ex)
            {
                String[] FechaArray = strDate.Split('/');
                datDate = new DateTime(int.Parse(FechaArray[2]), int.Parse(FechaArray[1]), int.Parse(FechaArray[0]));


            }
            return datDate;
        }





    }
}
