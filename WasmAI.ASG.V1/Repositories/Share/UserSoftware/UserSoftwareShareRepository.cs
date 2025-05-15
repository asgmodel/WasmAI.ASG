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
    /// UserSoftware class for ShareRepository.
    /// </summary>
    public class UserSoftwareShareRepository : BaseBPRShareLayer<UserSoftwareRequestShareDto, UserSoftwareResponseShareDto, UserSoftwareRequestBuildDto, UserSoftwareResponseBuildDto>, IUserSoftwareShareRepository
    {
        // Declare the builder repository.
        private readonly UserSoftwareBuilderRepository _builder;
        public UserSoftwareShareRepository(IMapper mapper, ILoggerFactory logger, UserSoftwareBuilderRepository bpr) : base(mapper, logger, bpr)
        {
            _builder = bpr;
        }
    }
}