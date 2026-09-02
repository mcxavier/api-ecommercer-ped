using api_ecommercer_ped.application.UseCases.CreateOrder;
using api_ecommercer_ped.domain.Entities;
using api_ecommercer_ped.domain.Interfaces;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace api_ecommercer_ped.application.UseCases.ListOrders
{
    public class ListOrderHandler : IRequestHandler<ListOrderRequest, ListOrderResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;


        public ListOrderHandler(IUnitOfWork unitOfWork, IOrderRepository orderRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _orderRepository = orderRepository;
            _mapper = mapper;
        }


        public async Task<ListOrderResponse> Handle(ListOrderRequest request, CancellationToken cancellationToken)
        {

            var orders = await _orderRepository.ListOrder(request.page, request.page, cancellationToken);
            var ret = new ListOrderResponse();
      
            foreach (var order in orders) 
              ret.Orders.Add(_mapper.Map<OrderDTO>(order));
            
            return ret;
        }
    }
}
