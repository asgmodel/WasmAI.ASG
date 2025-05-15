using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.VMs
{
    /// <summary>
    /// Software  property for VM Create.
    /// </summary>
    public class SoftwareCreateVM : ITVM
    {
        ///
        public String? SoftwareId { get; set; }
        ///
        public String? Name { get; set; }
        ///
        public String? Description { get; set; }
        ///
        public String? SoftwareType { get; set; }
        ///
        public String? GroupId { get; set; }
        // public GroupCreateVM? Group { get; set; }
        //
        public List<ScenarioCreateVM>? Scenarios { get; set; }
        //
        public List<TacticCreateVM>? Tactics { get; set; }
    }
}