using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DiplomPracticRGSU.еуые
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model12")
        {
        }

        public virtual DbSet<EducationInstitution> EducationInstitution { get; set; }
        public virtual DbSet<Lab_MasterClass> Lab_MasterClass { get; set; }
        public virtual DbSet<Laboratory> Laboratory { get; set; }
        public virtual DbSet<MasterClass> MasterClass { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Trainee> Trainee { get; set; }
        public virtual DbSet<TypeOfEducationInstitution> TypeOfEducationInstitution { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TypeOfEducationInstitution>()
                .HasMany(e => e.EducationInstitution)
                .WithRequired(e => e.TypeOfEducationInstitution)
                .WillCascadeOnDelete(false);
        }
    }
}
