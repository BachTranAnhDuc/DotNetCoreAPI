namespace DotNetAPI.Dtos;

public class UserForLoginDto
{
    public UserForLoginDto()
    {
        if (Email == null)
        {
            Email = "";
        }
        if (Password == null)
        {
            Password = "";
        }
    }
    public string Email { get; set; }
    public string Password { get; set; }
}