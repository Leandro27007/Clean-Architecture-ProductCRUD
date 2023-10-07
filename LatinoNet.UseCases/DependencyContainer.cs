using LatinoNet.UseCases.CreateProduct;
using LatinoNet.UseCases.DeleteProduct;
using LatinoNet.UseCases.EditProduct;
using LatinoNet.UseCases.GetAllProducts;
using LatinoNet.UseCasesPorts;
using Microsoft.Extensions.DependencyInjection;

namespace LatinoNet.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCasesServices(this IServiceCollection service)
        {
            service.AddTransient<ICreateProductInputPort, CreateProductInteractor>();
            service.AddTransient<IGetAllProductInputPort, GetAllProductsInteractor>();
            service.AddTransient<IEditProductInputPort, EditProductInteractor>();
            service.AddTransient<IDeleteProductInputPort, DeleteProductInteractor>();

            return service;
        }
    }
}
