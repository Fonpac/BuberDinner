namespace BuberDinner.Constracts.Authentication;

public record LoginRequest(
    string Email,
    string Password
);