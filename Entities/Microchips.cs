using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace app.Entities
{
    public class Microchips
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
        public string Interfaces { get; set; }
        [Required]
        public float MinVoltage { get; set; }
        [Required]
        public float MaxVoltage { get; set; }
        public float Frequency { get; set; }
        [StringLength(450)]
        public float BitDepthValue { get; set; }
        public float ConsumptionCurrent { get; set; }
        [Required]
        public float TechnologyName_ID { get; set; }
        [Required]
        public float MinOperatingTemperature { get; set; }
        [Required]
        public float MaxOperatingTemperature { get; set; }
        public float RadiationResistance { get; set; }
        [StringLength(450)]
        public string RadiationResistanceI { get; set; }
        [StringLength(450)]
        public string MemoryFormat { get; set; }
        public float SamplingTime { get; set; }
        [StringLength(450)]
        public string Qualication { get; set; }
        [StringLength(450)]
        public string Remark1 { get; set; }
    }
}
