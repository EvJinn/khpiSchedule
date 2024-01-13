using khpiScheduleApi.Enums.Parameters;
using khpiScheduleApi.Models;

namespace khpiScheduleApi.Abstractions
{
    public interface IScheduleHierarchy
    {
        public List<AcademicGroup> GetAcademicGroups(Tuple<AcademicGroupsParameters, string>[] parameters);

        public List<Faculty> GetFaculties(string? page = null);

        public List<Profile> GetProfiles(string? page = null);

        public List<Speciality> GetSpecialities(Tuple<SpecialitiesParameters, string>[] parameters);
    }
}
