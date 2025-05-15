using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.VMs
{
    /// <summary>
    /// UserScenario  property for VM Output.
    /// </summary>
    public class UserScenarioOutputVM : ITVM
    {
        ///
        public String? UserScenarioId { get; set; }
        ///
        public String? ApplicationUserId { get; set; }
        public ApplicationUserOutputVM? ApplicationUser { get; set; }
        ///
        public String? ScenarioId { get; set; }
        public ScenarioOutputVM? Scenario { get; set; }
    }
}