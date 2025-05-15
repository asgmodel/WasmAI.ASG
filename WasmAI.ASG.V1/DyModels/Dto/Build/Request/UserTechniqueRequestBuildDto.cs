using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using AutoGenerator.Config;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.Dto.Build.Requests
{
    public class UserTechniqueRequestBuildDto : ITBuildDto
    {
        /// <summary>
        /// UserTechniqueId property for DTO.
        /// </summary>
        public String? UserTechniqueId { get; set; }
        /// <summary>
        /// ApplicationUserId property for DTO.
        /// </summary>
        public String? ApplicationUserId { get; set; }
        public ApplicationUserRequestBuildDto? ApplicationUser { get; set; }
        /// <summary>
        /// TechniqueId property for DTO.
        /// </summary>
        public String? TechniqueId { get; set; }
        public TechniqueRequestBuildDto? Technique { get; set; }
    }
}