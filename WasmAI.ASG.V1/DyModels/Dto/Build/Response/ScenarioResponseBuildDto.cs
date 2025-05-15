using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using AutoGenerator.Config;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.Dto.Build.Responses
{
    public class ScenarioResponseBuildDto : ITBuildDto
    {
        /// <summary>
        /// ScenarioId property for DTO.
        /// </summary>
        public String? ScenarioId { get; set; }
        /// <summary>
        /// Title property for DTO.
        /// </summary>
        public String? Title { get; set; }
        /// <summary>
        /// Description property for DTO.
        /// </summary>
        public String? Description { get; set; }
        public ICollection<TechniqueResponseBuildDto>? Techniques { get; set; }
        public ICollection<TacticResponseBuildDto>? Tactics { get; set; }
        public ICollection<SoftwareResponseBuildDto>? Softwares { get; set; }
        public ICollection<GroupResponseBuildDto>? Groups { get; set; }
        /// <summary>
        /// ScenarioTypeId property for DTO.
        /// </summary>
        public String? ScenarioTypeId { get; set; }
        public ScenarioTypeResponseBuildDto? ScenarioType { get; set; }
        /// <summary>
        /// Status property for DTO.
        /// </summary>
        public String? Status { get; set; }
        /// <summary>
        /// HealthPercentage property for DTO.
        /// </summary>
        public Double HealthPercentage { get; set; }
        /// <summary>
        /// TechniquesCount property for DTO.
        /// </summary>
        public Int32 TechniquesCount { get; set; }
    }
}