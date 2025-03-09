namespace MediatorPatternApi.Model
{
    public class User
    {
        public required string UserId { get; set; } 
        public string? Name { get; set; } 
        public string? Email { get; set; } 
    }
}
