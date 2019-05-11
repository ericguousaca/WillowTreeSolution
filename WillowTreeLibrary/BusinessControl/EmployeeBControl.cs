using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Caching;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WillowTreeLibrary.BusinessModel;

namespace WillowTreeLibrary.BusinessControl
{
    public class EmployeeBControl
    {
        private const string cacheKey = "FaceGameData";
        public EmployeeBControl()
        { }
       
        public async Task<List<EmployeeBModel>> GetEmployeeList(string apiUrl)
        {
            List<EmployeeBModel> list = new List<EmployeeBModel> { };

            ObjectCache cache = MemoryCache.Default;

            if (cache.Contains(cacheKey))
            {
                list = (List<EmployeeBModel>)cache.Get(cacheKey);
            }
            else
            {
                HttpClient client = new HttpClient();
                string result = await client.GetStringAsync(apiUrl);

                list = JsonConvert.DeserializeObject<List<EmployeeBModel>>(result);

                // Store data in the cache    
                CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
                cacheItemPolicy.AbsoluteExpiration = DateTime.Now.AddMinutes(10);
                cache.Add(cacheKey, list, cacheItemPolicy);
            }

            return list;
        }
    }
}
