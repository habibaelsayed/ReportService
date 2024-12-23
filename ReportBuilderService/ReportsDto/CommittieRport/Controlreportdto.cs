using ReportBuilderService.ReportsDto.CommittieRport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportBuilderService.ReportsDto.CommittieRport
{
    public class ControlReportDto : GenralReportDto
    {
        public override string FileName
        {
            get
            {

                return "ControlReport";
            }
        }

        public StudentGenralInformationDataSources StudentGenralData { get; set; }

        public FirstTermdata FirstTermData { get; set; }
        public SecondTermdata SecondTermData { get; set; }

    }

    public class StudentGenralInformationDataSources : GenralDataSource<ReportStudentGenralData>
    {

        public override string DataSourceName
        {
            get
            {

                return "StudentGenralData";
            }
        }




    }



    public class SecondTermdata : GenralDataSource<ReportTermData>
    {

        public override string DataSourceName
        {
            get
            {

                return "SecondTermData";
            }
        }




    }
    public class FirstTermdata : GenralDataSource<ReportTermData>
    {

        public override string DataSourceName
        {
            get
            {

                return "FirstTermData";
            }
        }




    }
}


