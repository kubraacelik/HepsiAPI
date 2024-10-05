using HepsiApi.Application.Interfaces.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace HepsiApi.Mapper
{
    public static class Registration
    {
        //  Dependency Injection yapısını kullanarak ICustomMapper arayüzünü ve CustomMapper sınıfını servislere ekler
        public static void AddCustomMapper(this IServiceCollection services)
        {
                services.AddSingleton<ICustomMapper, AutoMapper.CustomMapper>();
        }
    }
}
