using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportBuilderService.ReportsDto.StudentReports
{
    public class AcdnoReportDto
    {
        public int Acdno { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
        public string Program { get; set; }
        public int SeatNumber { get; set; }
        public int CommNum { get; set; }
        public string CommPlace { get; set; }
        public string Floor { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Gov { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string NationalId { get; set; }
        public DateTime Date { get; set; }
        public string Image { get; set; }
    }
}
