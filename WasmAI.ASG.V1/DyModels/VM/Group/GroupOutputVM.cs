using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.VMs
{
    /// <summary>
    /// Group  property for VM Output.
    /// </summary>
    public class GroupOutputVM : ITVM
    {
        ///
        public String? GroupId { get; set; }
        ///
        public String? Name { get; set; }
        ///
        public String? Description { get; set; }
        //
        public List<ScenarioOutputVM>? Scenarios { get; set; }
        //
        public List<SoftwareOutputVM>? Softwares { get; set; }
    }
}