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
        public PaymentMethodDto CreatePaymentMethod(PaymentMethodForCreationDto paymentMethod)
        {
            var paymentEntity = _mapper.Map<PaymentMethod>(paymentMethod);

            _repository.PaymentMethod.CreatePaymentMethod(paymentEntity);

            _repository.Save();

            var paymentToReturn = _mapper.Map<PaymentMethodDto>(paymentEntity);

            return paymentToReturn;
        }

        /* Eliminar */
        public void DeletePaymentMethod(Guid paymentMethodId, bool trackChanges)
        {
            var payment = _repository.PaymentMethod.GetPaymentMethod(paymentMethodId, trackChanges);

            if (payment is null)
                throw new PaymentMethodNotFoundException(paymentMethodId);

            _repository.PaymentMethod.DeletePaymentMethod(payment);

            _repository.Save();
        }

        /* Listar */
        public IEnumerable<PaymentMethodDto> GetAllPaymentMethods(bool trackChanges)
        {
            var payments = _repository.PaymentMethod.GetAllPaymentMethods(trackChanges);

            var paymentsDto = _mapper.Map<IEnumerable<PaymentMethodDto>>(payments);

            return paymentsDto;
        }

        /* Un registro */
        public PaymentMethodDto GetPaymentMethod(Guid paymentMethodId, bool trackChanges)
        {
            var payment = _repository.PaymentMethod.GetPaymentMethod(paymentMethodId, trackChanges);

            if (payment is null)
                throw new PaymentMethodNotFoundException(paymentMethodId);

            var paymentDto = _mapper.Map<PaymentMethodDto>(payment);

            return paymentDto;
        }

        /* Actualizar */
        public void UpdatePaymentMethod(Guid paymentMethodId, PaymentMethodForUpdateDto paymentMethodForUpdate, bool trackChanges)
        {
            var paymentEntity = _repository.PaymentMethod.GetPaymentMethod(paymentMethodId, trackChanges);

            if (paymentEntity is null)
                throw new PaymentMethodNotFoundException(paymentMethodId);

            _mapper.Map(paymentMethodForUpdate, paymentEntity);

            paymentEntity.setModificationDate();

            _repository.Save();
        }
    }
}
