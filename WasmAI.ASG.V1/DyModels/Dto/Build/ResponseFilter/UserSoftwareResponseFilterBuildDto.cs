using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using AutoGenerator.Config;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.Dto.Build.ResponseFilters
{
    public class UserSoftwareResponseFilterBuildDto : ITBuildDto
    {
        /// <summary>
        /// UserSoftwareId property for DTO.
        /// </summary>
        public String? UserSoftwareId { get; set; }
        /// <summary>
        /// ApplicationUserId property for DTO.
        /// </summary>
        public String? ApplicationUserId { get; set; }
        public ApplicationUserResponseFilterBuildDto? ApplicationUser { get; set; }
        /// <summary>
        /// SoftwareId property for DTO.
        /// </summary>
        public String? SoftwareId { get; set; }
        public SoftwareResponseFilterBuildDto? Software { get; set; }

        [FilterLGEnabled]
        public string? Lg { get; set; }
    }
}