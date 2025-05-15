using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.VMs
{
    /// <summary>
    /// Scenario  property for VM Create.
    /// </summary>
    public class ScenarioCreateVM : ITVM
    {
        ///
        public String? ScenarioId { get; set; }
        ///
        public String? Title { get; set; }
        ///
        public String? Description { get; set; }
        //
        public List<TechniqueCreateVM>? Techniques { get; set; }
        //
        public List<TacticCreateVM>? Tactics { get; set; }
        //
        public List<SoftwareCreateVM>? Softwares { get; set; }
        //
        public List<GroupCreateVM>? Groups { get; set; }
        ///
        public String? ScenarioTypeId { get; set; }
        // public ScenarioTypeCreateVM? ScenarioType { get; set; }
        ///
        public String? Status { get; set; }
        ///
        public Double HealthPercentage { get; set; }
        ///
        public Int32 TechniquesCount { get; set; }
    }
}