using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.VMs
{
    /// <summary>
    /// Scenario  property for VM Update.
    /// </summary>
    public class ScenarioUpdateVM : ITVM
    {
        ///
        public string? Id { get; set; }
        ///
        public ScenarioCreateVM? Body { get; set; }
    }
}