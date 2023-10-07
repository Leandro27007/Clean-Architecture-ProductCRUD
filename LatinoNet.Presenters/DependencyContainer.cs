using LatinoNet.UseCasesPorts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoNet.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresentersServices(this IServiceCollection service)
        {

            service.AddScoped<ICreateProductOutputPort, CreateProductPresenter>();
            service.AddScoped<IGetAllProductOutputPort, GetAllProductsPresenter>();
            service.AddScoped<IEditProductOutputPort, EditProductPresenter>();
            service.AddScoped<IDeleteProductOutputPort, DeleteProductPresenter>();

            return service;
        }

    }
}
