using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Settings
{
    public static class RestClinetSettings
    {
        public static string Jwt { get; set; } = "TEST";
        public static string BaseUrl { get; set; } = "https://localhost:5001";
    }
}
