using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using AutoGenerator.Config;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.Dto.Build.Requests
{
    public class ScenarioRequestBuildDto : ITBuildDto
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
        public ICollection<TechniqueRequestBuildDto>? Techniques { get; set; }
        public ICollection<TacticRequestBuildDto>? Tactics { get; set; }
        public ICollection<SoftwareRequestBuildDto>? Softwares { get; set; }
        public ICollection<GroupRequestBuildDto>? Groups { get; set; }
        /// <summary>
        /// ScenarioTypeId property for DTO.
        /// </summary>
        public String? ScenarioTypeId { get; set; }
        public ScenarioTypeRequestBuildDto? ScenarioType { get; set; }
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