using System;
using System.Threading.Tasks;

namespace GrpcToolkit.Interfaces
{
    public interface IServerTool<TResponse> where TResponse : new()
    {
        Task SetResult<TResult>(TResult result);
        Task<TResponse> RunAsync(Func<Task> func);
        Task SetUnitResult();
    }
}
