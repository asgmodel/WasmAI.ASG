using AutoMapper;
using WasmAI.ASG.Data;
using WasmAI.ASG.Models;
using WasmAI.ASG.V1.Repositories.Base;
using AutoGenerator.Repositories.Builder;
using WasmAI.ASG.V1.DyModels.Dto.Build.Requests;
using WasmAI.ASG.V1.DyModels.Dto.Build.Responses;
using AutoGenerator;
using AutoGenerator.Repositories.Base;
using AutoGenerator;
using WasmAI.ASG.V1.Repositories.Builder;
using AutoGenerator.Repositories.Share;
using System.Linq.Expressions;
using AutoGenerator.Repositories.Base;
using AutoGenerator.Helper;
using WasmAI.ASG.V1.DyModels.Dto.Share.Requests;
using WasmAI.ASG.V1.DyModels.Dto.Share.Responses;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.Repositories.Share
{
    /// <summary>
    /// Technique class for ShareRepository.
    /// </summary>
    public class TechniqueShareRepository : BaseBPRShareLayer<TechniqueRequestShareDto, TechniqueResponseShareDto, TechniqueRequestBuildDto, TechniqueResponseBuildDto>, ITechniqueShareRepository
    {
        // Declare the builder repository.
        private readonly TechniqueBuilderRepository _builder;
        public TechniqueShareRepository(IMapper mapper, ILoggerFactory logger, TechniqueBuilderRepository bpr) : base(mapper, logger, bpr)
        {
            _builder = bpr;
        }
    }
}