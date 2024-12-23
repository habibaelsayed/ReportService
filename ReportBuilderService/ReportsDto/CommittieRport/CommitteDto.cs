
namespace ReportBuilderService.ReportsDto.CommittieRport;


public class CommitteDto
{
    public CommitteGenralInformationDto GenralInformation { get; set; }
    public List<CommitteStudentformationDto> Students { get; set; } = new List<CommitteStudentformationDto>();
}


public class CommitteGenralInformationDto
{

    public string Term { get; set; } = string.Empty;
    public int CommNo { get; set; }
    public string CourseName { get; set; } = string.Empty;

    public string COMMITTEE { get; set; } = string.Empty;
    public string PhyYear { get; set; } = string.Empty;
    public string Program { get; set; } = string.Empty;

    public string Level { get; set; } = string.Empty;

    public string BranchName { get; set; } = string.Empty;

    public int StudentsCount { get; set; }

    public string examdate { get; set; } = string.Empty;


}


public class CommitteStudentformationDto
{
    public string Name { get; set; } = string.Empty;
    public int TryNumber { get; set; }
    public int StudentSitNumber { get; set; }
    public int? Section { get; set; }
}

public class StudentsCommittes
{
    public CommitteGenralInformationDto GeneralInformation { get; set; }
    public List<CommitteStudentformationDto> Students { get; set; }
}

public class CourseGeneralInformationDto
{
    public string CourseName { get; set; }
    public string PhyYear { get; set; }
    public string Program { get; set; }
    public string BranchName { get; set; }
    public string ExamDate { get; set; }
    public int StudentsCount { get; set; }
    public string Term { get; set; }
}

public class CourseDto
{

    public CourseGeneralInformationDto CourseInfo { get; set; }
    public List<CommitteStudentformationDto> Students { get; set; }

}





