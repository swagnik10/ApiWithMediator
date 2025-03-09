using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediatorPatternApi.CommandandQuery
{
    public class GetUserRequest : IRequest<GetUserResponse>
    {
        [FromHeader]
        public int UserId { get; set; }

        /*public GetUserRequest(string Userid)
        {
            UserId = Userid;
        }*/
    }
}
