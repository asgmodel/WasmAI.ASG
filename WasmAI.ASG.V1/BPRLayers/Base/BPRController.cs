
using AutoGenerator;
using AutoGenerator.Controllers.Base;
using AutoGenerator.Repositories.Base;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WasmAI.ASG.V1.BPR.Layers.Base
{
    public abstract class BaseBPRControllerLayer<TRequest, TResponse, VMCreate, VMOutput, VMUpdate, VMInfo, VMDelete> 
        : BaseBPRController<TRequest, TResponse, VMCreate, VMOutput, VMUpdate, VMInfo, VMDelete>
        where TRequest : class
        where TResponse : class
        where VMCreate : class
        where VMOutput : class
        where VMUpdate : class
        where VMInfo : class
        where VMDelete : class
    {
        protected IBaseBPRServiceLayer<TRequest, TResponse> _bpr;
        protected BaseBPRControllerLayer(IMapper mapper, ILoggerFactory logger, IBaseBPRServiceLayer<TRequest, TResponse> bPR) 
            : base(mapper, logger, bPR)
        {
            _bpr = bPR;
        }
    }


     /////////// ControllerLayerWithFilter LG/////////////
    public abstract class BaseBPRControllerLayer<TRequest, TResponse, VMCreate, VMOutput, VMUpdate, VMInfo, VMDelete, VMFilter> 
        : BaseBPRController<TRequest, TResponse, VMCreate, VMOutput, VMUpdate, VMInfo, VMDelete, VMFilter>
        where TRequest : class
        where TResponse : class
        where VMCreate : class
        where VMOutput : class
        where VMUpdate : class
        where VMInfo : class
        where VMDelete : class
        where VMFilter : class
    {
        protected IBaseBPRServiceLayer<TRequest, TResponse> _bpr;
        protected BaseBPRControllerLayer(IMapper mapper, ILoggerFactory logger, IBaseBPRServiceLayer<TRequest, TResponse> bPR) 
            : base(mapper, logger, bPR)
        {
            _bpr = bPR;
        }


        // DataResult ⁄·Ï „” ÊÏ «·ﬂ‰ —Ê·   ⁄«„· ›ﬁÿ „⁄ 
        [HttpGet("GetByName")]
        [ProducesResponseType(401)]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(ProblemDetails), 404)]
        public virtual async  Task<ActionResult<IEnumerable<TResponse>>> GetByName(string name)
        {


            var  res=await _bpr.GetByNameDataResult(name); // DataResult ⁄·Ï „” ÊÏ «·ﬂ‰ —Ê·   ⁄«„· ›ﬁÿ „⁄ 

            if (res.Success)
                return Ok(res.Data);

            return BadRequest(res.Message);
        }
    }
}