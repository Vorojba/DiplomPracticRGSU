namespace DiplomPracticRGSU.еуые
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Laboratory")]
    public partial class Laboratory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Laboratory()
        {
            Lab_MasterClass = new HashSet<Lab_MasterClass>();
            Trainee = new HashSet<Trainee>();
        }

        [Key]
        public int LabID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }

        [Required]
        [StringLength(150)]
        public string HeadOfLab { get; set; }

        [StringLength(150)]
        public string PassportOfLab { get; set; }

        public int NumberOfSeats { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lab_MasterClass> Lab_MasterClass { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Trainee> Trainee { get; set; }
    }
}
