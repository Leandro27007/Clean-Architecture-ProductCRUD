using LatinoNet.DTOs;
using LatinoNet.Presenters;
using LatinoNet.UseCasesPorts;
using Microsoft.AspNetCore.Mvc;

namespace LatinoNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateProductController
    {

        readonly ICreateProductInputPort InputPort;
        readonly ICreateProductOutputPort OutputPort;

        public CreateProductController(ICreateProductInputPort inputPort, ICreateProductOutputPort outputPort)
        {
            OutputPort = outputPort;
            InputPort = inputPort;
        }


        [HttpPost]
        public async Task<ProductDTO> CreateProduct(CreateProductDTO product)
        {
            await InputPort.Handle(product);

            //TODO: Entender este cast
            return ((IPresenter<ProductDTO>)OutputPort).Content;
        }

    }


}
