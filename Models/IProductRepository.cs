using System.Linq;

namespace YOYO.Models
{

    public interface IProductRepository
    {

        IQueryable<Product> Products { get; }
    }
}