namespace DiplomPracticRGSU.еуые
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MasterClass")]
    public partial class MasterClass
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MasterClass()
        {
            Lab_MasterClass = new HashSet<Lab_MasterClass>();
        }

        public int MasterClassID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Duration { get; set; }

        [StringLength(50)]
        public string MasterClassTopic { get; set; }

        [StringLength(150)]
        public string Description { get; set; }

        [StringLength(100)]
        public string File { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lab_MasterClass> Lab_MasterClass { get; set; }
    }
}
