using Microsoft.AspNetCore.Mvc;
using ReportBuilderService;
using ReportBuilderService.ReportBuilder;
using ReportBuilderService.ReportsDto.CommittieRport;
using ReportBuilderService.ReportsDto.StudentReports;

namespace ReportService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        //   [HttpPost("GetReport")]

        //  public async Task<IActionResult> GetReport( List<CommitteDto>   committeDtos   )
        //   {


        //       List<CommitteReportDto> committeReportDtos = new List<CommitteReportDto>();

        //       foreach (var item in committeDtos)
        //       {
        //           var onerport = new CommitteReportDto
        //           {
        //               CommitteStudentformationDto = new CommitteStudentformationDtoDataSources { DataList = item.Students }
        //          ,
        //               GenralInformation = new CommitteGenralInformationDataSources
        //               {
        //                   DataList = new List<CommitteGenralInformationDto> { item.GenralInformation }
        //               }
        //           };
        //           committeReportDtos.Add(onerport);
        //       }

        //       var para = new List<ReportParametersDto>();
        //       if (committeReportDtos.Count <0 ) { 

        //       return BadRequest();    
        //       }
        //       foreach (var item in committeReportDtos)
        //       {
        //           var x = new List<DataSource>();
        //           var onereport = new ReportParametersDto { ReportName = item.FileName    };


        //           x.Add(new DataSource { DataSetName = item.CommitteStudentformationDto.DataSourceName, DataList = item.CommitteStudentformationDto.DataList });
        //       x.Add(new DataSource { DataSetName = item.GenralInformation.DataSourceName, DataList = item.GenralInformation.DataList });

        //           onereport.dataSources = x;
        //           para.Add(onereport);

        //       }
        //       //   var content = JsonConvert.DeserializeObject<List<ReportParametersDto>>(ReportParametersDto.data);

        //       //foreach (var item in content)
        //       //{
        //       //    Console.WriteLine(item.ReportName);
        //       //    foreach (var itemm in item.dataSources)
        //       //    {
        //       //        Console.WriteLine(itemm.DataSetName); 
        //       //        if (itemm.DataSetName == "DataSet2")
        //       //        {

        //       //        var z =     itemm.DataList as List<CommitteGenralInformationDto>;
        //       //            foreach (var item2 in z)
        //       //            {
        //       //                Console.WriteLine( item2.CourseName );
        //       //                Console.WriteLine(item2.CourseName);

        //       //            }

        //       //        }

        //       //    };

        //       //}
        //       var Reports =  RdlReport.GetReportPdfDataAsync(para);
        ////      System.IO.File.WriteAllBytes(@"C:\Users\Administrator\source\repos\ReportService\ReportBuilderService\reportfile\heddyyyllo.pdf", Reports);


        //       return Ok(Reports); 

        //   }


        [HttpPost("GetReport")]
        public IActionResult GetReport(List<StudentsCommittes>? studentsCommittes)
        {


            List<CommitteReportDto> committeReportDtos = new List<CommitteReportDto>();

            foreach (var item in studentsCommittes)
            {
                var onerport = new CommitteReportDto
                {
                    CommitteStudentformationDto = new CommitteStudentformationDtoDataSources { DataList = item.Students }
               ,
                    GenralInformation = new CommitteGenralInformationDataSources
                    {
                        DataList = new List<CommitteGenralInformationDto> { item.GeneralInformation }
                    }
                };
                committeReportDtos.Add(onerport);
            }

            var para = new List<ReportParametersDto>();
            if (committeReportDtos.Count < 0)
            {

                return BadRequest();
            }
            foreach (var item in committeReportDtos)
            {
                var x = new List<DataSource>();
                var onereport = new ReportParametersDto { ReportName = item.FileName };


                x.Add(new DataSource { DataSetName = item.CommitteStudentformationDto.DataSourceName, DataList = item.CommitteStudentformationDto.DataList });
                x.Add(new DataSource { DataSetName = item.GenralInformation.DataSourceName, DataList = item.GenralInformation.DataList });

                onereport.dataSources = x;
                para.Add(onereport);

            }

            var Reports = RdlReport.GetReportPdfDataAsync(para);


            return Ok(Reports);

        }


        [HttpPost("StudentsDegreeCounts")]
        public IActionResult GetStudentsDegreeCounts(List<StudentsDegreesDto> studentsDegreesDtos)
        {
            List<StudentDegreesReportDto> studentDegreesReportDtos = new List<StudentDegreesReportDto>();
            foreach (var studentDegreesDto in studentsDegreesDtos)
            {
                var oneport = new StudentDegreesReportDto
                {
                    
                    studnetSummeryDtoDataSource = new StudnetSummeryDtoDataSource { DataList =   studentDegreesDto.Counts }
                    ,studentDegreesDtoData = new StudentDegreesDtoDataSource
                    {
                        DataList = new List<BranchCounts> { studentDegreesDto.Branch }
                    }
                };
                studentDegreesReportDtos.Add(oneport);

            }
            if (studentDegreesReportDtos == null)
            {
                return BadRequest();
            }
            var para = new List<ReportParametersDto>();
            if (studentDegreesReportDtos.Count < 0)
            {

                return BadRequest();
            }
            foreach (var item in studentDegreesReportDtos)
            {
                var x = new List<DataSource>();
                var onereport = new ReportParametersDto { ReportName = item.FileName };


                x.Add(new DataSource { DataSetName = item.studentDegreesDtoData.DataSourceName, DataList = item.studentDegreesDtoData.DataList });
                x.Add(new DataSource { DataSetName = item.studnetSummeryDtoDataSource.DataSourceName, DataList=item.studnetSummeryDtoDataSource.DataList });

                onereport.dataSources = x;
                para.Add(onereport);

            }

            var Reports = RdlReport.GetReportPdfDataAsync(para);


            return Ok(Reports);

        }
        [HttpPost("GetStudentFinancialStatusReport")]
        public IActionResult GetStudentFinancialStatusReport(AllStudentExpensesDto studentExpensesDto)
        {


            StudentExpensesReportDto studentExpensesReport = new StudentExpensesReportDto()
            {
                StudentInfo = new StudentInfoDataSources() { DataList = studentExpensesDto.studentInfo },
                StudentExpenses = new StudentExpensesDataSources() { DataList = studentExpensesDto.studentExpenses },
                PrePaidExpenses = new PrePaidExpensesDataSources() { DataList = studentExpensesDto.studentExpenses.prePaidExpenses },
                FeeDistype = new FeeDistypeDataSources() { DataList = studentExpensesDto.studentExpenses.feeDistypes }
            };

            if (studentExpensesReport == null)
            {
                return BadRequest();
            }

            var x = new List<DataSource>();
            var onereport = new ReportParametersDto { ReportName = studentExpensesReport.FileName };

            var listStudentInfo = new List<StudentInfoDto>() { studentExpensesReport.StudentInfo.DataList };
            var listStudentExpenses = new List<StudentExpensesDto>() { studentExpensesReport.StudentExpenses.DataList };

            x.Add(new DataSource { DataSetName = studentExpensesReport.StudentExpenses.DataSourceName, DataList = listStudentExpenses });
            x.Add(new DataSource { DataSetName = studentExpensesReport.StudentInfo.DataSourceName, DataList = listStudentInfo });
            x.Add(new DataSource { DataSetName = studentExpensesReport.PrePaidExpenses.DataSourceName, DataList = studentExpensesReport.PrePaidExpenses.DataList });
            x.Add(new DataSource { DataSetName = studentExpensesReport.FeeDistype.DataSourceName, DataList = studentExpensesReport.FeeDistype.DataList });

            onereport.dataSources = x;

            var reports = new List<ReportParametersDto>();

            reports.Add(onereport);

            var Reports = RdlReport.GetReportPdfDataAsync(reports);


            return Ok(Reports);

        }

        [HttpPost("StudentsCourse")]
        public IActionResult GetStudentsCourse(CourseDto courseDto)
        {
            StudentsCourseReportDto studentsCourseReport = new StudentsCourseReportDto
            {
                CourseGenralInformation = new CourseGeneralInfoDataSources { DataList = new List<CourseGeneralInformationDto> { courseDto.CourseInfo } },
                CommitteStudentformationDto = new CommitteStudentformationDtoDataSources { DataList =  courseDto.Students }

            };


            if (studentsCourseReport == null)
            {

                return BadRequest();
            }

            var x = new List<DataSource>();
            var onereport = new ReportParametersDto { ReportName = studentsCourseReport.FileName };
            //var listCourseInfo = new List<CourseGeneralInformationDto> { }

            //var listStudentsCourse = new List<CourseGeneralInformationDto>() { studentsCourseReport.CourseGenralInformation.DataList  };

            x.Add(new DataSource { DataSetName = studentsCourseReport.CommitteStudentformationDto.DataSourceName, DataList = studentsCourseReport.CommitteStudentformationDto.DataList });
            x.Add(new DataSource { DataSetName = studentsCourseReport.CourseGenralInformation.DataSourceName, DataList = studentsCourseReport.CourseGenralInformation.DataList });

            onereport.dataSources = x;

            var reports = new List<ReportParametersDto>();

            reports.Add(onereport);

            var Reports = RdlReport.GetReportPdfDataAsync(reports);


            return Ok(Reports);


        }

        [HttpPost("StudentsCourseWithSec")]
        public IActionResult GetStudentsCourseWithSec(List<CourseDto> courseDto)
        {
            List<StudentsCourseReportiiDto> studentsCourseReport = new List<StudentsCourseReportiiDto>();

            foreach (var item in courseDto)
            {
                var onerport = new StudentsCourseReportiiDto()
                {
                    CommitteStudentformationDto = new CommitteStudentformationDtoDataSources { DataList = item.Students },

                    CourseGenralInformation= new CourseGeneralInfoDataSources
                    {
                        DataList = new List<CourseGeneralInformationDto> { item.CourseInfo }
                    }
                };
                studentsCourseReport.Add(onerport);
            }


            if (studentsCourseReport == null)
            {

                return BadRequest();
            }


            var para = new List<ReportParametersDto>();
            if (studentsCourseReport.Count < 0)
            {

                return BadRequest();
            }
            foreach (var item in studentsCourseReport)
            {
                var x = new List<DataSource>();
                var onereport = new ReportParametersDto { ReportName = item.FileName };


                x.Add(new DataSource { DataSetName = item.CommitteStudentformationDto.DataSourceName, DataList = item.CommitteStudentformationDto.DataList });
                x.Add(new DataSource { DataSetName = item.CourseGenralInformation.DataSourceName, DataList = item.CourseGenralInformation.DataList });

                onereport.dataSources = x;
                para.Add(onereport);

            }

            var Reports = RdlReport.GetReportPdfDataAsync(para);


            return Ok(Reports);


        }


        [HttpPost("RegistrationCerf")]

        public async Task<IActionResult> GetRegistrationCerf(RegistrationCerDto registrationCerDto)
        {
            RegistrationCerReportfDto registrationCerReportDto = new RegistrationCerReportfDto
            {
                registrationCerDataSource=new RegistrationCerDataSource { DataList=registrationCerDto }
            };
            if (registrationCerReportDto==null)
            {
                return BadRequest();
            }
            var x = new List<DataSource>();
            var onereport = new ReportParametersDto { ReportName = registrationCerReportDto.FileName };
            var listRegistrationCer = new List<RegistrationCerDto>() { registrationCerReportDto.registrationCerDataSource.DataList };
            x.Add(new DataSource { DataSetName = registrationCerReportDto.registrationCerDataSource.DataSourceName, DataList = listRegistrationCer });
            onereport.dataSources = x;

            var reports = new List<ReportParametersDto>();

            reports.Add(onereport);

            var Reports = RdlReport.GetReportPdfDataAsync(reports);


            return Ok(Reports);

        }

        [HttpPost("AcdnoReport")]
        public async Task<IActionResult> GetAcdnoReport(AcdnoReportDto acdnoReport)
        {
            AcdReportDto acdReportDto = new AcdReportDto
            {
                acdnoDataSources = new AcdnoDataSources { DataList = acdnoReport }
            };
            if (acdReportDto==null)
                return BadRequest();

            var x = new List<DataSource>();
            var onereport = new ReportParametersDto { ReportName = acdReportDto.FileName };
            var listAcdno = new List<AcdnoReportDto> { acdReportDto.acdnoDataSources.DataList };
            x.Add(new DataSource { DataSetName = acdReportDto.acdnoDataSources.DataSourceName, DataList = listAcdno });
            onereport.dataSources= x;

            var reports = new List<ReportParametersDto>();
            reports.Add(onereport);
            var Reports = RdlReport.GetReportPdfDataAsync(reports);
            return Ok(Reports);

        }


        [HttpPost("RegistrationCerm")]

        public async Task<IActionResult> GetRegistrationCerm(RegistrationCerDto registrationCerDto)
        {
            RegistrationCerReportmDto registrationCerReportDto = new RegistrationCerReportmDto
            {
                registrationCerDataSource=new RegistrationCerDataSource { DataList=registrationCerDto }
            };
            if (registrationCerReportDto==null)
            {
                return BadRequest();
            }
            var x = new List<DataSource>();
            var onereport = new ReportParametersDto { ReportName = registrationCerReportDto.FileName };
            var listRegistrationCer = new List<RegistrationCerDto>() { registrationCerReportDto.registrationCerDataSource.DataList };
            x.Add(new DataSource { DataSetName = registrationCerReportDto.registrationCerDataSource.DataSourceName, DataList = listRegistrationCer });
            onereport.dataSources = x;

            var reports = new List<ReportParametersDto>();

            reports.Add(onereport);

            var Reports = RdlReport.GetReportPdfDataAsync(reports);


            return Ok(Reports);

        }

        [HttpPost("SahbMalafReport")]
        public IActionResult GetSahbMalafReport(SahbMalafDto sahbMalafDto)
        {
            SahbMalafReportDto sahbMalafReportDto = new SahbMalafReportDto
            {
                sabhMalafDataSources=new SabhMalafDataSources { DataList=sahbMalafDto }
            };

            if (sahbMalafReportDto == null)
            {

                return BadRequest();
            }

            var x = new List<DataSource>();
            var onereport = new ReportParametersDto { ReportName = sahbMalafReportDto.FileName };
            var listSahbMalafReport = new List<SahbMalafDto>() { sahbMalafReportDto.sabhMalafDataSources.DataList };

            x.Add(new DataSource { DataSetName = sahbMalafReportDto.sabhMalafDataSources.DataSourceName, DataList = listSahbMalafReport });
            onereport.dataSources = x;

            var reports = new List<ReportParametersDto>();

            reports.Add(onereport);

            var Reports = RdlReport.GetReportPdfDataAsync(reports);


            return Ok(Reports);
        }


        [HttpPost("GetStudentCardIhmi")]
        public async Task<IActionResult> GetStudentCardIhmi(StudentCardDto studentCardDto)
        {

            StudentCardReportIhmiDto studentCardReport = new StudentCardReportIhmiDto()
            {
                StudentCardDto = new StudentCardDataSource() { DataList = studentCardDto }
            };

            if (studentCardReport == null) return BadRequest();

            var listOfStudentCards = new List<StudentCardDto>() { studentCardReport.StudentCardDto.DataList };

            var x = new List<DataSource>();

            var oneReport = new ReportParametersDto { ReportName = studentCardReport.FileName };

            x.Add(new DataSource { DataSetName =  studentCardReport.StudentCardDto.DataSourceName, DataList = listOfStudentCards });

            oneReport.dataSources = x;

            var reports = new List<ReportParametersDto>();

            reports.Add(oneReport);

            var Reports = RdlReport.GetReportPdfDataAsync(reports);


            return Ok(Reports);


        }

        [HttpPost("GetStudentCardHie")]
        public async Task<IActionResult> GetStudentCardHie(StudentCardDto studentCardDto)
        {

            StudentCardReportHieDto studentCardReport = new StudentCardReportHieDto()
            {
                StudentCardDto = new StudentCardDataSource() { DataList = studentCardDto }
            };

            if (studentCardReport == null) return BadRequest();

            var listOfStudentCards = new List<StudentCardDto>() { studentCardReport.StudentCardDto.DataList };

            var x = new List<DataSource>();

            var oneReport = new ReportParametersDto { ReportName = studentCardReport.FileName };

            x.Add(new DataSource { DataSetName =  studentCardReport.StudentCardDto.DataSourceName, DataList = listOfStudentCards });

            oneReport.dataSources = x;

            var reports = new List<ReportParametersDto>();

            reports.Add(oneReport);

            var Reports = RdlReport.GetReportPdfDataAsync(reports);


            return Ok(Reports);


        }

        [HttpPost("GetStudentCardHicit")]
        public async Task<IActionResult> GetStudentCardHicit(StudentCardDto studentCardDto)
        {

            StudentCardReportHicitDto studentCardReport = new StudentCardReportHicitDto()
            {
                StudentCardDto = new StudentCardDataSource() { DataList = studentCardDto }
            };

            if (studentCardReport == null) return BadRequest();

            var listOfStudentCards = new List<StudentCardDto>() { studentCardReport.StudentCardDto.DataList };

            var x = new List<DataSource>();

            var oneReport = new ReportParametersDto { ReportName = studentCardReport.FileName };

            x.Add(new DataSource { DataSetName =  studentCardReport.StudentCardDto.DataSourceName, DataList = listOfStudentCards });

            oneReport.dataSources = x;

            var reports = new List<ReportParametersDto>();

            reports.Add(oneReport);

            var Reports = RdlReport.GetReportPdfDataAsync(reports);


            return Ok(Reports);


        }



        [HttpPost("GetGovReport")]

        public async Task<IActionResult> GetGovReport(List<ControlGovReportDot> ControlGovReportD)
        {


            List<ControlReportDto> controlReports = new List<ControlReportDto>();

            foreach (var item in ControlGovReportD)
            {
                var onerport = new ControlReportDto
                {
                    StudentGenralData =   new StudentGenralInformationDataSources { DataList = new List<ReportStudentGenralData> { item.StudentGenralData } }
               ,
                    FirstTermData = new FirstTermdata { DataList = item.FirstTermData },
                    SecondTermData = new SecondTermdata { DataList=  item.SecondTermData }
                };
                controlReports.Add(onerport);
            }

            var para = new List<ReportParametersDto>();
            if (controlReports.Count < 0)
            {

                return BadRequest();
            }
            foreach (var item in controlReports)
            {
                var x = new List<DataSource>();
                var onereport = new ReportParametersDto { ReportName = item.FileName };


                x.Add(new DataSource { DataSetName = item.StudentGenralData.DataSourceName, DataList = item.StudentGenralData.DataList });
                x.Add(new DataSource { DataSetName = item.FirstTermData.DataSourceName, DataList = item.FirstTermData.DataList });
                x.Add(new DataSource { DataSetName = item.SecondTermData.DataSourceName, DataList = item.SecondTermData.DataList });
                onereport.dataSources = x;
                para.Add(onereport);

            }
            var Reports = RdlReport.GetReportPdfDataAsync2(para);
            return Ok(Reports);

        }






        [HttpPost("GetAllReport")]

        public async Task<IActionResult> GetAllReport(List<byte[]> bytes)
        {
            var final = RdlReport.concatAndAddContent(bytes);
            System.IO.File.WriteAllBytes(@"C:\Users\Administrator\source\repos\ReportService\ReportBuilderService\reportfile\report11252.pdf", final);

            return Ok(final);
        }


        [HttpGet]
        [Route("tests")]
        //    [Authorize(Roles = "Control,Admin")]
        public async Task<IActionResult> tests()
        {
            var x = DateTime.Now.AddMinutes(4);
            while (DateTime.Now < x)
            {
                if (DateTime.Now.Minute < x.Minute)
                {
                    await Console.Out.WriteLineAsync(DateTime.Now.ToString());

                }


            }
            return Ok(DateTime.Now);


        }



    }
    public class dd
    {

        public string data { get; set; }
    }
}
