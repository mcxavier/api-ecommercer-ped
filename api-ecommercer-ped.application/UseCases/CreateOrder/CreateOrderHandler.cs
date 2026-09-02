using api_ecommercer_ped.application.UseCases.CancelOrder;
using api_ecommercer_ped.domain.Entities;
using api_ecommercer_ped.domain.Interfaces;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace api_ecommercer_ped.application.UseCases.CreateOrder
{
    public class CreateOrderHandler : IRequestHandler<CreateOrderRequest, CreateOrderResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;


        public CreateOrderHandler(IUnitOfWork unitOfWork, IOrderRepository orderRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _orderRepository = orderRepository;
            _mapper = mapper;
        }


        public async Task<CreateOrderResponse> Handle(CreateOrderRequest request, CancellationToken cancellationToken)
        {
            var orderEntity = _mapper.Map<OrderEntity>(request.order);
            var order = await _orderRepository.CreateOrder(orderEntity, cancellationToken);

            return _mapper.Map<CreateOrderResponse>(order);
        }
    }
}
