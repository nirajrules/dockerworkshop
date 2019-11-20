using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleIISApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var apiUrl = Environment.GetEnvironmentVariable("API_URL",
EnvironmentVariableTarget.Machine);
            if (!string.IsNullOrEmpty(apiUrl))
            {
                var request = WebRequest.Create(apiUrl);
                using (var response = request.GetResponse())
                using (var responseStream = new
                StreamReader(response.GetResponseStream()))
                {
                    Response.Write(responseStream.ReadToEnd());
                }
            }
        }
    }
}