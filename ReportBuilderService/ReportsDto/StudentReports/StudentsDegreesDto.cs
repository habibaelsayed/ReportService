using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportBuilderService.ReportsDto.StudentReports
{
    public class StudentsDegreesDto
    {
       public BranchCounts Branch {  get; set; }
        public List<StudentSummary> Counts { get; set; }
    }
    public class BranchCounts
    {
        public string Branch { get; set; }
        public string Date { get; set; }


    }
    public class StudentSummary
    {
        public string Name { get; set; }
        public int? Students { get; set; }

    }
}
