using AutoGenerator;
using AutoMapper;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using AutoGenerator.Services.Base;
using WasmAI.ASG.V1.DyModels.Dso.Requests;
using WasmAI.ASG.V1.DyModels.Dso.Responses;
using WasmAI.ASG.Models;
using WasmAI.ASG.V1.DyModels.Dto.Share.Requests;
using WasmAI.ASG.V1.DyModels.Dto.Share.Responses;
using WasmAI.ASG.V1.Repositories.Share;
using System.Linq.Expressions;
using WasmAI.ASG.V1.Repositories.Builder;
using AutoGenerator.Repositories.Base;
using AutoGenerator.Helper;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.Services.Services
{
    public class QuestionService : BaseBPRServiceLayer<QuestionRequestDso, QuestionResponseDso, QuestionRequestShareDto, QuestionResponseShareDto>, IUseQuestionService
    {
        private readonly IQuestionShareRepository _share;
        public QuestionService(IMapper mapper, ILoggerFactory logger, IQuestionShareRepository bpr) : base(mapper, logger, bpr)
        {
            _share = bpr;
        }


        //   Ã«Ê“ Ê ⁄œÌ·   «Ê  «÷«›… ‘—ÿ ⁄·Ï «·œ«·Â 

        public override Task<IEnumerable<QuestionResponseDso>> GetByName(string name)
        {
            return base.GetByName(name);
        }


        //  «÷«›…  —”«∆· «Œÿ«¡  ÃœÌœ… Œ«’… »«·ÿ»ﬁ… 

        public override Task<DataResult<IEnumerable<QuestionResponseDso>>> GetByNameDataResult(string name)
        {
            return base.GetByNameDataResult(name);
        }


    }
}