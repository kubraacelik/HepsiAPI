using HepsiApi.Application.DTOs;
using HepsiApi.Application.Interfaces.AutoMapper;
using HepsiApi.Application.Interfaces.UnitOfWorks;
using HepsiApi.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace HepsiApi.Application.Features.Products.Queries.GetAllProducts
{
    // CQRS deseninde query işlemini gerçekleştiren bir Query Handler'dır.
    // Bu sınıf, bir ürün listesi almak için gelen sorgu talebini işleyip, ürünlerle ilgili bir yanıt döner. 
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, IList<GetAllProductsQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly ICustomMapper customMapper;

        public GetAllProductsQueryHandler(IUnitOfWork unitOfWork, ICustomMapper customMapper)
        {
            this.unitOfWork = unitOfWork;
            this.customMapper = customMapper;
        }
        public async Task<IList<GetAllProductsQueryResponse>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var products = await unitOfWork.GetReadRepository<Product>().GetAllAsync(include: x => x.Include(b => b.Brand));

            var brand = customMapper.Map<BrandDto, Brand>(new Brand());  

            var customMap = customMapper.Map<GetAllProductsQueryResponse, Product>(products);

            foreach (var item in customMap)
                item.Price -= (item.Price * item.Discound / 100);

            return customMap;
        }
    }
}
