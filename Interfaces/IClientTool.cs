using GrpcToolkit.Proto;
using System.Threading.Tasks;

namespace GrpcToolkit.Interfaces
{
    public interface IClientTool
    {
        public bool IsSucceeded { get; }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T">Excepted response</typeparam>
        /// <param name="value">Value that comes from service</param>
        /// <param name="throwException">If have exception throws</param>
        /// <returns>Excepted response</returns>
        Task<T> Response<T>(ResponseResult value, bool throwException = true);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">Value that comes from service</param>
        /// <param name="throwException">If have exception throws</param>
        /// <returns>Completed Task</returns>
        Task UnitResponse(ResponseResult value, bool throwException = true);
    }
}
