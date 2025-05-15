using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using AutoGenerator.Config;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.Dto.Build.Requests
{
    public class GroupRequestBuildDto : ITBuildDto
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
        public ICollection<ScenarioRequestBuildDto>? Scenarios { get; set; }
        public ICollection<SoftwareRequestBuildDto>? Softwares { get; set; }
    }
}