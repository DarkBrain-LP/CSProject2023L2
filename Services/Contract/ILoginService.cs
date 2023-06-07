using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject2023L2.Services.Contract
{
    public interface ILoginService //<T> uncomment the T if you are using an object for your queries
    {
        /// <summary>
        ///     Change the params if you are using an object for your queries
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<bool> LoginAsync(string username, string password);
    }
}
