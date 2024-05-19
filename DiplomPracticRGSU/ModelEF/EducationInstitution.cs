namespace DiplomPracticRGSU.ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EducationInstitution")]
    public partial class EducationInstitution
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EducationInstitution()
        {
            Trainee = new HashSet<Trainee>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EducationalID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int TypeEducationID { get; set; }

        [Required]
        [StringLength(150)]
        public string Address { get; set; }

        [Required]
        [StringLength(150)]
        public string Email { get; set; }

        [Required]
        [StringLength(150)]
        public string ContactPerson { get; set; }

        [Required]
        [StringLength(50)]
        public string PhoneContact { get; set; }

        [StringLength(150)]
        public string Contract { get; set; }

        public int? CostOfTrainees { get; set; }

        [StringLength(100)]
        public string ContractTime { get; set; }

        public virtual TypeOfEducationInstitution TypeOfEducationInstitution { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Trainee> Trainee { get; set; }
    }
}
