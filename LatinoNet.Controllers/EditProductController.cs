using LatinoNet.DTOs;
using LatinoNet.Presenters;
using LatinoNet.UseCasesPorts;
using Microsoft.AspNetCore.Mvc;

namespace LatinoNet.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EditProductController
    {
        readonly IEditProductInputPort InputPort;
        readonly IEditProductOutputPort OutputPort;
        public EditProductController(IEditProductInputPort inputPort, IEditProductOutputPort outputPort)
        {
            InputPort = inputPort;
            OutputPort = outputPort;
        }

        [HttpPut("EditarProducto")]
        public async Task<ProductDTO> EditProduct(EditProductDTO product)
        {
            await InputPort.Handle(product);

            return ((IPresenter<ProductDTO>)OutputPort).Content;
        }

    }
}
