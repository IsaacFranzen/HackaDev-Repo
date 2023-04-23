namespace TECBank.Backend.Domains.DTO.Responses;

public class LoginResponseDto
{
    public ClienteResponseDto Cliente { get; set; } = null!;
    public string Token { get; set; } = null!;
}
