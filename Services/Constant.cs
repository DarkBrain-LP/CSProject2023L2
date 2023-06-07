using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject2023L2.Services
{
    public static class Constant
    {
        public static string BaseUrl = "YOUR_API_BASE_URL"; // e.g: 192.168.10.14:7085/api/v1 
        public static string LoginUrl = $"{BaseUrl}/YOUR_LOGIN_ROUTE"; // e.g: /auth/login
    }
}
