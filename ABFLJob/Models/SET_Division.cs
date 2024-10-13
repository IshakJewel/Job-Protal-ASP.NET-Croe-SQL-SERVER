using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ABFLJob.Models
{
    public class SET_Division
    {
        public int Id { get; set; }
        [Required, Display(Name= "Division Name"), StringLength(100)]
        public string DivisonName { get; set; }
        public string Description { get; set; }
        public SET_District? SET_District { get; set; }
    }
}
