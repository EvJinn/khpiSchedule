﻿using khpiScheduleApi.Abstractions;
using khpiScheduleApi.Enums.Parameters;
using khpiScheduleApi.Helpers;
using khpiScheduleApi.Models;
using Newtonsoft.Json.Linq;

namespace khpiScheduleApi
{
    public class ScheduleSchedule : IScheduleSchedule
    {
        private ScheduleApi api;
        public List<Schedule> GetSchedules(Tuple<SchedulesParameters, string>[] parameters)
        {
            api = new ScheduleApi();

            Tuple<string, string>[]? parametersAsString = TupleEnumToTupleStringHelper.Convert(parameters);

            var result = api.GetResponseAsync("schedule", parametersAsString);

            JObject content = JObject.Parse(result.Content);
            IList<JToken> results = content["results"].Children().ToList();
            IList<Schedule> schedules = new List<Schedule>();
            foreach (var res in results)
            {
                Schedule schedule = res.ToObject<Schedule>();
                schedules.Add(schedule);
            }

            return schedules.ToList();
        }
    }
}
