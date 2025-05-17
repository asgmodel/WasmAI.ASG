using AutoGenerator;
using AutoGenerator.Config;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WasmAI.ASG.Models
{
    //[SchedulerEnabled(true)]
    public class Tactic :ITModel
    {
        [Key]
        public string TacticId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string ShortName { get; set; }

        // Many-to-Many مع Scenario
        public ICollection<Scenario> Scenarios { get; set; }

        // Many-to-Many مع Technique
        public ICollection<Technique> Techniques { get; set; } = new List<Technique>();
    }

    public class Technique : ITModel
    {
        [Key]
        public string TechniqueId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Detection { get; set; }

        // العلاقة مع التكتيك
        public string TacticId { get; set; }
        [ForeignKey("TacticId")]
        public Tactic Tactic { get; set; }

        // Many-to-Many مع Scenario
        public ICollection<Scenario> Scenarios { get; set; }
    }

    public class Software : ITModel
    {
        [Key]
        public string SoftwareId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SoftwareType { get; set; }

        public string GroupId { get; set; }
        [ForeignKey("GroupId")]
        public Group Group { get; set; }

        // Many-to-Many مع Scenario
        public ICollection<Scenario> Scenarios { get; set; }

        // Many-to-Many مع Tactic
        public ICollection<Tactic> Tactics { get; set; }
    }

    public class Group : ITModel
    {
        [Key]
        public string GroupId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Many-to-Many مع Scenario
        public ICollection<Scenario> Scenarios { get; set; }

        // Many-to-Many مع Software
        public ICollection<Software> Softwares { get; set; }
    }

    public class ScenarioType : ITModel
    {
        [Key]
        public string ScenarioTypeId { get; set; }
        public string TypeName { get; set; } // نوع السيناريو مثل "Success", "Failure", إلخ.

        // علاقة مع سيناريوهات متعددة
        public ICollection<Scenario> Scenarios { get; set; }
    }

  

    public class Scenario : ITModel
    {
        [Key]
        public string ScenarioId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        // Many-to-Many مع Technique
        public ICollection<Technique> Techniques { get; set; }

        // Many-to-Many مع Tactic
        public ICollection<Tactic> Tactics { get; set; }

        // Many-to-Many مع Software
        public ICollection<Software> Softwares { get; set; }

        // Many-to-Many مع Group
        public ICollection<Group> Groups { get; set; }

        // علاقة مع نوع السيناريو
        public string ScenarioTypeId { get; set; }
        [ForeignKey("ScenarioTypeId")]
        public ScenarioType ScenarioType { get; set; }

        // حالة السيناريو
        public string Status { get; set; }  // مثل "مكتمل", "قيد المعالجة", "فشل", إلخ.

        // نسبة صحة السيناريو (مثال: 0.85 تعني 85% صحة)
        public double HealthPercentage { get; set; }

        // عدد التكنيكات المرتبطة بالسيناريو
        public int TechniquesCount { get; set; }
    }




    public class Question : ITModel
    {
        [Key]
        public string QuestionId { get; set; }

        [ToTranslation]
        public string Text { get; set; }

        // علاقة مع المستخدم
        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        public ApplicationUser ApplicationUser { get; set; }
    }




    public class Answer : ITModel
    {
        [Key]
        public string AnswerId { get; set; }
        public string Text { get; set; }

        // علاقة مع السؤال
        public string QuestionId { get; set; }
        [ForeignKey("QuestionId")]
        public Question Question { get; set; }

        // علاقة مع المستخدم
        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        public ApplicationUser ApplicationUser { get; set; }
    }

    [SchedulerEnabled(true)]
    public class UserSoftware : ITModel
    {
        [Key]
        public string UserSoftwareId { get; set; }

        // علاقة مع المستخدم
        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        public ApplicationUser ApplicationUser { get; set; }

        // علاقة مع البرمجية
        public string SoftwareId { get; set; }
        [ForeignKey("SoftwareId")]
        public Software Software { get; set; }
    }
    public class UserTactic : ITModel
    {
        [Key]
        public string UserTacticId { get; set; }

        // علاقة مع المستخدم
        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        public ApplicationUser ApplicationUser { get; set; }

        // علاقة مع التكتيك
        public string TacticId { get; set; }
        [ForeignKey("TacticId")]
        public Tactic Tactic { get; set; }
    }

    public class UserScenario : ITModel
    {
        [Key]
        public string UserScenarioId { get; set; }

        // علاقة مع المستخدم
        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        public ApplicationUser ApplicationUser { get; set; }

        // علاقة مع السيناريو
        public string ScenarioId { get; set; }
        [ForeignKey("ScenarioId")]
        public Scenario Scenario { get; set; }
    }

    public class UserTechnique : ITModel
    {
        [Key]
        public string UserTechniqueId { get; set; }

        // علاقة مع المستخدم
        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        public ApplicationUser ApplicationUser { get; set; }

        // علاقة مع التقنية
        public string TechniqueId { get; set; }
        [ForeignKey("TechniqueId")]
        public Technique Technique { get; set; }
    }

  

}

