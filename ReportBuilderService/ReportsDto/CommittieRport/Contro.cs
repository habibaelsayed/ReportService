using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportBuilderService.ReportsDto.CommittieRport
{



    public class ControlGovReportDot
    {

        public ReportStudentGenralData StudentGenralData { get; set; }

        public List<ReportTermData> FirstTermData { get; set; } = new List<ReportTermData>();
        public List<ReportTermData> SecondTermData { get; set; } = new List<ReportTermData>();

    }

    public class ReportStudentGenralData
    {
        public string StudentAcdno { get; set; } = string.Empty;
        public string StudentAname { get; set; } = string.Empty;
        public string Program { get; set; } = string.Empty;
        public string Level { get; set; } = string.Empty;
        public string StudentYearPoints { get; set; } = string.Empty;
        public string StudentGpa { get; set; } = string.Empty;
        public string StudentYearChours { get; set; } = string.Empty;
        public string RegisterFrom { get; set; } = string.Empty;
        public int NumberPage { get; set; }
        public int TotalPages { get; set; }

    }
    public class ReportTermData
    {
        public string Level { get; set; } = string.Empty;
        public string Term { get; set; } = string.Empty;
        public string Program { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;
        public string Idcou { get; set; } = string.Empty;
        public string CourseName { get; set; } = string.Empty;
        public int CourseCHourse { get; set; }
        public string StudentCourseGrade { get; set; } = string.Empty;
        public string StudentCoursePoints { get; set; } = string.Empty;
        public int StudentTermRegisteredHours { get; set; }
        public int StudentTermSuccessedHours { get; set; }
        public string SemsterGpa { get; set; } = string.Empty;
        public string StudentSemsterPoints { get; set; } = string.Empty;
        public string StudentSumPoints { get; set; } = string.Empty;
        public int CourseCount { get; set; }
    }
}


