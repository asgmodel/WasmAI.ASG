using AutoMapper;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using WasmAI.ASG.V1.Services.Services;
using Microsoft.AspNetCore.Mvc;
using WasmAI.ASG.V1.DyModels.VMs;
using System.Linq.Expressions;
using WasmAI.ASG.V1.DyModels.Dso.Requests;
using WasmAI.ASG.V1.DyModels.Dso.Responses;
using AutoGenerator.Helper.Translation;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.Controllers.Api
{
    //[ApiExplorerSettings(GroupName = "WasmAI.ASG.V1")]
    [Route("api/WasmAI.ASG.V1/Api/[controller]")]
    [ApiController]
    public class TacticController : BaseBPRControllerLayer<TacticRequestDso, TacticResponseDso, TacticCreateVM, TacticOutputVM, TacticUpdateVM, TacticInfoVM, TacticDeleteVM, TacticFilterVM>
    {
        private readonly IUseTacticService _service;
        public TacticController(IMapper mapper, ILoggerFactory logger, IUseTacticService bPR) : base(mapper, logger, bPR)
        {
            _service = bPR;
        }
    }
}