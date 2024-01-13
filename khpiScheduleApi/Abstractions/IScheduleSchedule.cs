using khpiScheduleApi.Enums.Parameters;
using khpiScheduleApi.Models;

namespace khpiScheduleApi.Abstractions
{
    public interface IScheduleSchedule
    {
        public List<Schedule> GetSchedules(Tuple<SchedulesParameters, string>[] parameters);
    }
}
