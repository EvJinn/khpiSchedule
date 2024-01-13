namespace khpiScheduleApi.Enums.Parameters
{
    public enum AcademicGroupsParameters
    {
        /// <summary>
        /// Id расписания, принадлежащего группе
        /// </summary>
        schedule,
        /// <summary>
        /// Id специальности группы
        /// </summary>
        speciality,
        /// <summary>
        /// Курс
        /// </summary>
        course,
        /// <summary>
        /// Id формы обучения группы (см. <see cref="EducationForm">EducationForm</see>)
        /// </summary>
        speciality__education_form,
        /// <summary>
        /// Id факультета группы
        /// </summary>
        speciality__faculty,
        /// <summary>
        /// Название группы (наприм. ММ-23-1)
        /// </summary>
        name,
        page
    }
}
