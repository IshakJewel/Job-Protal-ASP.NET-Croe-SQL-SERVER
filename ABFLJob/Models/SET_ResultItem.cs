using System.ComponentModel.DataAnnotations;

namespace ABFLJob.Models
{
    public class SET_ResultItem
    {
        public int Id {  get; set; }
        [Required, Display(Name ="Result Item"), StringLength(500)]
        public string ResultItem { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
