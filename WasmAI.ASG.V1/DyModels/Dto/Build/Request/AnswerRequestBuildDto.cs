using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using AutoGenerator.Config;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.Dto.Build.Requests
{
    public class AnswerRequestBuildDto : ITBuildDto
    {
        /// <summary>
        /// AnswerId property for DTO.
        /// </summary>
        public String? AnswerId { get; set; }
        /// <summary>
        /// Text property for DTO.
        /// </summary>
        public String? Text { get; set; }
        /// <summary>
        /// QuestionId property for DTO.
        /// </summary>
        public String? QuestionId { get; set; }
        public QuestionRequestBuildDto? Question { get; set; }
        /// <summary>
        /// ApplicationUserId property for DTO.
        /// </summary>
        public String? ApplicationUserId { get; set; }
        public ApplicationUserRequestBuildDto? ApplicationUser { get; set; }
    }
}