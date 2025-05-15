using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.VMs
{
    /// <summary>
    /// ApplicationUser  property for VM Output.
    /// </summary>
    public class ApplicationUserOutputVM : ITVM
    {
        //
        public List<QuestionOutputVM>? Questions { get; set; }
        //
        public List<AnswerOutputVM>? Answers { get; set; }
        //
        public List<UserSoftwareOutputVM>? UserSoftwares { get; set; }
        //
        public List<UserTacticOutputVM>? UserTactics { get; set; }
        //
        public List<UserScenarioOutputVM>? UserScenarios { get; set; }
        //
        public List<UserTechniqueOutputVM>? UserTechniques { get; set; }
        ///
        public String? Id { get; set; }
        ///
        public String? UserName { get; set; }
        ///
        public String? NormalizedUserName { get; set; }
        ///
        public String? Email { get; set; }
        ///
        public String? NormalizedEmail { get; set; }
        ///
        public Boolean EmailConfirmed { get; set; }
        ///
        public String? PasswordHash { get; set; }
        ///
        public String? SecurityStamp { get; set; }
        ///
        public String? ConcurrencyStamp { get; set; }
        ///
        public String? PhoneNumber { get; set; }
        ///
        public Boolean PhoneNumberConfirmed { get; set; }
        ///
        public Boolean TwoFactorEnabled { get; set; }
        ///
        public Nullable<DateTimeOffset> LockoutEnd { get; set; }
        ///
        public Boolean LockoutEnabled { get; set; }
        ///
        public Int32 AccessFailedCount { get; set; }
    }
}