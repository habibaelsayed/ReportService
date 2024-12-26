using ReportBuilderService.ReportsDto.StudentReports;

namespace ReportBuilderService.ReportsDto.CommittieRport
{
    public class CommitteReportDto : GenralReportDto
    {
        public override string FileName
        {
            get
            {

                return "datareport";
            }
        }

        public CommitteGenralInformationDataSources GenralInformation { get; set; }

        public CommitteStudentformationDtoDataSources CommitteStudentformationDto { get; set; }
    }

    public class CommitteGenralInformationDataSources : GenralDataSource<CommitteGenralInformationDto>
    {

        public override string DataSourceName
        {
            get
            {

                return "DataSet2";
            }
        }




    }



    public class CommitteStudentformationDtoDataSources : GenralDataSource<CommitteStudentformationDto>
    {

        public override string DataSourceName
        {
            get
            {

                return "DataSet1";
            }
        }




    }

    public class StudentDegreesDtoDataSource : GenralDataSource<BranchCounts>
    {
        public override string DataSourceName
        {
            get
            {
                return "DataSet1";
            }
        }

    }
    public class StudnetSummeryDtoDataSource : GenralDataSource<StudentSummary>
    {
        public override string DataSourceName
        {
            get
            {
                return "DataSet2";
            }
        }
    }
    public class CourseGeneralInfoDataSources : GenralDataSource<CourseGeneralInformationDto>
    {
        public override string DataSourceName
        {
            get
            {

                return "DataSet2";
            }
        }

    }
    public class SabhMalafDataSources : GeneralDataSource2<SahbMalafDto>
    {
        public override string DataSourceName
        {
            get
            {

                return "DataSet1";
            }
        }

    }
    public class RegistrationCerDataSource : GeneralDataSource2<RegistrationCerDto>
    {
        public override string DataSourceName
        {
            get
            {

                return "DataSet1";
            }
        }

    }

    public class AcdnoDataSources : GeneralDataSource2<AcdnoReportDto>
    {
        public override string DataSourceName
        {
            get
            {
                return "DataSet1";
            }
        }
    }


    public class StudentCardDataSource : GeneralDataSource2<StudentCardDto>
    {
        public override string DataSourceName
        {
            get
            {
                return "DataSet1";
            }
        }
    }

    public class StudentExpensesReportDto : GenralReportDto
    {
        public override string FileName
        {
            get
            {
                return "studentexpensesstatus";
            }
        }

        public StudentInfoDataSources StudentInfo { get; set; }
        public StudentExpensesDataSources StudentExpenses { get; set; }
        public PrePaidExpensesDataSources PrePaidExpenses { get; set; }
        public FeeDistypeDataSources FeeDistype { get; set; }

    }

    public class StudentInfoDataSources : GeneralDataSource2<StudentInfoDto>
    {
        public override string DataSourceName
        {
            get
            {
                return "DataSet1";
            }
        }
    }

    public class StudentExpensesDataSources : GeneralDataSource2<StudentExpensesDto>
    {
        public override string DataSourceName
        {
            get
            {
                return "DataSet2";
            }
        }
    }

    public class PrePaidExpensesDataSources : GenralDataSource<PrePaidExpenses>
    {
        public override string DataSourceName
        {
            get
            {
                return "DataSet3";
            }
        }
    }


    public class FeeDistypeDataSources : GenralDataSource<FeeDistypeDto>
    {
        public override string DataSourceName
        {
            get
            {
                return "DataSet4";
            }
        }
    }

    public class StudentsCourseReportDto : GenralReportDto
    {
        public override string FileName
        {
            get
            {
                return "studentscourse";
            }
        }

        public CourseGeneralInfoDataSources CourseGenralInformation { get; set; }

        public CommitteStudentformationDtoDataSources CommitteStudentformationDto { get; set; }
    }

    public class StudentDegreesReportDto:GenralReportDto
    {
        public override string FileName
        {
            get { return "studegrees"; }
        }
        public StudentDegreesDtoDataSource studentDegreesDtoData { get; set; }
        public StudnetSummeryDtoDataSource studnetSummeryDtoDataSource { get; set; }
    }
    public class StudentsCourseReportiiDto : GenralReportDto
    {
        public override string FileName
        {
            get
            {
                return "studentscourseii";
            }
        }

        public CourseGeneralInfoDataSources CourseGenralInformation { get; set; }

        public CommitteStudentformationDtoDataSources CommitteStudentformationDto { get; set; }
    }


    public class SahbMalafReportDto : GenralReportDto
    {
        public override string FileName
        {
            get
            {
                return "sahbmalaf";
            }
        }
        public SabhMalafDataSources sabhMalafDataSources { get; set; }
    }


    public class RegistrationCerReportfDto : GenralReportDto
    {
        public override string FileName
        {
            get
            {
                return "regcerf";
            }
        }
        public RegistrationCerDataSource registrationCerDataSource { get; set; }
    }

    public class AcdReportDto : GenralReportDto
    {
        public override string FileName
        {
            get
            {
                return "acdno";
            }
        }
        public AcdnoDataSources acdnoDataSources { get; set; }
    }


    public class RegistrationCerReportmDto : GenralReportDto
    {
        public override string FileName
        {
            get
            {
                return "regcerm";
            }
        }
        public RegistrationCerDataSource registrationCerDataSource { get; set; }
    }


    public class StudentCardReportIhmiDto : GenralReportDto
    {
        public override string FileName
        {
            get
            {
                return "ihmi";
            }
        }
        public StudentCardDataSource StudentCardDto { get; set; }

    }

    public class StudentCardReportHieDto : GenralReportDto
    {
        public override string FileName
        {
            get
            {
                return "hie";
            }
        }
        public StudentCardDataSource StudentCardDto { get; set; }

    }

    public class StudentCardReportHicitDto : GenralReportDto
    {
        public override string FileName
        {
            get
            {
                return "hicit";
            }
        }
        public StudentCardDataSource StudentCardDto { get; set; }

    }


}
