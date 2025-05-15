using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.VMs
{
    /// <summary>
    /// Technique  property for VM Output.
    /// </summary>
    public class TechniqueOutputVM : ITVM
    {
        ///
        public String? TechniqueId { get; set; }
        ///
        public String? Name { get; set; }
        ///
        public String? Description { get; set; }
        ///
        public String? Detection { get; set; }
        ///
        public String? TacticId { get; set; }
        public TacticOutputVM? Tactic { get; set; }
        //
        public List<ScenarioOutputVM>? Scenarios { get; set; }
    }
}