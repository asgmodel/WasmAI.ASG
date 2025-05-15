using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.VMs
{
    /// <summary>
    /// ScenarioType  property for VM Create.
    /// </summary>
    public class ScenarioTypeCreateVM : ITVM
    {
        ///
        public String? ScenarioTypeId { get; set; }
        ///
        public String? TypeName { get; set; }
        //
        public List<ScenarioCreateVM>? Scenarios { get; set; }
    }
}