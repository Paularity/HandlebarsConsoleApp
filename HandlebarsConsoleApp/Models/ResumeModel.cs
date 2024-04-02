namespace HandlebarsConsoleApp.Models;

public class ChildModel
{
    public string Name { get; set; }
    public string DateOfBirth { get; set; }
}

public class WorkExperienceModel
{
    public string Title { get; set; }
    public string Company { get; set; }
    public string StartDate { get; set; }
    public string EndDate { get; set; }
}

public class EducationModel
{
    public string Degree { get; set; }
    public string Institution { get; set; }
    public string GraduationYear { get; set; }
}

public class ResumeModel
{
    public string ProfileImageUri { get; set; }
    public string PositionDesired { get; set; }
    public string Date { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string EmailAddress { get; set; }
    public string DateOfBirth { get; set; }
    public string CivilStatus { get; set; }
    public string Citizenship { get; set; }
    public double Height { get; set; }
    public int Weight { get; set; }
    public string Spouse { get; set; }
    public string SpouseOccupation { get; set; }
    public List<ChildModel> Children { get; set; }
    public string Father { get; set; }
    public string FatherDateOfBirth { get; set; }
    public string Mother { get; set; }
    public string MotherDateOfBirth { get; set; }
    public string[] LanguagesSpoken { get; set; }
    public string EmergencyPersonContact { get; set; }
    public string PersonContactPhoneNumber { get; set; }
    public List<WorkExperienceModel> WorkExperience { get; set; }
    public List<EducationModel> Education { get; set; }
}

