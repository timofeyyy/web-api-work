using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace app.Entities
{
    public class Capacitors
    {
        [Key]
        public int ID { get; set; }
        public BigInteger DocID { get; set; }
        [Required]
        [StringLength(450)]
        public string ComponentName { get; set; }
        [Required]
        public ComponentTypes TypeID { get; set; }
        [Required]
        public ComponentKinds KindID { get; set; }
        [Required]
        public Manufacturers ManufacturerName_ID { get; set; }
        [StringLength(450)]
        public string OutputType { get; set; }
        public double MinVoltage { get; set; }
        public float MaxVoltage { get; set; }
        public float MaxCapacity { get; set; }
        public float MinCapacity { get; set; }
        public float MinOperatingTemperature { get; set; }
        public float MaxOperatingTemperature { get; set; }
        public float AcceptableCapacityIncrease { get; set; }
        public float AcceptableСapacityReduction { get; set; }

        [StringLength(450)]
        public string QualicationSG { get; set; }
        [StringLength(450)]
        public string QualicationЕС { get; set; }
        [StringLength(450)]
        public string Package { get; set; }
        [StringLength(450)]
        public string Remark1 { get; set; }
        [StringLength(450)]
        public string Remark2 { get; set; }
    }
}
