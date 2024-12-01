using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace app.Entities
{
    public class Diods
    {
        [Key]
        public int ID { get; set; }
        public BigInteger DocID { get; set; }
        [Required]
        [StringLength(450)]
        public string ComponentName { get; set; }
        public ComponentTypes TypeID { get; set; }
        public ComponentKinds KindID { get; set; }
        public Manufacturers ManufacturerName_ID { get; set; }
        
        public float MaxPermissibleDCVoltage { get; set; }
        public float MinOperatingTemperature { get; set; }
        public float MaxOperatingTemperature { get; set; }
        public float MaxPermissibleAverageDirectCurrent { get; set; }
        public float MaxiPermissibleDirectCurrent { get; set; }
        public float RadiationResistance { get; set; }
        
        [StringLength(450)]
        public float RadiationResistanceI { get; set; }
        [StringLength(450)]
        public float QualicationSG { get; set; }

        [StringLength(450)]
        public float QualicationЕС { get; set; }
        [StringLength(450)]
        public float Package { get; set; }
        [StringLength(450)]
        public float Remark1 { get; set; } 
        [StringLength(450)]
        public float Remark2 { get; set; }


    }
}
