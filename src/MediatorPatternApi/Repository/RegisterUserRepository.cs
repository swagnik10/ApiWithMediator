using MediatorPatternApi.CommandandQuery;
using MediatorPatternApi.Model;
using Newtonsoft.Json;

namespace MediatorPatternApi.Repository
{
    public class RegisterUserRepository : IRepository
    {
        public RegisterUserResponse RegisterUser(RegisterUserRequest request)
        {
            User user = new User
            {
                Name = request.UserName,
                Email =  request.Mail,
                UserId = new Random().Next(100, 10000).ToString()
            };

            // Define the file path
            string filePath = "G:\\DotNetProject\\ApiWithMediator\\src\\MediatorPatternApi\\Data\\UserDetails.json";

            string existingJson = File.ReadAllText(filePath);

            List<User> userList = JsonConvert.DeserializeObject<List<User>>(existingJson) ?? new List<User>();

            userList.Add(user);

            // Write JSON to a file
            File.WriteAllText(filePath, JsonConvert.SerializeObject(userList, Formatting.Indented));

            RegisterUserResponse response = new RegisterUserResponse
            {
                Name = user.Name,
                Email = user.Email,
                UserId = user.UserId
            };

            return response;
        }
    }
}
