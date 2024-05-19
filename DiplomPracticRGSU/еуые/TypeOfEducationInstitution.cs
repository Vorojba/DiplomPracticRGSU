namespace DiplomPracticRGSU.еуые
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TypeOfEducationInstitution")]
    public partial class TypeOfEducationInstitution
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TypeOfEducationInstitution()
        {
            EducationInstitution = new HashSet<EducationInstitution>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TypeEducationID { get; set; }

        [Required]
        [StringLength(50)]
        public string NameOfType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EducationInstitution> EducationInstitution { get; set; }
    }
}
