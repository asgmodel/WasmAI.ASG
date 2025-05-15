using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using AutoGenerator.Config;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.Dto.Build.Responses
{
    public class SoftwareResponseBuildDto : ITBuildDto
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
        public GroupResponseBuildDto? Group { get; set; }
        public ICollection<ScenarioResponseBuildDto>? Scenarios { get; set; }
        public ICollection<TacticResponseBuildDto>? Tactics { get; set; }
    }
}