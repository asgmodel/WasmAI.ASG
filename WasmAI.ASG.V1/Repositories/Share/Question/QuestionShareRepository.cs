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
    /// Question class for ShareRepository.
    /// </summary>
    public class QuestionShareRepository : BaseBPRShareLayer<QuestionRequestShareDto, QuestionResponseShareDto, QuestionRequestBuildDto, QuestionResponseBuildDto>, IQuestionShareRepository
    {
        // Declare the builder repository.
        private readonly QuestionBuilderRepository _builder;
        public QuestionShareRepository(IMapper mapper, ILoggerFactory logger, QuestionBuilderRepository bpr) : base(mapper, logger, bpr)
        {
            _builder = bpr;
        }

        public override Task<IEnumerable<QuestionResponseShareDto>> GetByName(string name)
        {
            return base.GetByName(name);
        }

        public override Task<DataResult<IEnumerable<QuestionResponseShareDto>>> GetByNameDataResult(string name)
        {

            return base.GetByNameDataResult(name);
        }
    }
}