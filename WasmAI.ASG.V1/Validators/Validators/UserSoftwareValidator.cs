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
    public class UserSoftwareValidatorContext : ValidatorContext<UserSoftware, UserSoftwareValidatorStates>, ITValidator
    {
        public UserSoftwareValidatorContext(IConditionChecker checker) : base(checker)
        {
        }

        protected override void InitializeConditions()
        {
        }
    } //
    //  Base
    public  enum  UserSoftwareValidatorStates //
    { IsActive ,  IsFull ,  IsValid ,  //
    }

}