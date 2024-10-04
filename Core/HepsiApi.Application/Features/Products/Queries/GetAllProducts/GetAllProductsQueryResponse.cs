namespace HepsiApi.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductsQueryResponse
    {
        // her bir ürün için hangi bilgilerin kullanıcıya döndürüleceğini belirtir.
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Discound { get; set; }
    }
}
