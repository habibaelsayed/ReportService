using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportBuilderService.ReportsDto.StudentReports
{

    public class AllStudentExpensesDto
    {
        public StudentInfoDto studentInfo { get; set; }
        public StudentExpensesDto studentExpenses { get; set; }
    }

    public class StudentExpensesDto
    {
        public int? ExpensesT1 { get; set; }
        public int? ExpensesT2 { get; set; }
        public int? RemainderT1 { get; set; }
        public int? RemainderT2 { get; set; }
        public int? Mrahl { get; set; }
        public List<PrePaidExpenses> prePaidExpenses { get; set; }
        public int? Sabqa { get; set; }
        public int? PaidSabqa { get; set; }
        public List<FeeDistypeDto>? feeDistypes { get; set; }

    }

    public class StudentInfoDto
    {
        public int Acdno { get; set; }
        public string Branch { get; set; } = String.Empty;
        public string Date { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Nationality { get; set; } = String.Empty;
        public string Gender { get; set; }
        public string Level { get; set; } = String.Empty;
        public string Department { get; set; } = string.Empty;
        public string Address { get; set; } = String.Empty;
        public string Country { get; set; }
        public string Gov { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string Condition { get; set; }
        public string LastGrade { get; set; } = string.Empty;
        public string BirthDate { get; set; }
        public string Completed28Years { get; set; }
        public string PhyYear { get; set; }
        public int PhyYearId { get; set; }

    }

    public class PrePaidExpenses
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public decimal TicNo { get; set; }
        public string date { get; set; }
        public string PaidType { get; set; }
    }
    public class FeeDistypeDto
    {
        public string Distype { get; set; } = string.Empty;
        public decimal? DisPercent { get; set; }
        public decimal Amount { get; set; }
        public string Notes { get; set; } = string.Empty;
        public int Serial { get; set; }
        public string DisDate { get; set; }
    }
}
