using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using AutoGenerator.Config;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.Dto.Build.Responses
{
    public class UserTacticResponseBuildDto : ITBuildDto
    {
        /// <summary>
        /// UserTacticId property for DTO.
        /// </summary>
        public String? UserTacticId { get; set; }
        /// <summary>
        /// ApplicationUserId property for DTO.
        /// </summary>
        public String? ApplicationUserId { get; set; }
        public ApplicationUserResponseBuildDto? ApplicationUser { get; set; }
        /// <summary>
        /// TacticId property for DTO.
        /// </summary>
        public String? TacticId { get; set; }
        public TacticResponseBuildDto? Tactic { get; set; }
    }
}