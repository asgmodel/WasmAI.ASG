using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.VMs
{
    /// <summary>
    /// UserSoftware  property for VM Output.
    /// </summary>
    public class UserSoftwareOutputVM : ITVM
    {
        ///
        public String? UserSoftwareId { get; set; }
        ///
        public String? ApplicationUserId { get; set; }
        public ApplicationUserOutputVM? ApplicationUser { get; set; }
        ///
        public String? SoftwareId { get; set; }
        public SoftwareOutputVM? Software { get; set; }
    }
}