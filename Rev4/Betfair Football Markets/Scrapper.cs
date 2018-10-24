using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Betfair_Football_Markets
{
    class Scrapper
    {
        public static async Task GetObjAsync<T>(string url, Action<string, T> callback)
        {
            try
            {
                var req = (HttpWebRequest)WebRequest.Create(url);
                var resp = await req.GetResponseAsync();

                string content;
                using (var sr = new StreamReader(resp.GetResponseStream()))
                    content = await sr.ReadToEndAsync();

                JObject obj = JObject.Parse(content);

                callback(null, obj.ToObject<T>());
            }catch(Exception ex)
            {
                callback?.Invoke(ex.Message, default(T));
            }
        }
    }
}
