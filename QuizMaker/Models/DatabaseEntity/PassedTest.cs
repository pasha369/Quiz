//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuizMaker.Models.DatabaseEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class PassedTest
    {
        public int id { get; set; }
        public Nullable<int> testId { get; set; }
        public Nullable<int> userId { get; set; }
        public Nullable<int> score { get; set; }
    
        public virtual Tests Tests { get; set; }
        public virtual Users Users { get; set; }
    }
}