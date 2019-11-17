using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NSApp.Models
{
    public class CheckDataModel
    {
        public int[] NaturalRollValues { get; set; }
        public int DifficultyModifier { get; set; }

        [Required]
        public int DifficultyLevel { get; set; }

        public HeroModel Hero { get; set; }
        public string TempHeroName { get; set; }
    }
}
