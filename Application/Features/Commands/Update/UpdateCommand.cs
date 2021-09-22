using Application.Wrappers;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Commands.Update
{
    public class UpdateCommand : IRequest<Response<int>>
    {
        public int Id { get; set; }

        public class UpdateCommandHandler : IRequestHandler<UpdateCommand, Response<int>>
        {
            
            public UpdateCommandHandler( )
            {
                 
            }
            public async Task<Response<int>> Handle(UpdateCommand command, CancellationToken cancellationToken)
            {
                 
                    return new Response<int>(0);
                }
            }
        }
    }

