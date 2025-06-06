using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using AutoGenerator.Config;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.Dto.Build.ResponseFilters
{
    public class QuestionResponseFilterBuildDto : ITBuildDto
    {
        /// <summary>
        /// QuestionId property for DTO.
        /// </summary>
        public String? QuestionId { get; set; }
        public string? Text { get; set; }
        /// <summary>
        /// ApplicationUserId property for DTO.
        /// </summary>
        public String? ApplicationUserId { get; set; }
        public ApplicationUserResponseFilterBuildDto? ApplicationUser { get; set; }

        [FilterLGEnabled]
        public string? Lg { get; set; }
    }
}