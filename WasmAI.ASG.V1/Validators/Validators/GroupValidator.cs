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
    public class GroupValidatorContext : ValidatorContext<Group, GroupValidatorStates>, ITValidator
    {
        public GroupValidatorContext(IConditionChecker checker) : base(checker)
        {
        }

        protected override void InitializeConditions()
        {
        }
    } //
    //  Base
    public  enum  GroupValidatorStates //
    { IsActive ,  IsFull ,  IsValid ,  //
    }

}