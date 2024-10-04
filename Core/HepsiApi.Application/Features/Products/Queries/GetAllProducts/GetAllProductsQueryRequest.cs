using MediatR;

namespace HepsiApi.Application.Features.Products.Queries.GetAllProducts
{
    // CQRS deseninde query işlemi için kullanılan bir Request (istek) sınıfıdır.
    // Bu sınıf, ürünlerin listelenmesi amacıyla yapılan sorgu talebini temsil eder.
    public class GetAllProductsQueryRequest : IRequest<IList<GetAllProductsQueryResponse>>
    {
    }
}
