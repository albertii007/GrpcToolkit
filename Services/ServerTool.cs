using GrpcToolkit.Interfaces;
using GrpcToolkit.Proto;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace GrpcToolkit.Services
{
    internal sealed class ServerTool<TResponse> : IServerTool<TResponse> where TResponse : new()
    {
        private readonly ResponseResult ResponseMessage = new ResponseResult();

        private readonly TResponse _response = new TResponse();

        public async Task SetResult<TResult>(TResult result)
        {
            try
            {
                if (result is ValueType || result is string)
                    ResponseMessage.Result = await SerializeAsync(new { Value = result });
                else
                    ResponseMessage.Result = await SerializeAsync(result);

                ResponseMessage.StatusCode = 200;
                ResponseMessage.HasException = false;
            }
            catch { throw new Exception("Internal Server Error"); }
        }

        public Task SetUnitResult()
        {
            ResponseMessage.StatusCode = 200;
            ResponseMessage.HasException = false;

            return Task.CompletedTask;
        }

        public async Task<TResponse> RunAsync(Func<Task> func)
        {
            try { await func(); }

            catch (Exception ex)
            {
                ResponseMessage.StatusCode = 500;
                ResponseMessage.HasException = true;

                ResponseMessage.ExceptionMessage = await SerializeAsync(new ExceptionResponse
                {
                    Message = ex.Message ?? string.Empty,
                    Type = ex.GetType().Name
                });
            }

            return await SetResponse();
        }

        private Task<TResponse> SetResponse()
        {
            _response.GetType().GetProperty("Value").SetValue(_response, ResponseMessage);

            return Task.FromResult(_response);
        }

        private Task<string> SerializeAsync(object value)
        {
            var result = JsonConvert.SerializeObject(value);

            return Task.FromResult(result);
        }
    }
}
