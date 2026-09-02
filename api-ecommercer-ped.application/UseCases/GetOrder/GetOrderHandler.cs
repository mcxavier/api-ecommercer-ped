using api_ecommercer_ped.application.UseCases.CreateOrder;
using api_ecommercer_ped.domain.Entities;
using api_ecommercer_ped.domain.Interfaces;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace api_ecommercer_ped.application.UseCases.GetOrder
{
    public class GetOrderHandler : IRequestHandler<GetOrderRequest, GetOrderResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;


        public GetOrderHandler(IUnitOfWork unitOfWork, IOrderRepository orderRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _orderRepository = orderRepository;
            _mapper = mapper;
        }


        public async Task<GetOrderResponse> Handle(GetOrderRequest request, CancellationToken cancellationToken)
        {
            var order = await _orderRepository.GetOrder(request.id, cancellationToken);
            return _mapper.Map<GetOrderResponse>(order);
        }
    }
}
