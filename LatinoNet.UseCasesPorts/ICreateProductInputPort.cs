using LatinoNet.DTOs;

namespace LatinoNet.UseCasesPorts
{
    public interface ICreateProductInputPort
    {
        Task Handle(CreateProductDTO product);
    }
}