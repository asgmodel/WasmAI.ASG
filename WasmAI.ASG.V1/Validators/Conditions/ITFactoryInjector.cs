using AutoGenerator;
using AutoGenerator.Conditions;
using AutoMapper;
using WasmAI.ASG.Data;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.Validators.Conditions
{
    public interface ITFactoryInjector : ITBaseFactoryInjector
    {
        public DataContext Context { get; }
    }
}