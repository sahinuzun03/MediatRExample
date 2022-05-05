using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRExample.MediatR.Quaries
{
    public class GetAllProductQuery : IRequest<List<GetProductByIdVM>>
    {
        public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetProductByIdVM>>
        {
            public Task<List<GetProductByIdVM>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
            {
                var model = new GetProductByIdVM()
                {
                    Id = Guid.NewGuid(),
                    Name = "Monitör"
                };

                var model2 = new GetProductByIdVM()
                {
                    Id = Guid.NewGuid(),
                    Name = "Klavye"
                };

                return Task.FromResult(new List<GetProductByIdVM>(){ model,model2 });
            }
        }
    }
}
