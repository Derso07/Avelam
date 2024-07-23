using ApplicationCore.Avelam.Interfaces;
using ApplicationCore.Avelam.Models;

namespace Infrastructure.Avelam.Repositories
{
    public class OrderRepository : IOrderRepository
    {


        public Task Create(Order entity)
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

        public Task<List<Order>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetById(long id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
