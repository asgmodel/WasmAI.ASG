using AutoGenerator;
using AutoGenerator.Conditions;
using WasmAI.ASG.V1.Validators.Conditions;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.Validators
{
    public abstract class ValidatorContext<TContext, EValidator> : BaseValidatorContext<TContext, EValidator>, ITValidator where TContext : class where EValidator : Enum
    {
        protected readonly ITFactoryInjector _injector;
        public ValidatorContext(IConditionChecker checker) : base(checker)
        {
            _injector = checker.Injector;
        }

        protected virtual async Task<TContext?> FinModel(string? id)
        {
            var _model = await _injector.Context.Set<TContext>().FindAsync(id);
            return _model;
        }

        protected override Task<TContext?> GetModel(string? id)
        {
            return FinModel(id);
        }
    }
}