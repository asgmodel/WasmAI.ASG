using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.VMs
{
    /// <summary>
    /// ScenarioType  property for VM Update.
    /// </summary>
    public class ScenarioTypeUpdateVM : ITVM
    {
        ///
        public string? Id { get; set; }
        ///
        public ScenarioTypeCreateVM? Body { get; set; }
    }
}