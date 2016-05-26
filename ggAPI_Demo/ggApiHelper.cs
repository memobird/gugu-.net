using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json.Linq;

namespace ggAPI_Demo
{
    public static class ggApiHelper
    {

        public static string UserBind(string memobirdId, string useridentifying)
        {
            ggApi.Apis apis = new ggApi.Apis(GGConfig.ak, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            string url = GGConfig.url + "/home/setuserbind";
            string res = apis.UserBind(url, memobirdId, useridentifying);
            return res;
        }
        public static string PrintPaper(string memobirdID, string userID, string printcontent)
        {
            ggApi.Apis apis = new ggApi.Apis(GGConfig.ak, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            string url = GGConfig.url + "/home/printpaper";
            string res = apis.PrintPaper(url, memobirdID, userID, printcontent);
            return res;
        }
        public static string GetPrintStatus(string printcontentID)
        {
            ggApi.Apis apis = new ggApi.Apis(GGConfig.ak, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            string url = GGConfig.url + "/home/getprintstatus";
            string res = apis.GetPrintStatus(url, printcontentID);
            return res;
        }
    }
}
