using GrpcToolkit.Interfaces;
using GrpcToolkit.Proto;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace GrpcToolkit.Services
{
    internal sealed class ClientTool : IClientTool
    {
        public bool IsSucceeded { get; private set; }

        public async Task<TResult> Response<TResult>(ResponseResult responseMessage, bool throwException = true)
        {
            IsSucceeded = !responseMessage.HasException;

            await HandleException(responseMessage.ExceptionMessage);

            return await GetResult<TResult>(responseMessage.Result);
        }

        public async Task UnitResponse(ResponseResult responseMessage, bool throwException = true)
        {
            IsSucceeded = !responseMessage.HasException;

            await HandleException(responseMessage.ExceptionMessage);
        }
        public async Task<TResult> GetResult<TResult>(string result)
        {
            try { return await DeserializeAsync<TResult>(result); }
            catch { throw new Exception("GRPC response object not match"); }
        }

        private async Task HandleException(string exceptionMessage)
        {
            if (IsSucceeded) return;

            ExceptionResponse exceptionResponse = await DeserializeAsync<ExceptionResponse>(exceptionMessage);

            throw new Exception(exceptionResponse.Message);
        }

        private Task<TResult> DeserializeAsync<TResult>(string value)
        {
            if (typeof(TResult).IsValueType || typeof(TResult) == typeof(string))
            {
                var result = JsonConvert.DeserializeObject<JObject>(value);

                TypeConverter converter = TypeDescriptor.GetConverter(typeof(TResult));

                return Task.FromResult((TResult)converter.ConvertFromString(result["Value"].Value<string>()));
            }
            else
            {
                var result = JsonConvert.DeserializeObject<TResult>(value);

                return Task.FromResult(result);
            }
        }
    }
}
