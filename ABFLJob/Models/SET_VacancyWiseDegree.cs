using System.ComponentModel.DataAnnotations;

namespace ABFLJob.Models
{
    public class SET_VacancyWiseDegree
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime LastUpdate { get; set; }
        public DateTime CreateAt { get; set; }
        
    }
}
