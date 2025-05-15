using AutoGenerator;
using AutoGenerator.Helper.Translation;
using AutoGenerator.Conditions;
using WasmAI.ASG.V1.Validators.Conditions;
using WasmAI.ASG.Models;
using WasmAI.ASG.V1.Validators.Conditions;
using WasmAI.ConditionChecker.Base;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.Validators
{
    public class UserScenarioValidatorContext : ValidatorContext<UserScenario, UserScenarioValidatorStates>, ITValidator
    {
        public UserScenarioValidatorContext(IConditionChecker checker) : base(checker)
        {
        }

        protected override void InitializeConditions()
        {
        }
    } //
    //  Base
    public  enum  UserScenarioValidatorStates //
    { IsActive ,  IsFull ,  IsValid ,  //
    }

}