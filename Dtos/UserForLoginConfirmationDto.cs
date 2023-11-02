namespace DotNetAPI.Dtos;

public partial class UserForLoginConfirmationDto
{
    UserForLoginConfirmationDto()
    {
        if (PasswordHash == null)
        {
            PasswordHash = new byte[0];
        }
        if (PasswordSalt == null)
        {
            PasswordSalt = new byte[0];
        }
    }

    public byte[] PasswordHash { get; set; }

    public byte[] PasswordSalt { get; set; }
}