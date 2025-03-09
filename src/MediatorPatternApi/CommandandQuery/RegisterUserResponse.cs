namespace MediatorPatternApi.CommandandQuery
{
    public class RegisterUserResponse
    {
        public required string UserId { get; set; } 
        public string? Name { get; set; } 
        public string? Email { get; set; }

        public string? Message { get; set; } = "User is Registered!!";
    }
}
