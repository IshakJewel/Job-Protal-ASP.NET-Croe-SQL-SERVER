using System.ComponentModel.DataAnnotations;

namespace ABFLJob.Models
{
    public class SET_Department
    {
        public int Id { get; set; }
        [Required, Display(Name = "Department Name"), StringLength(200)]
        public string DepartmentName { get; set; }
        public string DepartmentDescription { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
