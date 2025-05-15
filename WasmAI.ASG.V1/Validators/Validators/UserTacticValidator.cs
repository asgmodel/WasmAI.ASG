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
    public class UserTacticValidatorContext : ValidatorContext<UserTactic, UserTacticValidatorStates>, ITValidator
    {
        public UserTacticValidatorContext(IConditionChecker checker) : base(checker)
        {
        }

        protected override void InitializeConditions()
        {
        }
    } //
    //  Base
    public  enum  UserTacticValidatorStates //
    { IsActive ,  IsFull ,  IsValid ,  //
    }

}