using api_ecommercer_ped.application.UseCases.CreateOrder;
using api_ecommercer_ped.domain.Entities;
using api_ecommercer_ped.domain.Interfaces;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace api_ecommercer_ped.application.UseCases.CancelOrder
{
    public class CancelOrderHandler : IRequestHandler<CancelOrderRequest, CancelOrderResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IOrderRepository _userRepository;
        private readonly IMapper _mapper;


        public CancelOrderHandler(IUnitOfWork unitOfWork, IOrderRepository userRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
            _mapper = mapper;
        }


        public async Task<CancelOrderResponse> Handle(CancelOrderRequest request, CancellationToken cancellationToken)
        {
            var order = await _userRepository.CancelOrder(request.Id, cancellationToken);
            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<CancelOrderResponse>(order);
        }
    }
}
