using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace MediatRExample.MediatR.Quaries
{
    public class GetProductByIdQuery : IRequest<GetProductByIdVM> //Query çağırıldığı zaman response olarak ne döneceğiz.
    {
        public Guid Id { get; set; }
    }
}
