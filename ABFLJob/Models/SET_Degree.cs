using System.ComponentModel.DataAnnotations;

namespace ABFLJob.Models
{
    public class SET_Degree
    {
        public int Id { get; set; }
        [Required, Display(Name = "Degree Name"), StringLength(500)]
        public string DegreeName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }
        public List<SET_InstitutionType>? SET_InstitutionTypes { get; set; }
        public List<SET_EducationalLevel>? SET_EducationalLevels { get; set; }
    }
}
