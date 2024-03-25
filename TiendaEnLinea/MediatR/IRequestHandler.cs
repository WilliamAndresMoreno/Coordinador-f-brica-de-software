using System;
using System.Threading.Tasks;

namespace MediatR
{
    public interface IRequestHandler<TRequest, TResponse>
    {
        Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
    }
}
