using System.ComponentModel.DataAnnotations;

namespace ABFLJob.Models
{
    public class SET_Thana
    {
        public int Id { get; set; }
        [Required, StringLength(100), Display(Name = "Thana Name")]
        public string Thana { get; set; }
        public string Description { get; set; }
        public List<SET_District>? SET_District { get; set; }

    }
}
