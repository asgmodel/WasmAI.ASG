using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using AutoGenerator.Config;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.Dto.Build.ResponseFilters
{
    public class UserScenarioResponseFilterBuildDto : ITBuildDto
    {
        /// <summary>
        /// UserScenarioId property for DTO.
        /// </summary>
        public String? UserScenarioId { get; set; }
        /// <summary>
        /// ApplicationUserId property for DTO.
        /// </summary>
        public String? ApplicationUserId { get; set; }
        public ApplicationUserResponseFilterBuildDto? ApplicationUser { get; set; }
        /// <summary>
        /// ScenarioId property for DTO.
        /// </summary>
        public String? ScenarioId { get; set; }
        public ScenarioResponseFilterBuildDto? Scenario { get; set; }

        [FilterLGEnabled]
        public string? Lg { get; set; }
    }
}