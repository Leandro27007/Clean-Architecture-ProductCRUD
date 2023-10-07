using LatinoNet.DTOs;
using LatinoNet.Presenters;
using LatinoNet.UseCasesPorts;
using Microsoft.AspNetCore.Mvc;

namespace LatinoNet.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class DeleteProductController
    {

        readonly IDeleteProductInputPort InputPort;
        readonly IDeleteProductOutputPort OutputPort;

        public DeleteProductController(IDeleteProductInputPort inputPort, IDeleteProductOutputPort outputPort)
        {
            InputPort = inputPort;
            OutputPort = outputPort;
        }


        [HttpDelete]
        public async Task<bool> DeleteProduct(DeleteProductDTO productDTO)
        {
            await InputPort.Handle(productDTO);

            return ((IPresenter<bool>)OutputPort).Content;

        }

    }
}
