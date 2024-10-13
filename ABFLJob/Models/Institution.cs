using System.ComponentModel.DataAnnotations;

namespace ABFLJob.Models
{
    public class Institution
    {
        public int Id { get; set; }
        [Required, Display(Name = "Institution Name"), StringLength(300)]
        public string InstitutionName { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public bool IsForeignCountry { get; set; }
        public bool IsPrivateOrPublic { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }
        public DateTime CreateAt { get; set;}
        public SET_EducationalLevel? SET_EducationalLevel { get; set; }
        public List<SET_InstitutionType>? SET_InstitutionTypes { get; set; }
    }
}
