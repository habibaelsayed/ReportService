using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportBuilderService.ReportsDto
{



    public abstract class GenralReportDto
    {
        public abstract string FileName { get; }

    }
   public  abstract class GenralDataSource<T> where T : class 
    {
        public abstract string DataSourceName { get; }
        public List<T> DataList { get; set; } = new List<T>();  

    }

    public abstract class GeneralDataSource2<T> where T : class
    {
        public abstract string DataSourceName { get; }
        public T DataList { get; set; }

    }

}
