using System.ComponentModel.DataAnnotations;

namespace ABFLJob.Models
{
    public class SET_District
    {
        public int Id { get; set; }
        [Required, StringLength(100), Display(Name = "District Name")]
        public string DistrictName { get; set; }
        public string Description { get; set;}
        public SET_Thana? SET_Thana { get; set; }
        public List<SET_Division> Divisions { get; set;}
    }
}
