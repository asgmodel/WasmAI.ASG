using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.VMs
{
    /// <summary>
    /// UserTactic  property for VM Output.
    /// </summary>
    public class UserTacticOutputVM : ITVM
    {
        ///
        public String? UserTacticId { get; set; }
        ///
        public String? ApplicationUserId { get; set; }
        public ApplicationUserOutputVM? ApplicationUser { get; set; }
        ///
        public String? TacticId { get; set; }
        public TacticOutputVM? Tactic { get; set; }
    }
}