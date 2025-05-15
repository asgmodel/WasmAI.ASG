using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using AutoGenerator.Config;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.Dto.Build.ResponseFilters
{
    public class SoftwareResponseFilterBuildDto : ITBuildDto
    {
        /// <summary>
        /// SoftwareId property for DTO.
        /// </summary>
        public String? SoftwareId { get; set; }
        /// <summary>
        /// Name property for DTO.
        /// </summary>
        public String? Name { get; set; }
        /// <summary>
        /// Description property for DTO.
        /// </summary>
        public String? Description { get; set; }
        /// <summary>
        /// SoftwareType property for DTO.
        /// </summary>
        public String? SoftwareType { get; set; }
        /// <summary>
        /// GroupId property for DTO.
        /// </summary>
        public String? GroupId { get; set; }
        public GroupResponseFilterBuildDto? Group { get; set; }
        public ICollection<ScenarioResponseFilterBuildDto>? Scenarios { get; set; }
        public ICollection<TacticResponseFilterBuildDto>? Tactics { get; set; }

        [FilterLGEnabled]
        public string? Lg { get; set; }
    }
}