using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using AutoGenerator.Config;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.Dto.Build.Responses
{
    public class ScenarioTypeResponseBuildDto : ITBuildDto
    {
        /// <summary>
        /// ScenarioTypeId property for DTO.
        /// </summary>
        public String? ScenarioTypeId { get; set; }
        /// <summary>
        /// TypeName property for DTO.
        /// </summary>
        public String? TypeName { get; set; }
        public ICollection<ScenarioResponseBuildDto>? Scenarios { get; set; }
    }
}