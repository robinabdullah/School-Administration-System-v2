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
    
    public partial class Result
    {
        public string Result_ID { get; set; }
        public string Subject_ID { get; set; }
        public string Mid { get; set; }
        public string Final { get; set; }
    
        public virtual Subject Subject { get; set; }
    }
}
