
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace DBFirstEF_LMS.Models
{

using System;
    using System.Collections.Generic;
    
public partial class Section
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Section()
    {

        this.Registereds = new HashSet<Registered>();

        this.Assignments = new HashSet<Assignment>();

        this.StudentAssignments = new HashSet<StudentAssignment>();

    }


    public int section_id { get; set; }

    public Nullable<int> course_id { get; set; }

    public Nullable<int> teacher_id { get; set; }

    public Nullable<int> semester_id { get; set; }

    public string day_of_week { get; set; }

    public Nullable<System.TimeSpan> start_time { get; set; }

    public Nullable<System.TimeSpan> end_time { get; set; }



    public virtual Course Course { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Registered> Registereds { get; set; }

    public virtual Semester Semester { get; set; }

    public virtual Staff Staff { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Assignment> Assignments { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<StudentAssignment> StudentAssignments { get; set; }

}

}
