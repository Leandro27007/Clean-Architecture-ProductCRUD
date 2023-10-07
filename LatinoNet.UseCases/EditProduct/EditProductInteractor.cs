using LatinoNet.DTOs;
using LatinoNet.Entities.Interfaces;
using LatinoNet.Entities.POCOs;
using LatinoNet.UseCasesPorts;

namespace LatinoNet.UseCases.EditProduct
{
    public class EditProductInteractor : IEditProductInputPort
    {
        readonly IEditProductOutputPort OutputPort;
        readonly IProductRepository Repository;
        readonly IUnitOfWork UnitOfWork;

        public EditProductInteractor(IEditProductOutputPort outputPort, IProductRepository repository, IUnitOfWork unitOfWork)
        {
            OutputPort = outputPort;
            Repository = repository;
            UnitOfWork = unitOfWork;
        }

        public async Task Handle(EditProductDTO product)
        {
            Product EditProduct = new() 
            {
                Id = product.Id,
                Name = product.Name,
            };

            Repository.Edit(EditProduct);

            await UnitOfWork.SaveChanges();

            await OutputPort.Handle(new ProductDTO() { Id = EditProduct.Id, Name = EditProduct.Name });
        }
    }
}
