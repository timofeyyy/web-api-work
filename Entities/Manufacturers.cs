using System.ComponentModel.DataAnnotations;

namespace app.Entities
{
    public class Manufacturers
    {
        [Key]
        public int ID { get; set; }

        [StringLength(450)]
        public string ManufacturerName { get; set; }

        public object Capacitors { get; set; }
        public object Resistors { get; set; }
        public object Diods { get; set; }
        public object Microchips { get; set; }
        public object Transistors { get; set; }
        
    }
}
