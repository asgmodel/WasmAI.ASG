using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.VMs
{
    /// <summary>
    /// Scenario  property for VM Output.
    /// </summary>
    public class ScenarioOutputVM : ITVM
    {
        ///
        public String? ScenarioId { get; set; }
        ///
        public String? Title { get; set; }
        ///
        public String? Description { get; set; }
        //
        public List<TechniqueOutputVM>? Techniques { get; set; }
        //
        public List<TacticOutputVM>? Tactics { get; set; }
        //
        public List<SoftwareOutputVM>? Softwares { get; set; }
        //
        public List<GroupOutputVM>? Groups { get; set; }
        ///
        public String? ScenarioTypeId { get; set; }
        public ScenarioTypeOutputVM? ScenarioType { get; set; }
        ///
        public String? Status { get; set; }
        ///
        public Double HealthPercentage { get; set; }
        ///
        public Int32 TechniquesCount { get; set; }
    }
}