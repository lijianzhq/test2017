using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Test
{
    public class TestHttpUtility
    {
        public static void Test()
        {
            Test1();
        }

        static void Test1()
        {
            var sql = "SELECT%20PROD_LINE_GROUP_CODE%20value_column_name,PROD_LINE_GROUP_ID%20id_column_name,''%20meaning_column_name%20From%20PS_PRODUCTION_LINE_GROUP%20%20WHERE%20(PLANT_ID%20=%2086%20OR%20PLANT_ID%20=%20Null%20)%20AND%20ENABLE_FLAG%20=%20'Y'%20and%20exists(SELECT%201%20FROM%20ps_user_privilage%20a%20WHERE%201=1%20AND%20a.plant_id%20=86%20and%20a.user_id=base_api_pkg.GET_USER_ID%20AND%20a.product_line_group_id=prod_line_group_id)ORDER%20BY%20PROD_LINE_GROUP_CODE&tablename=PS_PRODUCTION_LINE_GROUP&ts=52822";
            Console.WriteLine(HttpUtility.UrlDecode(sql));
        }


        static void Test2()
        {
            Console.WriteLine("&middot;");
            Console.WriteLine(HttpUtility.HtmlDecode("&middot;"));
        }
    }
}
