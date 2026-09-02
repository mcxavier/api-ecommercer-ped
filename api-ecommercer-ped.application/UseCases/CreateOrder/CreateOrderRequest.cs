using api_ecommercer_ped.domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace api_ecommercer_ped.application.UseCases.CreateOrder
{
    public sealed record CreateOrderRequest(OrderDTO order) :
        IRequest<CreateOrderResponse>;


}
