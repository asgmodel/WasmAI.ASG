using AutoGenerator;
using AutoGenerator.Conditions;
using System.Reflection;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.Validators.Conditions
{
    public static class ConfigValidator
    {
        public static IServiceCollection AddAutoValidator(this IServiceCollection serviceCollection)
        {
            Assembly? assembly = Assembly.GetExecutingAssembly();
            serviceCollection.AddScoped<ITFactoryInjector, TFactoryInjector>();
            serviceCollection.AddScoped<IConditionChecker, ConditionChecker>(pro =>
            {
                var injctor = pro.GetRequiredService<ITFactoryInjector>();
                var checker = new ConditionChecker(injctor);
                BaseConfigValidator.Register(checker, assembly);
                return checker;
            });
            return serviceCollection;
        }
    }
}