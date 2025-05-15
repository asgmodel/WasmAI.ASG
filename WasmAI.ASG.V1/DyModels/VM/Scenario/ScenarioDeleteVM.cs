using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.VMs
{
    /// <summary>
    /// Scenario  property for VM Delete.
    /// </summary>
    public class ScenarioDeleteVM : ITVM
    {
        ///
        public string? Id { get; set; }
    }
}