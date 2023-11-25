using AutoMapper;
using Contracts;
using Entities.Exceptions.NotFound.Sales;
using Entities.Models.Sales;
using Service.Contracts.Sales;
using Shared.DataTransferObjects.Sales.PaymentMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Sales
{
    internal sealed class PaymentMethodService : IPaymentMethodService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public PaymentMethodService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        /* Crear */
        public async Task<PaymentMethodDto> CreatePaymentMethodAsync(PaymentMethodForCreationDto paymentMethod)
        {
            var paymentEntity = _mapper.Map<PaymentMethod>(paymentMethod);

            _repository.PaymentMethod.CreatePaymentMethod(paymentEntity);

            await _repository.SaveAsync();

            var paymentToReturn = _mapper.Map<PaymentMethodDto>(paymentEntity);

            return paymentToReturn;
        }

        /* Eliminar */
        public async Task DeletePaymentMethodAsync(Guid paymentMethodId, bool trackChanges)
        {
            var payment = await _repository.PaymentMethod.GetPaymentMethodAsync(paymentMethodId, trackChanges);

            if (payment is null)
                throw new PaymentMethodNotFoundException(paymentMethodId);

            _repository.PaymentMethod.DeletePaymentMethod(payment);

            await _repository.SaveAsync();
        }

        /* Listar */
        public async Task<IEnumerable<PaymentMethodDto>> GetAllPaymentMethodsAsync(bool trackChanges)
        {
            var payments = await _repository.PaymentMethod.GetAllPaymentMethodsAsync(trackChanges);

            var paymentsDto = _mapper.Map<IEnumerable<PaymentMethodDto>>(payments);

            return paymentsDto;
        }

        /* Un registro */
        public async Task<PaymentMethodDto> GetPaymentMethodAsync(Guid paymentMethodId, bool trackChanges)
        {
            var payment = await _repository.PaymentMethod.GetPaymentMethodAsync(paymentMethodId, trackChanges);

            if (payment is null)
                throw new PaymentMethodNotFoundException(paymentMethodId);

            var paymentDto = _mapper.Map<PaymentMethodDto>(payment);

            return paymentDto;
        }

        /* Actualizar */
        public async Task UpdatePaymentMethodAsync(Guid paymentMethodId, PaymentMethodForUpdateDto paymentMethodForUpdate, bool trackChanges)
        {
            var paymentEntity = await _repository.PaymentMethod.GetPaymentMethodAsync(paymentMethodId, trackChanges);

            if (paymentEntity is null)
                throw new PaymentMethodNotFoundException(paymentMethodId);

            _mapper.Map(paymentMethodForUpdate, paymentEntity);

            paymentEntity.setModificationDate();

            await _repository.SaveAsync();
        }
    }
}
