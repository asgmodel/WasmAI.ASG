using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using AutoGenerator.Config;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.Dto.Build.Responses
{
    public class UserScenarioResponseBuildDto : ITBuildDto
    {
        /// <summary>
        /// UserScenarioId property for DTO.
        /// </summary>
        public String? UserScenarioId { get; set; }
        /// <summary>
        /// ApplicationUserId property for DTO.
        /// </summary>
        public String? ApplicationUserId { get; set; }
        public ApplicationUserResponseBuildDto? ApplicationUser { get; set; }
        /// <summary>
        /// ScenarioId property for DTO.
        /// </summary>
        public String? ScenarioId { get; set; }
        public ScenarioResponseBuildDto? Scenario { get; set; }
    }
}