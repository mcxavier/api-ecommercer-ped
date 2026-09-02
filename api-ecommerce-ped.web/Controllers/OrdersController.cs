using api_ecommercer_ped.application.UseCases.CancelOrder;
using api_ecommercer_ped.application.UseCases.CreateOrder;
using api_ecommercer_ped.application.UseCases.CreateUser;
using api_ecommercer_ped.application.UseCases.GetOrder;
using api_ecommercer_ped.application.UseCases.ListOrders;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api_ecommercer_ped.webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : Controller
    {
        private readonly IMediator _mediator;

        public OrdersController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost]
        //[Authorize]
        public async Task<ActionResult<CreateOrderResponse>> CreateOrder([FromBody] CreateOrderRequest request,
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }


        [HttpGet]
        //[Authorize]
        public async Task<ActionResult<ListOrderResponse>> ListOrder(ListOrderRequest request,
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }


        [HttpGet("/{id}")]
        //[Authorize]
        public async Task<ActionResult<GetOrderResponse>> GetOrder(GetOrderRequest request,
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }


        [HttpPatch("{id}/cancel")]
        //[Authorize]
        public async Task<ActionResult<CancelOrderResponse>> CancelOrder(CancelOrderRequest request,
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

    }
}
