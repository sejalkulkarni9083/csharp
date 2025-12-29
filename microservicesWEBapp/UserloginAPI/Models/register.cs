namespace UserloginAPI.models;


public class RegisterRequest
{
    public string Username { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string contactNumber { get; set; } = string.Empty;

    public string password { get; set; } = string.Empty;

    public string confirmPassword { get; set; } = string.Empty;
}
