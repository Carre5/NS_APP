using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NSApp.Models;

namespace NSApp.Controllers
{
    public class CheckController : Controller
    {
        private CheckDataModel CheckData;
        private List<HeroModel> Heroes;
        public IActionResult Index()
        {
            getHeroesData();
            return View();
        }

        public IActionResult Roll(CheckDataModel formData)
        {
            getHeroesData();
            CheckData = formData;

            #region Obtaining Difficulty Modifier

            CheckData.DifficultyModifier = -8;
            #endregion

            #region Randomizing Values [3d20]

            Random rand = new Random();
            CheckData.NaturalRollValues = new int[3];
            for (int i = 0; i < CheckData.NaturalRollValues.Length; i++)
            {
                CheckData.NaturalRollValues[i] = rand.Next(1, 21);
            }
            #endregion

            //Przypisanie bohatera wybranego po imieniu
            foreach (var hero in Heroes)
            {
                if(hero.Name == CheckData.TempHeroName)
                {
                    CheckData.Hero = hero;
                }
            }

            return View(CheckData);
        }

        private void getHeroesData()
        {
            Heroes = new List<HeroModel>() {
                new HeroModel() {
                    Name = "Meksykanin",
                    AttributeValue = 13,
                    SkillValue = 3
                },
                new HeroModel() {
                    Name = "Ganger",
                    AttributeValue = 15,
                    SkillValue = 2
                },
                new HeroModel() {
                    Name = "Dziecię Zieleni",
                    AttributeValue = 12,
                    SkillValue = 4
                }
            };
            ViewBag.Heroes = Heroes;
        }
    }
}