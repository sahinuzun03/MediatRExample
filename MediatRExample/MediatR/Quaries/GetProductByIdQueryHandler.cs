using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRExample.MediatR.Quaries
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductByIdVM> //Ne alacak ve handler sonuç bize ne dönecek onu söyledik
    {
        public Task<GetProductByIdVM> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {

            var ViewModel =  new GetProductByIdVM()
            {
                Id = Guid.NewGuid(),
                Name = "Book"
            };

            return Task.FromResult(ViewModel);  
            //Get product from repository
        }
    }
}
