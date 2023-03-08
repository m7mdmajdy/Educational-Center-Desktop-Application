//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class GroupName
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GroupName()
        {
            this.Schedules = new HashSet<Schedule>();
            this.Student_Group = new HashSet<Student_Group>();
            this.Student_Group1 = new HashSet<Student_Group>();
            this.Rooms = new HashSet<Room>();
        }
    
        public int G_ID { get; set; }
        public string G_Name { get; set; }
        public Nullable<int> G_NoOfSession { get; set; }
        public Nullable<double> G_PriceOfSession { get; set; }
        public Nullable<int> G_Capacity { get; set; }
        public Nullable<System.DateTime> G_DateOFCreation { get; set; }
        public Nullable<bool> G_Availability { get; set; }
        public Nullable<int> Teacher_ID { get; set; }
        public double G_TotalPrice { get; set; }
        public string Grade { get; set; }
        public Nullable<int> AcademicYear_ID { get; set; }
    
        public virtual AcademicYear AcademicYear { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Schedule> Schedules { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Group> Student_Group { get; set; }
        public virtual Teacher Teacher { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Group> Student_Group1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Room> Rooms { get; set; }
    }
}
