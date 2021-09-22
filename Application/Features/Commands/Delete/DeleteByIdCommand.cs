using Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Commands.Delete
{
    public class DeleteByIdCommand : IRequest<Response<int>>
    {
        public int Id { get; set; }

        public class DeleteByIdCommandHandler : IRequestHandler<DeleteByIdCommand, Response<int>>
        {
             
            public DeleteByIdCommandHandler()
            {
                
            }
            public async Task<Response<int>> Handle(DeleteByIdCommand command, CancellationToken cancellationToken)
            {
                 
                return new Response<int>(0);
            }
        }
    }
}
