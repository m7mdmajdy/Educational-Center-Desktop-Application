﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace trainingCenter
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EDPCenterEntities : DbContext
    {
        public EDPCenterEntities()
            : base("name=EDPCenterEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AcademicYear> AcademicYears { get; set; }
        public virtual DbSet<Attendence> Attendences { get; set; }
        public virtual DbSet<Cost> Costs { get; set; }
        public virtual DbSet<Daily_Transaction> Daily_Transaction { get; set; }
        public virtual DbSet<GroupName> GroupNames { get; set; }
        public virtual DbSet<Guest_workspace> Guest_workspace { get; set; }
        public virtual DbSet<Guest_WorkSpace_Attend> Guest_WorkSpace_Attend { get; set; }
        public virtual DbSet<Instructor_Attendence> Instructor_Attendence { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Student_Group> Student_Group { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Total_Transaction> Total_Transaction { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<User_Attend> User_Attend { get; set; }
    
        public virtual ObjectResult<Nullable<double>> DailyTotalExpenses()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<double>>("DailyTotalExpenses");
        }
    
        public virtual ObjectResult<Nullable<double>> DailyTotalRevenue()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<double>>("DailyTotalRevenue");
        }
    
        public virtual ObjectResult<GetDailyExpensesAndRevenue_Result> GetDailyExpensesAndRevenue()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetDailyExpensesAndRevenue_Result>("GetDailyExpensesAndRevenue");
        }
    }
}
