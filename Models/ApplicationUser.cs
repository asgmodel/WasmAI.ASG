using AutoGenerator;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WasmAI.ASG.Models
{

    public class ApplicationUser : IdentityUser,ITModel
    {

        public ICollection<Question> Questions { get; set; }
        public ICollection<Answer> Answers { get; set; }
        public ICollection<UserSoftware> UserSoftwares { get; set; }
        public ICollection<UserTactic> UserTactics { get; set; }
        public ICollection<UserScenario> UserScenarios { get; set; }
        public ICollection<UserTechnique> UserTechniques { get; set; }

    }
}
