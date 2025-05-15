using AutoGenerator.Conditions;
using WasmAI.ASG.V1.Validators.Conditions;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.Validators
{
    public interface IConditionChecker : IBaseConditionChecker
    {
        public ITFactoryInjector Injector { get; }
    }
}