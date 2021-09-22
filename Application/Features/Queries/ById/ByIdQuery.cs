using Application.Wrappers;
using Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Queries.ById
{
    public class ByIdQuery : IRequest<Response<Example>>
    {
        public int Id { get; set; }
        public class GetProductByIdQueryHandler : IRequestHandler<ByIdQuery, Response<Example>>
        {
            
            public GetProductByIdQueryHandler( )
            {
                 
            }
            public async Task<Response<Example>> Handle(ByIdQuery query, CancellationToken cancellationToken)
            {
               
                return new Response<Example>();
            }
        }
    }
}