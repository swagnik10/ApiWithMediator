using MediatorPatternApi.CommandandQuery;

namespace MediatorPatternApi.Repository
{
    public interface IRepository
    {
        RegisterUserResponse RegisterUser(RegisterUserRequest request);
    }
}
