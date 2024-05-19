namespace DiplomPracticRGSU.еуые
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Lab_MasterClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDLabMaster { get; set; }

        public int? LabID { get; set; }

        public int? MasterClassID { get; set; }

        public virtual Laboratory Laboratory { get; set; }

        public virtual MasterClass MasterClass { get; set; }
    }
}
