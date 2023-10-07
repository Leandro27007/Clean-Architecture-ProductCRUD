using LatinoNet.DTOs;
using LatinoNet.Entities.Interfaces;
using LatinoNet.Entities.POCOs;
using LatinoNet.UseCasesPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoNet.UseCases.DeleteProduct
{
    public class DeleteProductInteractor : IDeleteProductInputPort
    {

        readonly IDeleteProductOutputPort OutputPort;
        readonly IProductRepository Repository;
        readonly IUnitOfWork UnitOfWork;

        public DeleteProductInteractor(IDeleteProductOutputPort outputPort, IProductRepository repository, IUnitOfWork unitOfWork)
        {
            OutputPort = outputPort;
            Repository = repository;
            UnitOfWork = unitOfWork;
        }

        public async Task Handle(DeleteProductDTO product)
        {
            Repository.Delete(new Product() { Id = product.ProductId });
            await UnitOfWork.SaveChanges();

            await OutputPort.Handle(true);
        }
    }
}
