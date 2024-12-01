using System.ComponentModel.DataAnnotations;

namespace app.Entities
{
    public class Technologies
    {
        [Key]
        public int ID { get; set; }
        [StringLength(450)]
        public string RuTechnologyName { get; set; }
        [StringLength(450)]
        public string EnTechnologyName { get; set; }
    }
}
