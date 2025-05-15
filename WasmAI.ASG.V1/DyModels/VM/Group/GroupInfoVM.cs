using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.VMs
{
    /// <summary>
    /// Group  property for VM Info.
    /// </summary>
    public class GroupInfoVM : ITVM
    {
        ///
        public string? Id { get; set; }
    }
}