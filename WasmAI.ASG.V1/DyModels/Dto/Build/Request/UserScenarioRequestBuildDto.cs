using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using AutoGenerator.Config;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.Dto.Build.Requests
{
    public class UserScenarioRequestBuildDto : ITBuildDto
    {
        /// <summary>
        /// UserScenarioId property for DTO.
        /// </summary>
        public String? UserScenarioId { get; set; }
        /// <summary>
        /// ApplicationUserId property for DTO.
        /// </summary>
        public String? ApplicationUserId { get; set; }
        public ApplicationUserRequestBuildDto? ApplicationUser { get; set; }
        /// <summary>
        /// ScenarioId property for DTO.
        /// </summary>
        public String? ScenarioId { get; set; }
        public ScenarioRequestBuildDto? Scenario { get; set; }
    }
}