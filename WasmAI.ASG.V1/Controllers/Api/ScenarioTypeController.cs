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
    public class ScenarioTypeController : BaseBPRControllerLayer<ScenarioTypeRequestDso, ScenarioTypeResponseDso, ScenarioTypeCreateVM, ScenarioTypeOutputVM, ScenarioTypeUpdateVM, ScenarioTypeInfoVM, ScenarioTypeDeleteVM, ScenarioTypeFilterVM>
    {
        private readonly IUseScenarioTypeService _service;
        public ScenarioTypeController(IMapper mapper, ILoggerFactory logger, IUseScenarioTypeService bPR) : base(mapper, logger, bPR)
        {
            _service = bPR;
        }
    }
}