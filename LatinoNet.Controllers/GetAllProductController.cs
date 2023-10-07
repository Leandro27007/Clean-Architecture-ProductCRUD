using LatinoNet.DTOs;
using LatinoNet.Presenters;
using LatinoNet.UseCasesPorts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoNet.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class GetAllProductController
    {

        readonly IGetAllProductInputPort InputPort;
        readonly IGetAllProductOutputPort OutputPort;
        public GetAllProductController(IGetAllProductInputPort inputPort, IGetAllProductOutputPort outputPort)
        {
            InputPort = inputPort; 
            OutputPort = outputPort;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductDTO>> GetAllProducts()
        {
            await InputPort.Handle();
            
            return ((IPresenter<IEnumerable<ProductDTO>>)OutputPort).Content;

        }

    }
}
