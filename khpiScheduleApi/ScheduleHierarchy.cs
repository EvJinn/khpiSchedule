using khpiScheduleApi.Abstractions;
using khpiScheduleApi.Enums.Parameters;
using khpiScheduleApi.Helpers;
using khpiScheduleApi.Models;
using Newtonsoft.Json.Linq;

namespace khpiScheduleApi
{
    public class ScheduleHierarchy : IScheduleHierarchy
    {
        private ScheduleApi api;
        public List<AcademicGroup> GetAcademicGroups(Tuple<AcademicGroupsParameters, string>[] parameters = null)
        {
            api = new ScheduleApi();

            Tuple<string, string>[]? parametersAsString = TupleEnumToTupleStringHelper.Convert(parameters);

            var result = api.GetResponseAsync("hierarchy/academic-groups", parametersAsString);

            JObject content = JObject.Parse(result.Content);
            IList<JToken> results = content["results"].Children().ToList();
            IList<AcademicGroup> academicGroups = new List<AcademicGroup>();
            foreach(var res in results) 
            {
                AcademicGroup academicGroup = res.ToObject<AcademicGroup>();
                academicGroups.Add(academicGroup);
            }

            return academicGroups.ToList();
        }

        public List<Faculty> GetFaculties(string? page = null)
        {
            api = new ScheduleApi();

            var result = api.GetResponseAsync("hierarchy/faculties", 
                                                         page != null ? new[] { Tuple.Create("page", page) } : null);

            JObject content = JObject.Parse(result.Content);
            IList<JToken> results = content["results"].Children().ToList();
            IList<Faculty> faculties = new List<Faculty>();
            foreach (var res in results)
            {
                Faculty faculty = res.ToObject<Faculty>();
                faculties.Add(faculty);
            }

            return faculties.ToList();
        }

        public List<Profile> GetProfiles(string? page = null)
        {
            api = new ScheduleApi();

            var result = api.GetResponseAsync("hierarchy/profiles",
                                                         page != null ? new[] { Tuple.Create("page", page) } : null);

            JObject content = JObject.Parse(result.Content);
            IList<JToken> results = content["results"].Children().ToList();
            IList<Profile> profiles = new List<Profile>();
            foreach (var res in results)
            {
                Profile profile = res.ToObject<Profile>();
                profiles.Add(profile);
            }

            return profiles.ToList();
        }

        public List<Speciality> GetSpecialities(Tuple<SpecialitiesParameters, string>[] parameters = null)
        {
            api = new ScheduleApi();

            Tuple<string, string>[]? parametersAsString = TupleEnumToTupleStringHelper.Convert(parameters);

            var result = api.GetResponseAsync("hierarchy/specialities", parametersAsString);

            JObject content = JObject.Parse(result.Content);
            IList<JToken> results = content["results"].Children().ToList();
            IList<Speciality> specialities = new List<Speciality>();
            foreach (var res in results)
            {
                Speciality academicGroup = res.ToObject<Speciality>();
                specialities.Add(academicGroup);
            }

            return specialities.ToList();
        }
    }
}
