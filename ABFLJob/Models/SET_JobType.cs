using System.ComponentModel.DataAnnotations;

namespace ABFLJob.Models
{
    public class SET_JobType
    {
        public int Id { get; set; }
        [Required, Display(Name = "Job Type Name"), StringLength(200)]
        public string JobTypeName { get; set;}
        public string JobDescription { get; set;}
    }
}
