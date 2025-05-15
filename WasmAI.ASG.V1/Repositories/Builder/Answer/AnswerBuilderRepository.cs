using AutoMapper;
using WasmAI.ASG.Data;
using WasmAI.ASG.Models;
using WasmAI.ASG.V1.Repositories.Base;
using AutoGenerator.Repositories.Builder;
using WasmAI.ASG.V1.DyModels.Dto.Build.Requests;
using WasmAI.ASG.V1.DyModels.Dto.Build.Responses;
using AutoGenerator;
using AutoGenerator.Repositories.Base;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.Repositories.Builder
{
    /// <summary>
    /// Answer class property for BuilderRepository.
    /// </summary>
     //
    public class AnswerBuilderRepository : BaseBuilderRepository<Answer, AnswerRequestBuildDto, AnswerResponseBuildDto>, IAnswerBuilderRepository<AnswerRequestBuildDto, AnswerResponseBuildDto>, ITBuilder
    {
        /// <summary>
        /// Constructor for AnswerBuilderRepository.
        /// </summary>
        public AnswerBuilderRepository(DataContext dbContext, IMapper mapper, ILoggerFactory logger) : base(dbContext, mapper, logger) // Initialize  constructor.
        {
        // Initialize necessary fields or call base constructor.
        ///
        /// 
         
        /// 
        }
    //
    // Add additional methods or properties as needed.
    }
}