﻿using HepsiApi.Application.Interfaces.Repositories;
using HepsiApi.Application.Interfaces.UnitOfWorks;
using HepsiApi.Persistence.Context;
using HepsiApi.Persistence.Repositories;
using HepsiApi.Persistence.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiApi.Persistence
{
    public static class Registration
    {
        // veritabanı ile iletişim kurabilmek için gerekli olan temel yapıyı kurar. 
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(opt => 
            opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            // okuma işlemleri için kullanılır.
            services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
            //  yazma işlemleri için kullanılır.
            services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
