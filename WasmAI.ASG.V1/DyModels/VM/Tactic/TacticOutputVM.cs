using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.VMs
{
    /// <summary>
    /// Tactic  property for VM Output.
    /// </summary>
    public class TacticOutputVM : ITVM
    {
        ///
        public String? TacticId { get; set; }
        ///
        public String? Name { get; set; }
        ///
        public String? Description { get; set; }
        ///
        public String? ShortName { get; set; }
        //
        public List<ScenarioOutputVM>? Scenarios { get; set; }
        //
        public List<TechniqueOutputVM>? Techniques { get; set; }
    }
}