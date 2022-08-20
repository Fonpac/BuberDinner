namespace BuberDinner.Constracts.Authentication;

public record AuthenticationResponse(
    Guid Id,
    string FirstName,
    string Lastname,
    string Email,
    string Token
);