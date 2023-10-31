namespace DotNetAPI.Models;

public class UserJobInfo
{

    public UserJobInfo()
    {
        if (JobTitle == null) JobTitle = "";

        if (Department == null) Department = "";
    }

    public int UserId { get; set; }

    public string JobTitle { get; set; }

    public string Department { get; set; }
}