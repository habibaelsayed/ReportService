namespace ReportBuilderService
{

    public class ReportParametersDto
    {
        private const string path = @"C:\Users\Ahmed\OneDrive\Desktop\projects\ReportService\ReportService\ReportBuilderService\reportfile\";

        public string Path { get
            {
                return path;
            }
                
                }
        public string ReportName { get; set; }
        public List<DataSource> dataSources { get; set; }
    }

    public class ReportParametersDto2
    {
        private const string path = @"C:\Users\Ahmed\OneDrive\Desktop\projects\ReportService\ReportService\ReportBuilderService\reportfile\";

        public string Path
        {
            get
            {
                return path;
            }

        }
        public string ReportName { get; set; }
        public List<DataSource2> dataSources { get; set; }
    }
    public class DataSource
    {
        public string DataSetName { get; set; } = string.Empty;
        public IEnumerable<object> DataList { get; set; } 

    }

    public class DataSource2
    {
        public string DataSetName { get; set; }
        public object Data { get; set; }
    }

}
