using LatinoNet.DTOs;
using LatinoNet.Entities.Interfaces;
using LatinoNet.UseCasesPorts;

namespace LatinoNet.UseCases.GetAllProducts
{
    public class GetAllProductsInteractor : IGetAllProductInputPort
    {
        readonly IProductRepository Repository;
        readonly IGetAllProductOutputPort OutputPort;

        public GetAllProductsInteractor(IProductRepository repository, IGetAllProductOutputPort outputPort)
        {
                Repository = repository;
                OutputPort = outputPort;
        }

        public Task Handle()
        {
            var Products = Repository.GetAll().Select(p => 
                new ProductDTO() 
                {
                    Id = p.Id,
                    Name = p.Name
                });

            OutputPort.Handle(Products);

            return Task.CompletedTask;
        }
    }
}
