using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Queries.All
{
    public class GetAllQuery : IRequest<IEnumerable<AllViewModel>>
    {
       
    }
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllQuery, IEnumerable<AllViewModel>>
    {
        
        public GetAllProductsQueryHandler( )
        {
          
        }

        public async Task<IEnumerable<AllViewModel>> Handle(GetAllQuery request, CancellationToken cancellationToken)
        {
            return null;
        }
    }
}
