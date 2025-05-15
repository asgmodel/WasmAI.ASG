using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.VMs
{
    /// <summary>
    /// UserSoftware  property for VM Create.
    /// </summary>
    public class UserSoftwareCreateVM : ITVM
    {
        ///
        public String? UserSoftwareId { get; set; }
        ///
        public String? ApplicationUserId { get; set; }
        // public ApplicationUserCreateVM? ApplicationUser { get; set; }
        ///
        public String? SoftwareId { get; set; }
    // public SoftwareCreateVM? Software { get; set; }
    }
}