using AutoGenerator.Conditions;
using WasmAI.ASG.V1.Validators.Conditions;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.Validators
{
    public class ConditionChecker : BaseConditionChecker, IConditionChecker
    {
        private readonly ITFactoryInjector _injector;
        public ITFactoryInjector Injector => _injector;

        public ConditionChecker(ITFactoryInjector injector) : base()
        {
        }
    // الدوال السابقة تبقى كما هي
    }
}