using HartleyAndMarks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HartleyAndMarks.Controllers
{
    public class ProductsController : Controller
    {
        //
        // GET: /Products/

        public ActionResult Index()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product()
            {
                Name = "Need For Speed: Rivals",
                Publisher = "Electronic Arts",
                BoxShot = "nfs_rivals.jpg",
                Description = "Need for Speed Rivals captures the adrenaline and intensity of the street's ultimate rivalry between cops and racers in a stunning open road environment. Need for Speed Rivals allows gamers play as either a cop or racer.",
                Genre = "Racing",
                ReleaseDate = new DateTime(2013, 11, 15)
            });
            products.Add(new Product()
            {
                Name = "Call of Duty: Ghosts",
                Publisher = "Activision",
                BoxShot = "cod_ghosts.jpg",
                Description = "Call of Duty: Ghosts delivers a riveting all-new gameplay experience built on an entirely new story, setting and cast of characters, all powered by a new, next generation Call of Duty engine that redefines the series for the next generation.",
                Genre = "First Person Shooter",
                ReleaseDate = new DateTime(2013, 11, 5)
            });


            products.Add(new Product()
            {
                Name = "Lightning Returns: Final Fantasy XIII",
                Publisher = "Square Enix",
                BoxShot = "ffx13.jpg",
                Description = "As Lightning, it is your mission to save souls so they may be brought to a new world. However, with only thirteen days remaining, not everyone can be saved. Armed with all-new weapons, you are in a race against time to fully understand your destiny.",
                Genre = "RPG",
                ReleaseDate = new DateTime(2014, 2, 11)
            });

            products.Add(new Product()
            {
                Name = "Infamous: Second Son",
                Publisher = "Sony",
                BoxShot = "infamous_second_son.jpg",
                Description = "A new hero (or is it anti-hero) gains amazing powers in this new chapter in the action franchise Infamous by Sucker Punch.",
                Genre = "genre4",
                ReleaseDate = new DateTime(2014, 3, 21)
            });
            return View(products.OrderBy(p => p.ReleaseDate));
        }

    }
}
