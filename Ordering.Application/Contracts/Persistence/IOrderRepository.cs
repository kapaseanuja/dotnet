using Ordering.Domain.Common;

namespace Ordering.Application.Contracts.Persistence;

public interface IOrderRepository : IAsyncRepository<Order>
{
     Task<IEnumerable<Order>> GetOrdersByUserName(string userName);
}
