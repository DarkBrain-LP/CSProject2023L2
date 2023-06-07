using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSProject2023L2.Services.Contract;

namespace CSProject2023L2.Services
{
    public class LoginService : ILoginService // <LoginDTO> uncomment here if you are using an object for your queries. Change your Object type if it is not LoginDTO
    {
        //private readonly IApiBaseService<> apiBaseService;
        private readonly HttpClient _httpClient;

        public LoginService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> LoginAsync(string username, string password) // Change the params if you are using an object for your queries: add the object instead
        {
            try
            {
                var response = await _httpClient.GetAsync($"{Constant.BaseUrl}/{Constant.LoginUrl}?user={username}&password={password}");
                if (response.IsSuccessStatusCode)
                {
                    if(response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return false;
                    }

                    string content = await response.Content.ReadAsStringAsync();

                    // If the return type is an object, uncomment the following lines
                    // LoginDTO loginDto = JsonConvert.DeserializeObject<LoginDTO>(content);
                    // Add your login logic here. e.g : return loginDto.isSuccess

                    return true;
                }
                else
                {
                    string message = await response.Content.ReadAsStringAsync();
                    throw new Exception(message);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
