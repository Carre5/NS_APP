using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NSApp.Models;

namespace NSApp.Controllers
{
    public class HeroController : Controller
    {
        public HeroModel Hero;
        public TricksModel TricksModel;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Tricks()
        {
            TricksModel = new TricksModel();
            TricksModel.Tricks = new List<TrickModel>()
            {
                new TrickModel()
                {
                    Name ="3 2 1 Bum",
                    Requirements = new List<TrickRequirement>()
                    {
                        new TrickRequirement()
                        {
                            Name = "Mechanika",
                            Value = 3
                        },
                        new TrickRequirement()
                        {
                            Name = "Mechanika",
                            Value = 3
                        }
                    },
                    Info = "Neuroshima 1.5 str. 98",
                    Description = "Wszystkie urządzenia na świecie można podzielić na takie, które czasem wybuchają, i takie, które nigdy nie wybuchają. Szczególnie interesują cię te pierwsze. Wystarczy tu przeciąć wężyk, tam skręcić kabel, tu znów poluzować śrubkę. I gotowe. Teraz wystarczy poczekać na fajerwerki.",
                    Working = "Możesz uzbroić - jak bombę - dowolny pojazd, urządzenie czy maszynę napędzaną łatwopalnym paliwem. Kwadrans spokojnej pracy i możesz zacząć odliczanie. Czas wybuchu określasz z pięćdziesięcioprocentową dokładnością na sekundę, minutę, kwadrans lub godzinę (np. gdy wybierzesz minutę, spodziewaj się wybuchu między pół a półtorej minuty). Czasem, jeśli MG pozwoli, nawet na tydzień. Siła wybuchu zależy od rodzaju urządzenia."
                },
                new TrickModel()
                {
                    Name ="Aramis",
                    Requirements = new List<TrickRequirement>()
                    {
                        new TrickRequirement()
                        {
                            Name = "Zręczność",
                            Value = 14
                        },
                        new TrickRequirement()
                        {
                            Name = "Broń ręczna",
                            Value = 5
                        }
                    },
                    Info = "Neuroshima 1.5 str. 98",
                    Description = "Gdy spotkasz kiedyś wędrującego samotnie dziadka, który podpiera się kijkiem, za nic w świecie go nie zaczepiaj. To może być Dziadzio z Alabamy. Najpierw wytrąci ci kijkiem twój topór, potem złoi na kwaśne jabłko, a na koniec pogrozi palcem i pójdzie sobie dalej.",
                    Working = "Akcja za 2 sukcesy: PT testu o poziom wyższy, do ataku dowolną bronią dłuższą od noża. Szast, prast i broń przeciwnika (każda dłuższa od noża) leci na bok."
                },
                new TrickModel()
                {
                    Name ="Asekuracja",
                    Requirements = new List<TrickRequirement>()
                    {
                        new TrickRequirement()
                        {
                            Name = "Wspinaczka",
                            Value = 2
                        }
                    },
                    Info = "Neuroshima 1.5 str. 98",
                    Description = "No nieźle ci idzie, teraz spróbuj sam. No dalej nie pękaj...",
                    Working = "Bohater pomaga innej osobie (zapiętej w uprząż) wspinać się po linie. Dzięki temu osoba ta traktowana jest, jak gdyby miała. Umiejętność Wspinaczka na poziomie 1. Pozwala jej to uniknąć kłopotów z Suwakiem."
                },
            };
            return View(TricksModel);
        }

        [HttpGet]
        public IActionResult Fill()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Fill(HeroModel hero)
        {
            return View(hero);
        }
    }
}