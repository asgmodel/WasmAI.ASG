using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.VMs
{
    /// <summary>
    /// UserTactic  property for VM Update.
    /// </summary>
    public class UserTacticUpdateVM : ITVM
    {
        ///
        public string? Id { get; set; }
        ///
        public UserTacticCreateVM? Body { get; set; }
    }
}