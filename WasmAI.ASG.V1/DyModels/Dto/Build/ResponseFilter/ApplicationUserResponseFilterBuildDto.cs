using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.ASG.Models;
using AutoGenerator.Config;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.DyModels.Dto.Build.ResponseFilters
{
    public class ApplicationUserResponseFilterBuildDto : ITBuildDto
    {
        public ICollection<QuestionResponseFilterBuildDto>? Questions { get; set; }
        public ICollection<AnswerResponseFilterBuildDto>? Answers { get; set; }
        public ICollection<UserSoftwareResponseFilterBuildDto>? UserSoftwares { get; set; }
        public ICollection<UserTacticResponseFilterBuildDto>? UserTactics { get; set; }
        public ICollection<UserScenarioResponseFilterBuildDto>? UserScenarios { get; set; }
        public ICollection<UserTechniqueResponseFilterBuildDto>? UserTechniques { get; set; }
        public string? Id { get; set; } = $"applicationuser_{Guid.NewGuid().ToString()}";
        /// <summary>
        /// UserName property for DTO.
        /// </summary>
        public String? UserName { get; set; }
        /// <summary>
        /// NormalizedUserName property for DTO.
        /// </summary>
        public String? NormalizedUserName { get; set; }
        /// <summary>
        /// Email property for DTO.
        /// </summary>
        public String? Email { get; set; }
        /// <summary>
        /// NormalizedEmail property for DTO.
        /// </summary>
        public String? NormalizedEmail { get; set; }
        /// <summary>
        /// EmailConfirmed property for DTO.
        /// </summary>
        public Boolean EmailConfirmed { get; set; }
        /// <summary>
        /// PasswordHash property for DTO.
        /// </summary>
        public String? PasswordHash { get; set; }
        /// <summary>
        /// SecurityStamp property for DTO.
        /// </summary>
        public String? SecurityStamp { get; set; }
        /// <summary>
        /// ConcurrencyStamp property for DTO.
        /// </summary>
        public String? ConcurrencyStamp { get; set; }
        /// <summary>
        /// PhoneNumber property for DTO.
        /// </summary>
        public String? PhoneNumber { get; set; }
        /// <summary>
        /// PhoneNumberConfirmed property for DTO.
        /// </summary>
        public Boolean PhoneNumberConfirmed { get; set; }
        /// <summary>
        /// TwoFactorEnabled property for DTO.
        /// </summary>
        public Boolean TwoFactorEnabled { get; set; }
        /// <summary>
        /// LockoutEnd property for DTO.
        /// </summary>
        public Nullable<DateTimeOffset> LockoutEnd { get; set; }
        /// <summary>
        /// LockoutEnabled property for DTO.
        /// </summary>
        public Boolean LockoutEnabled { get; set; }
        /// <summary>
        /// AccessFailedCount property for DTO.
        /// </summary>
        public Int32 AccessFailedCount { get; set; }

        [FilterLGEnabled]
        public string? Lg { get; set; }
    }
}