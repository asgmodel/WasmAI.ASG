using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using AutoGenerator.Config;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.Dto.Build.Requests
{
    public class UserTacticRequestBuildDto : ITBuildDto
    {
        /// <summary>
        /// UserTacticId property for DTO.
        /// </summary>
        public String? UserTacticId { get; set; }
        /// <summary>
        /// ApplicationUserId property for DTO.
        /// </summary>
        public String? ApplicationUserId { get; set; }
        public ApplicationUserRequestBuildDto? ApplicationUser { get; set; }
        /// <summary>
        /// TacticId property for DTO.
        /// </summary>
        public String? TacticId { get; set; }
        public TacticRequestBuildDto? Tactic { get; set; }
    }
}