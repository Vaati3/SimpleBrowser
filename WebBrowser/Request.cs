using System;
using System.Net.Http;
using System.Runtime;
using System.Text.RegularExpressions;

namespace Request
{
    public class Request
    {

        private System.Net.HttpStatusCode status;
        private string body;
        private string title;

        private string bulk;

        public System.Net.HttpStatusCode Status
        {
            get { return status; }
        }
        public string Body
        {
            get { return body; }
        }
        public string Title
        {
            get { return title.TrimEnd('\n'); }
        }

        public string Bulk
        {
            get { return bulk; }
        }

        private System.Net.Http.HttpClient client;

        public Request()
        {
            client = new System.Net.Http.HttpClient();
            body = "";
            bulk = "";
        }
        public Request(string home)
        {
            client = new System.Net.Http.HttpClient();
            body = "";
            bulk = "";
            get(home);
        }

        public void get(string uri)
        {
            title = "";
            try
            {
                if (!Uri.IsWellFormedUriString(uri, UriKind.Absolute))
                {
                    status = System.Net.HttpStatusCode.NotFound;
                    body = "";
                    return;
                }

                HttpResponseMessage res = client.GetAsync(uri).Result;
                status = res.StatusCode;
                body = res.Content.ReadAsStringAsync().Result;
                title = Regex.Match(body, @"\<title\b[^>]*\>\s*(?<Title>[\s\S]*?)\</title\>",
                    RegexOptions.IgnoreCase).Groups["Title"].Value;
            }
            catch
            {
                status = System.Net.HttpStatusCode.NotFound;
                body = "";
            }
        }

        private string getBulk(string uri)
        {
            string line = "";
            try
            {
                if (!Uri.IsWellFormedUriString(uri, UriKind.Absolute))
                {
                    return "404 0 " + uri;
                }

                HttpResponseMessage res = client.GetAsync(uri).Result;
                line += (int)res.StatusCode + " ";
                line += res.Content.ReadAsStringAsync().Result.Length;
                line += " " + uri;
            }
            catch
            {
                return "404 0 " + uri;
            }
            return line;
        }

        public void bulkDownload(string file)
        {
            try
            {
                foreach (string uri in System.IO.File.ReadLines(file))
                {
                    bulk += getBulk(uri) + Environment.NewLine;
                }
            }
            catch
            {
                bulk = "File doesn't exist";
            }
        }

        internal WebBrowser.WebBrowser WebBrowser
        {
            get => default;
            set
            {
            }
        }
    }
}