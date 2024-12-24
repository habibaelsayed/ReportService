using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportBuilderService.ReportsDto.StudentReports
{
    public class RegistrationCerDto
    {
        public string Name { get; set; }
        public string Nationality { get; set; }
        public string? BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string Level { get; set; }
        public string Program { get; set; }
        public string PhyYear { get; set; }
        public string Branch { get; set; }
        public string Dean { get; set; }
        public DateTime? Date { get; set; }
        public string? NationalId { get; set; }
        //public string? MilitaryId { get; set; }
        public string? reason { get; set; }
        public int? MilTriple1 { get; set; }
        public int? MilTriple2 { get; set; }
        public int? MilTriple3 { get; set; }


    }
}
