namespace DiplomPracticRGSU.еуые
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Trainee")]
    public partial class Trainee
    {
        public int TraineeID { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Patronymic { get; set; }

        public int? LabID { get; set; }

        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }

        public int? EducationalID { get; set; }

        [Required]
        [StringLength(50)]
        public string Phone { get; set; }

        public virtual EducationInstitution EducationInstitution { get; set; }

        public virtual Laboratory Laboratory { get; set; }
    }
}
