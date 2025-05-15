using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using AutoGenerator.Config;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.Dto.Build.ResponseFilters
{
    public class ScenarioResponseFilterBuildDto : ITBuildDto
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
        public ICollection<TechniqueResponseFilterBuildDto>? Techniques { get; set; }
        public ICollection<TacticResponseFilterBuildDto>? Tactics { get; set; }
        public ICollection<SoftwareResponseFilterBuildDto>? Softwares { get; set; }
        public ICollection<GroupResponseFilterBuildDto>? Groups { get; set; }
        /// <summary>
        /// ScenarioTypeId property for DTO.
        /// </summary>
        public String? ScenarioTypeId { get; set; }
        public ScenarioTypeResponseFilterBuildDto? ScenarioType { get; set; }
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

        [FilterLGEnabled]
        public string? Lg { get; set; }
    }
}