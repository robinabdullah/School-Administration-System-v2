//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace School_Administration_System_v2.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Image
    {
        public string Image_ID { get; set; }
        public string Admission_Student_ID { get; set; }
        public string Teacher_ID { get; set; }
        public string Image_Path { get; set; }
        public Nullable<System.DateTime> Saved_Date { get; set; }
    
        public virtual Admission_Student Admission_Student { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}