using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using AutoGenerator.Config;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.Dto.Build.ResponseFilters
{
    public class TechniqueResponseFilterBuildDto : ITBuildDto
    {
        /// <summary>
        /// TechniqueId property for DTO.
        /// </summary>
        public String? TechniqueId { get; set; }
        /// <summary>
        /// Name property for DTO.
        /// </summary>
        public String? Name { get; set; }
        /// <summary>
        /// Description property for DTO.
        /// </summary>
        public String? Description { get; set; }
        /// <summary>
        /// Detection property for DTO.
        /// </summary>
        public String? Detection { get; set; }
        /// <summary>
        /// TacticId property for DTO.
        /// </summary>
        public String? TacticId { get; set; }
        public TacticResponseFilterBuildDto? Tactic { get; set; }
        public ICollection<ScenarioResponseFilterBuildDto>? Scenarios { get; set; }

        [FilterLGEnabled]
        public string? Lg { get; set; }
    }
}