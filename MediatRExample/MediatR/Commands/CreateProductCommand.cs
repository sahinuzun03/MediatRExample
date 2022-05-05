using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRExample.MediatR.Commands
{
    public class CreateProductCommand : IRequest<Guid>

    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Value { get; set; }

        public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
        {
            public Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
            {
                //Repositorden ekleme işlemleri gerçekleştirilmesi gerekiyor.

                return Task.FromResult(Guid.NewGuid()); //Her yeni guild gönderildiğinde bu dönecek.
            }
        }
    }
}
