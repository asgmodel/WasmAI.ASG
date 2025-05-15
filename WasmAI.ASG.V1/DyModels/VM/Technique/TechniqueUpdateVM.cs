using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.VMs
{
    /// <summary>
    /// Technique  property for VM Update.
    /// </summary>
    public class TechniqueUpdateVM : ITVM
    {
        ///
        public string? Id { get; set; }
        ///
        public TechniqueCreateVM? Body { get; set; }
    }
}