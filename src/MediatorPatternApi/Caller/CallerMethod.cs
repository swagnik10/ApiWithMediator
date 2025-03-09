using MediatorPatternApi.CommandandQuery;
using MediatorPatternApi.Handler;
using MediatorPatternApi.Mediators;

namespace MediatorPatternApi.Caller
{
/*    public class CallerMethod
    {
        public GetUserResponse Calling(string Id)
        {
            // 1️⃣ Create the Mediator
            var mediator = new Mediator();

            // 2️⃣ Register the handler
            mediator.Register<GetUserRequest, GetUserResponse>(new GetUserHandler());

            // 3️⃣ Create a request
            var request = new GetUserRequest();


            // 4️⃣ Send the request via the mediator and get the response
            var response = mediator.Send<GetUserRequest, GetUserResponse>(request);

            // 5️⃣ Return the response
            GetUserResponse userResponse = new GetUserResponse
            {
                UserId = Id
            };

            return userResponse;
        }
    }*/
}
