using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using AutoGenerator.Config;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.Dto.Build.ResponseFilters
{
    public class UserTacticResponseFilterBuildDto : ITBuildDto
    {
        /// <summary>
        /// UserTacticId property for DTO.
        /// </summary>
        public String? UserTacticId { get; set; }
        /// <summary>
        /// ApplicationUserId property for DTO.
        /// </summary>
        public String? ApplicationUserId { get; set; }
        public ApplicationUserResponseFilterBuildDto? ApplicationUser { get; set; }
        /// <summary>
        /// TacticId property for DTO.
        /// </summary>
        public String? TacticId { get; set; }
        public TacticResponseFilterBuildDto? Tactic { get; set; }

        [FilterLGEnabled]
        public string? Lg { get; set; }
    }
}