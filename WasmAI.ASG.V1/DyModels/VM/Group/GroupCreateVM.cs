using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.VMs
{
    /// <summary>
    /// Group  property for VM Create.
    /// </summary>
    public class GroupCreateVM : ITVM
    {
        ///
        public String? GroupId { get; set; }
        ///
        public String? Name { get; set; }
        ///
        public String? Description { get; set; }
        //
        public List<ScenarioCreateVM>? Scenarios { get; set; }
        //
        public List<SoftwareCreateVM>? Softwares { get; set; }
    }
}