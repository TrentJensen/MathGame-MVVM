using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MathGame.Model
{
    public class Player
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        public int? AddScore { get; set; }
        public int? AddTime { get; set; }
        public int? SubScore { get; set; }
        public int? SubTime { get; set; }
        public int? MultScore { get; set; }
        public int? MultTime { get; set; }
        public int? DivScore { get; set; }
        public int? DivTime { get; set; }
    }
}
