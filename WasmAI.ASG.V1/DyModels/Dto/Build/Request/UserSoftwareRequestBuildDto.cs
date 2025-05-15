using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using AutoGenerator.Config;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.Dto.Build.Requests
{
    public class UserSoftwareRequestBuildDto : ITBuildDto
    {
        /// <summary>
        /// UserSoftwareId property for DTO.
        /// </summary>
        public String? UserSoftwareId { get; set; }
        /// <summary>
        /// ApplicationUserId property for DTO.
        /// </summary>
        public String? ApplicationUserId { get; set; }
        public ApplicationUserRequestBuildDto? ApplicationUser { get; set; }
        /// <summary>
        /// SoftwareId property for DTO.
        /// </summary>
        public String? SoftwareId { get; set; }
        public SoftwareRequestBuildDto? Software { get; set; }
    }
}