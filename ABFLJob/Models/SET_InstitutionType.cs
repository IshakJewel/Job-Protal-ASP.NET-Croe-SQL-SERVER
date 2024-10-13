using System.ComponentModel.DataAnnotations;

namespace ABFLJob.Models
{
    public class SET_InstitutionType
    {
        public int Id { get; set; }
        [Required, Display(Name = "Institution Name"), StringLength(300)]
        public string InstitutionName {  get; set; }
        public string Description { get; set; }
        public SET_Degree? SET_Degree { get; set; }
        public Institution? Institution { get; set; }
    }
}
