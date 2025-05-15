using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.VMs
{
    /// <summary>
    /// UserTechnique  property for VM Create.
    /// </summary>
    public class UserTechniqueCreateVM : ITVM
    {
        ///
        public String? UserTechniqueId { get; set; }
        ///
        public String? ApplicationUserId { get; set; }
        // public ApplicationUserCreateVM? ApplicationUser { get; set; }
        ///
        public String? TechniqueId { get; set; }
    // public TechniqueCreateVM? Technique { get; set; }
    }
}