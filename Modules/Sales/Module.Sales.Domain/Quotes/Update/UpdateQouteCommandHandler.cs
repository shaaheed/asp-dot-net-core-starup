﻿using Msi.Mediator.Abstractions;
using Module.Sales.Entities;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Msi.Data.Abstractions;
using Msi.Core;

namespace Module.Sales.Domain.Qoutes
{
    public class UpdateQouteCommandHandler : ICommandHandler<UpdateQouteCommand, long>
    {

        private readonly IUnitOfWork _unitOfWork;

        public UpdateQouteCommandHandler(
            IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<long> Handle(UpdateQouteCommand request, CancellationToken cancellationToken)
        {

            var qouteRepo = _unitOfWork.GetRepository<Quote>();
            var qoute = await qouteRepo.FirstOrDefaultAsync(x => x.Id == request.Id);

            if (qoute == null)
                throw new NotFoundException("Qoute not found");

            qoute.CustomerId = request.CustomerId;

            var qouteLineItemsRepo = _unitOfWork.GetRepository<QuoteLineItem>();
            var qouteLineItemsToBeRemoved = qouteLineItemsRepo.Where(x => x.QuoteId == request.Id);
            var lineItemsToBeRemoved = qouteLineItemsToBeRemoved.Select(x => x.LineItem);

            qouteLineItemsRepo.RemoveRange(qouteLineItemsToBeRemoved);
            var lineItemRepo = _unitOfWork.GetRepository<LineItem>();
            lineItemRepo.RemoveRange(lineItemsToBeRemoved);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            var newLineItems = request.Items.Select(x => new LineItem
            {
                Name = x.Name,
                Description = x.Description,
                ProductId = x.ProductId,
                Quantity = x.Quantity,
                Subtotal = x.Subtotal,
                Total = x.Quantity * x.UnitPrice,
                UnitPrice = x.UnitPrice,
                Note = x.Note
            });

            var newQouteLineItems = newLineItems.Select(x => new QuoteLineItem
            {
                Quote = qoute,
                LineItem = x
            });

            qoute.QuoteLineItems = newQouteLineItems.ToList();
            //qoute.Calculate();

            var result = await _unitOfWork.SaveChangesAsync(cancellationToken);

            return result;
        }
    }
}
