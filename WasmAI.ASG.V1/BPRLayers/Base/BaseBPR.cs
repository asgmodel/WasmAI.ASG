
using AutoGenerator;
using AutoGenerator.Controllers.Base;
using AutoGenerator.Layers.Base;
using AutoGenerator.Repositories.Base;
using AutoMapper;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace WasmAI.ASG.V1.BPR.Layers.Base
{
    public interface IBPRLayer<TRequest, TResponse> : IBPR<TRequest, TResponse>
        where TRequest : class
        where TResponse : class
    {
    
        
        Task<IEnumerable<TResponse>> GetByName(string name);

        Task<DataResult<IEnumerable<TResponse>>> GetByNameDataResult(string name);
    }

    public abstract class BaseBPRLayer<TRequest, TResponse, ERequest, EResponse, IT, IE> 
        : TBPR<TRequest, TResponse, ERequest, EResponse, IT, IE>, IBPRLayer<TRequest, TResponse>
        where TRequest : class
        where TResponse : class
        where ERequest : class
        where EResponse : class
        where IT : ITBase
        where IE : ITBase
    {
        protected new readonly IBPRLayer<ERequest, EResponse> _bpr;
        protected BaseBPRLayer(IMapper mapper, ILoggerFactory logger, IBPRLayer<ERequest, EResponse> bpr) : base(mapper, logger, bpr)
        {
            _bpr = bpr;
        }

        public virtual async Task<IEnumerable<TResponse>> GetByName(string name)
        {
            try
            {
                var  item=await _bpr.GetByName(name);
                return Map<EResponse, TResponse>(item);
            }
            catch
            {

                throw  ;
            }
        }

        public virtual async Task<DataResult<IEnumerable<TResponse>>> GetByNameDataResult(string name)
        {
            try
            {
                var item =await GetByName(name); 

                return DataResult<IEnumerable<TResponse>>.Ok(item);
            }
            catch(Exception ex)
            {

                return DataResult<IEnumerable<TResponse>>.Fail(ex.Message);
            }
        }

     
    }
}