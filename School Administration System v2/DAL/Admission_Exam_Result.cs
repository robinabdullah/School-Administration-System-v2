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
    
    public partial class Admission_Exam_Result
    {
        public string Admission_Exam_ID { get; set; }
        public string Admission_Student_ID { get; set; }
        public string Writtern_Exam_Mark { get; set; }
        public string Viva_Exam_Mark { get; set; }
        public string Written_Examiner_ID { get; set; }
        public string Viva_Examiner_ID { get; set; }
    
        public virtual Admission_Student Admission_Student { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Teacher Teacher1 { get; set; }
    }
}