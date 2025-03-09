using MediatR;

namespace MediatorPatternApi.CommandandQuery
{
    public class RegisterUserRequest : IRequest<RegisterUserResponse>
    {
        public string? UserName { get; set; }
        public string? Mail { get; set; }
        
    }
}
