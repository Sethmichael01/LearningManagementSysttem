//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class ExamMarksTable
    {
        public int MarksID { get; set; }
        public int SessionProgrameSubjectSettingID { get; set; }
        public int ExamID { get; set; }
        public int ExamSettingID { get; set; }
        public int SubjectID { get; set; }
        public int TotalMarks { get; set; }
        public int ObtainMarks { get; set; }
    }
}
