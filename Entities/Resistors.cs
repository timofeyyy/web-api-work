using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace app.Entities
{
    public class Resistors
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
        public float PowerRating { get; set; }
        public float MinVoltage { get; set; }
        public float MaxVoltage { get; set; }
        public float MinRatedResistance { get; set; }
        public float MaxRatedResistance { get; set; }
        public float ResistanceTolerance { get; set; }
        public float MinOperatingTemperature { get; set; }
        public float MaxOperatingTemperature { get; set; }
        public float CurrentLimit { get; set; }

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
