using ApplicationCore.Avelam.Interfaces;
using ApplicationCore.Avelam.Models;

namespace Infrastructure.Avelam.Repositories
{
    public class UserRepository : IUserRepository
    {

        public Task Create(User entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(long id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetById(long id)
        {
            throw new NotImplementedException();
        }

        public Task Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
