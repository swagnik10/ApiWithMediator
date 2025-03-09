using MediatorPatternApi.CommandandQuery;
using MediatR;

namespace MediatorPatternApi.Handler 
{
    public class GetUserHandler : IRequestHandler<GetUserRequest, GetUserResponse>
    {
       /* public GetUserResponse Handle(GetUserRequest request)
        {
            // Simulating database/user lookup
            Console.WriteLine($"Handling request for UserId: {request.UserId}");

            // For demo purposes, return a static user
            return new GetUserResponse();
        }*/

        public async Task<GetUserResponse> Handle(GetUserRequest request, CancellationToken cancellationToken)
        {
            // Simulating database/user lookup
            Console.WriteLine($"Handling request for UserId: {request.UserId}");

            // For demo purposes, return a static user
            return await Task.FromResult(new GetUserResponse());
        }
    }
}
