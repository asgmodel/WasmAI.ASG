using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using AutoGenerator.Config;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.Dto.Build.Responses
{
    public class TacticResponseBuildDto : ITBuildDto
    {
        /// <summary>
        /// TacticId property for DTO.
        /// </summary>
        public String? TacticId { get; set; }
        /// <summary>
        /// Name property for DTO.
        /// </summary>
        public String? Name { get; set; }
        /// <summary>
        /// Description property for DTO.
        /// </summary>
        public String? Description { get; set; }
        /// <summary>
        /// ShortName property for DTO.
        /// </summary>
        public String? ShortName { get; set; }
        public ICollection<ScenarioResponseBuildDto>? Scenarios { get; set; }
        public ICollection<TechniqueResponseBuildDto>? Techniques { get; set; }
    }
}