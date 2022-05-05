using MediatR;
using MediatRExample.MediatR.Commands;
using MediatRExample.MediatR.Quaries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace MediatRExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            _mediator = mediator;   
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute]Guid id)
        {
            var query = new GetProductByIdQuery() { Id = id }; //Yaratılan query ' i StatusOk ile Send edip kullanıcıya döndüm.
            return Ok(await _mediator.Send(query));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllProductQuery(); //Yaratılan query ' i StatusOk ile Send edip kullanıcıya döndüm.
            return Ok(await _mediator.Send(query));
        }


        [HttpPost]
        public async Task<IActionResult> Post(CreateProductCommand command)
        { 
            return Ok(await _mediator.Send(command)); //Bu direk CreateProductCommad içerisinde bulunan Handle'ı tetikleyecek.
        }
    }
}
