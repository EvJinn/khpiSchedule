using khpiScheduleApi.Models;
using RestSharp;

namespace khpiScheduleApi
{
    public class ScheduleApi
    {
        public RestResponse GetResponseAsync(string resource, Tuple<string, string>[] parameters = null)
        {
            var client = new RestClient("https://schedule-api.khpi.ru");

            var request = new RestRequest(resource, Method.Get);

            request.AddParameter("format", "json");

            if (parameters != null)
            {
                foreach (var param in parameters)
                    request.AddParameter(param.Item1, param.Item2);
            }

            var response = client.Execute(request);

            if (response.ErrorException != null) throw new ApplicationException(response.ErrorException.Message);

            return response;
        }
    }
}
