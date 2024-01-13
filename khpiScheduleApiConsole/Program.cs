using khpiScheduleApi;
using khpiScheduleApi.Enums.Parameters;

namespace khpiScheduleApiConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ScheduleHierarchy hierarchy = new ScheduleHierarchy();

            var res = hierarchy.GetAcademicGroups(new[] { Tuple.Create(AcademicGroupsParameters.name, "ММ-23-1")});
            var id = res[0].Id;

            Console.WriteLine(id);
            Console.WriteLine();

            ScheduleSchedule schedule = new ScheduleSchedule();

            var scheduleRes = schedule.GetSchedules(new[] { Tuple.Create(SchedulesParameters.groups, id) });
            foreach(var s in scheduleRes)
            {
                Console.WriteLine(s.DateFrom + " - " + s.DateTo);
                Console.WriteLine(s.Type == null ? s.Description : s.Type.Name);
            }
        }
    }
}
