using System.ComponentModel.DataAnnotations;

namespace ABFLJob.Models
{
    public class Com_Vacancy
    {
        public int Id { get; set; }
        [Required, Display(Name = "Department Name"), StringLength(200)]
        public string DepartmentName { get; set; }
        [Required, Display(Name = "Job Title"), StringLength(150)]
        public string JobTitle { get; set; }
        public int NoOfVacancy { get; set; }
        [Required, Display(Name = "Apply Instrucation"), StringLength(1000)]
        public string ApplyInstrucation { get; set; }
        public DateTime JobPublicationDate { get; set; }
        public DateTime JobDeadline { get; set; }
        public int AgeRange { get; set; }

        [Required, Display(Name = "Job Type Name"), StringLength(200)]
        public string JobTypeName { get; set; }
        [Required, StringLength(10)]
        public string Gender { get; set; }
        public string MyProperty { get; set; }
        [Required, Display(Name = "Job Level Name"), StringLength(200)]
        public string JobLevelName { get; set; }
        public string EducationQua { get; set; }
        public string JobDiscripition { get; set; }
        public string AdditionalReq{ get; set; }
        public string ExpericneDuration { get; set; }
        public string ExperienceDetails {  get; set; }
        public string SalaryRange { get; set; }
        public string JobStatus { get; set; }
        public bool IsClosed { get; set; }



        public List<SET_Department> SET_Departments { get; set; }
        public List<SET_JobType> SET_JobTypes { get; set; }
        public List<SET_JobLevel> SET_JobLevels { get; set; }

    }
}
