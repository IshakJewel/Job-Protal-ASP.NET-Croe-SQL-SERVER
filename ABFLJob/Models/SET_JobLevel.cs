using System.ComponentModel.DataAnnotations;

namespace ABFLJob.Models
{
    public class SET_JobLevel
    {
        public string Id { get; set; }
        [Required, Display(Name = "Job Level Name"),StringLength(200) ]
        public string JobLevelName { get; set; }
        public string Description { get; set; }
        public DateTime LastUpdate { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
