using System.ComponentModel.DataAnnotations;

namespace ABFLJob.Models
{
    public class SET_EducationalLevel
    {
        public int Id {  get; set; }
        [Required , Display(Name ="Level Of Education"), StringLength(200)]
        public string LevelOfEducation { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        public bool IsActive {  get; set; }
        public DateTime LastUpdate { get; set; }
        public DateTime CreateAT { get; set; }
        public SET_Degree? SET_Degree { get; set; }
        public List<SET_InstitutionType>? SET_InstitutionTypes { get; set; }
    }
}
