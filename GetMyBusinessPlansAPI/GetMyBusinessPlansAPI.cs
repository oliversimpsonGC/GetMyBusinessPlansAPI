using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace GetMyBusinessPlansAPI
{
    public static class GetMyBusinessPlansAPI
    {
        [FunctionName("GetMyBusinessPlansApi")]
        public static async Task<IActionResult> GetMyBusinessPlansApi(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            //validate request
            //Helpers.RequestHelper requestHelper = new Helpers.RequestHelper();
            //var dosomethin = requestHelper.ValidateRequest(req);

            //do anubius stuff
            Helpers.RetrieveBusinessPlansOracle Plans = new Helpers.RetrieveBusinessPlansOracle();
            var result = Plans.GetAnubisBusinessPlans(log);

            return new OkObjectResult(result);
        }
    }
}
