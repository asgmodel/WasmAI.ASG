using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.VMs
{
    /// <summary>
    /// UserScenario  property for VM Create.
    /// </summary>
    public class UserScenarioCreateVM : ITVM
    {
        ///
        public String? UserScenarioId { get; set; }
        ///
        public String? ApplicationUserId { get; set; }
        // public ApplicationUserCreateVM? ApplicationUser { get; set; }
        ///
        public String? ScenarioId { get; set; }
    // public ScenarioCreateVM? Scenario { get; set; }
    }
}