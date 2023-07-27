using MongoDB.Driver;
using services.Entity;

namespace services.Data;

public interface ICatalogContext
{
    IMongoCollection<Product> Products {get;}
}
