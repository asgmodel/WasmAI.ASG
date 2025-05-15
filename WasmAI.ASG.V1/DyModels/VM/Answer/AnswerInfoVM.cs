using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.VMs
{
    /// <summary>
    /// Answer  property for VM Info.
    /// </summary>
    public class AnswerInfoVM : ITVM
    {
        ///
        public string? Id { get; set; }
    }
}