using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.VMs
{
    /// <summary>
    /// Answer  property for VM Create.
    /// </summary>
    public class AnswerCreateVM : ITVM
    {
        ///
        public String? AnswerId { get; set; }
        ///
        public String? Text { get; set; }
        ///
        public String? QuestionId { get; set; }
        // public QuestionCreateVM? Question { get; set; }
        ///
        public String? ApplicationUserId { get; set; }
    // public ApplicationUserCreateVM? ApplicationUser { get; set; }
    }
}