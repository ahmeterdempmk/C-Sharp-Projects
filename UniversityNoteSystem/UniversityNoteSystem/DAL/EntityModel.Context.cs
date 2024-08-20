namespace UniversityNoteSystem.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class UniversityNoteSystemEntities : DbContext
    {
        public UniversityNoteSystemEntities()
            : base("name=UniversityNoteSystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AcademicianTB> AcademicianTBs { get; set; }
        public virtual DbSet<DepartmentTB> DepartmentTBs { get; set; }
        public virtual DbSet<LessonTB> LessonTBs { get; set; }
        public virtual DbSet<NotesTB> NotesTBs { get; set; }
        public virtual DbSet<StudentTB> StudentTBs { get; set; }
    
        public virtual ObjectResult<averageCalculation_Result> averageCalculation()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<averageCalculation_Result>("averageCalculation");
        }
    }
}