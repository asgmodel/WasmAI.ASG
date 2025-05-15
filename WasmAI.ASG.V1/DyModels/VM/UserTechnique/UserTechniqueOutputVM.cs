using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.VMs
{
    /// <summary>
    /// UserTechnique  property for VM Output.
    /// </summary>
    public class UserTechniqueOutputVM : ITVM
    {
        ///
        public String? UserTechniqueId { get; set; }
        ///
        public String? ApplicationUserId { get; set; }
        public ApplicationUserOutputVM? ApplicationUser { get; set; }
        ///
        public String? TechniqueId { get; set; }
        public TechniqueOutputVM? Technique { get; set; }
    }
}