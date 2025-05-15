using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.VMs
{
    /// <summary>
    /// UserTactic  property for VM Create.
    /// </summary>
    public class UserTacticCreateVM : ITVM
    {
        ///
        public String? UserTacticId { get; set; }
        ///
        public String? ApplicationUserId { get; set; }
        // public ApplicationUserCreateVM? ApplicationUser { get; set; }
        ///
        public String? TacticId { get; set; }
    // public TacticCreateVM? Tactic { get; set; }
    }
}