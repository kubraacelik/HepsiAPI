namespace HepsiApi.Application.Interfaces.AutoMapper
{
    // nesneler arasında dönüşüm (mapping) işlemleri yapmayı hedefliyor. 
    public interface ICustomMapper
    {
        // TSource türündeki bir nesneyi alıp TDestination türüne dönüştürür
        TDestination Map<TDestination, TSource>(TSource source, string? ignore = null);
        // TSource türünde bir listeyi TDestination türündeki bir listeye dönüştürür
        IList<TDestination> Map<TDestination, TSource>(IList<TSource> source, string? ignore = null);
        // object türündeki kaynağı TDestination türüne dönüştürür
        TDestination Map<TDestination>(object source, string? ignore = null);
        // object türündeki bir listeyi TDestination türündeki bir listeye dönüştürür
        IList<TDestination> Map<TDestination>(IList<object> source, string? ignore = null);
    }
}
