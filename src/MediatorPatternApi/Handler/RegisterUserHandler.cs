using MediatorPatternApi.CommandandQuery;
using MediatorPatternApi.Repository;
using MediatR;

namespace MediatorPatternApi.Handler 
{
    public class RegisterUserHandler : IRequestHandler<RegisterUserRequest, RegisterUserResponse>
    {
        /* public GetUserResponse Handle(GetUserRequest request)
         {
             // Simulating database/user lookup
             Console.WriteLine($"Handling request for UserId: {request.UserId}");

             // For demo purposes, return a static user
             return new GetUserResponse();
         }*/
        private readonly IRepository _repo;
        public RegisterUserHandler(IRepository repo) 
        {
            _repo = repo;
        }

        public async Task<RegisterUserResponse> Handle(RegisterUserRequest request, CancellationToken cancellationToken)
        {
            // Simulating database/user lookup
            Console.WriteLine($"Handling request for Name: {request.UserName}");

            RegisterUserResponse response =  _repo.RegisterUser(request);

            // For demo purposes, return a static user
            return await Task.FromResult(response);
        }
    }
}
