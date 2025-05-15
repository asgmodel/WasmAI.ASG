using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using AutoGenerator.Config;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.Dto.Build.ResponseFilters
{
    public class ScenarioTypeResponseFilterBuildDto : ITBuildDto
    {
        /// <summary>
        /// ScenarioTypeId property for DTO.
        /// </summary>
        public String? ScenarioTypeId { get; set; }
        /// <summary>
        /// TypeName property for DTO.
        /// </summary>
        public String? TypeName { get; set; }
        public ICollection<ScenarioResponseFilterBuildDto>? Scenarios { get; set; }

        [FilterLGEnabled]
        public string? Lg { get; set; }
    }
}