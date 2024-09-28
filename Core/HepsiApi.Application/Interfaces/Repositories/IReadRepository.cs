using HepsiApi.Domain.Common;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HepsiApi.Application.Interfaces.Repositories
{
    // Generic bir yapı kullanarak veritabanı üzerinde okuma işlemlerini yönetir.
    public interface IReadRepository<T> where T : class, IEntityBase, new()
    {
        // Tüm verileri getirir.
        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            bool enableTracking = false);

        // Verileri sayfa sayfa getirmeye yarar.
        Task<IList<T>> GetAllByPagingAsync(Expression<Func<T, bool>>? predicate = null,
          Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
          Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
          bool enableTracking = false, int currentPage = 1, int pageSize = 3);

        // Belirli bir koşula göre verileri getirir.
        Task<T> GetAsync(Expression<Func<T, bool>> predicate,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, 
            bool enableTracking = false);

        // Bir koşula göre sorgulama yapar.
        IQueryable<T> Find(Expression<Func<T, bool>> predicate, bool enableTracking = false);

        // Veritabanındaki kayıtların sayısını getirir.
        Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null);
    }
}
