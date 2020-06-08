using System.Linq;

namespace YOYO.Models
{

    public class MockProductRepository : IProductRepository
    {
        private static readonly Product[] DummyData = new Product[]
        {
new Product{Name="产品1",Cateory="分类1",Price=100},
new Product{Name="产品2",Cateory="分类2",Price=100},
new Product{Name="产品3",Cateory="分类3",Price=100},
new Product{Name="产品4",Cateory="分类4",Price=100},
        };

       public IQueryable<Product> Products =>  DummyData.AsQueryable();
    }
}