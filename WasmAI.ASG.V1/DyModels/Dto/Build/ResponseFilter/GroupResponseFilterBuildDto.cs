using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using AutoGenerator.Config;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.Dto.Build.ResponseFilters
{
    public class GroupResponseFilterBuildDto : ITBuildDto
    {
        /// <summary>
        /// GroupId property for DTO.
        /// </summary>
        public String? GroupId { get; set; }
        /// <summary>
        /// Name property for DTO.
        /// </summary>
        public String? Name { get; set; }
        /// <summary>
        /// Description property for DTO.
        /// </summary>
        public String? Description { get; set; }
        public ICollection<ScenarioResponseFilterBuildDto>? Scenarios { get; set; }
        public ICollection<SoftwareResponseFilterBuildDto>? Softwares { get; set; }

        [FilterLGEnabled]
        public string? Lg { get; set; }
    }
}