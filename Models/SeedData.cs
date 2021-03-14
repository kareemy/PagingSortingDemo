using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace PagingSortingDemo.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProfessorContext(serviceProvider.GetRequiredService<DbContextOptions<ProfessorContext>>()))
            {
                if (context.Professor.Any())
                {
                    return;
                }

                context.Professor.AddRange(
                    new Professor { FirstName = "Kareem", LastName = "Dana" },
                    new Professor { FirstName = "Jeff", LastName = "Babb" },
                    new Professor { FirstName = "Amjad", LastName = "Abdullat" },
                    new Professor { FirstName = "Gottfried", LastName = "Heap" },
                    new Professor { FirstName = "Bernadine", LastName = "Brothwell" },
                    new Professor { FirstName = "Dorolisa", LastName = "Presland" },
                    new Professor { FirstName = "Evy", LastName = "Lyman" },
                    new Professor { FirstName = "Gillie", LastName = "Roback" },
                    new Professor { FirstName = "Gleda", LastName = "Klimshuk" },
                    new Professor { FirstName = "Liuka", LastName = "Hasker" },
                    new Professor { FirstName = "Luz", LastName = "Jorez" },
                    new Professor { FirstName = "Nessy", LastName = "Marjoribanks" },
                    new Professor { FirstName = "Karie", LastName = "Olivo" },
                    new Professor { FirstName = "Salmon", LastName = "Deam" },
                    new Professor { FirstName = "Thalia", LastName = "Boatwright" },
                    new Professor { FirstName = "Byrom", LastName = "Maudett" },
                    new Professor { FirstName = "Jeremy", LastName = "Cluett" },
                    new Professor { FirstName = "Zondra", LastName = "Castelijn" },
                    new Professor { FirstName = "Baudoin", LastName = "Hellens" },
                    new Professor { FirstName = "Phebe", LastName = "Snodin" },
                    new Professor { FirstName = "Jacquie", LastName = "Drewitt" },
                    new Professor { FirstName = "Marlee", LastName = "Bustin" },
                    new Professor { FirstName = "Harrie", LastName = "Extal" },
                    new Professor { FirstName = "Ellene", LastName = "Starzaker" },
                    new Professor { FirstName = "Kettie", LastName = "Van Ross" },
                    new Professor { FirstName = "Mikkel", LastName = "Ludewig" },
                    new Professor { FirstName = "Hank", LastName = "Rutherfoord" },
                    new Professor { FirstName = "Kathie", LastName = "Calcut" },
                    new Professor { FirstName = "Matti", LastName = "Stead" },
                    new Professor { FirstName = "Peria", LastName = "Milvarnie" },
                    new Professor { FirstName = "Willdon", LastName = "Naton" },
                    new Professor { FirstName = "Jeffrey", LastName = "Boldock" },
                    new Professor { FirstName = "Patty", LastName = "Weare" },
                    new Professor { FirstName = "Edith", LastName = "Harome" },
                    new Professor { FirstName = "Tristam", LastName = "Lilbourne" },
                    new Professor { FirstName = "Trenton", LastName = "Cason" },
                    new Professor { FirstName = "Liam", LastName = "Mourbey" },
                    new Professor { FirstName = "Corrine", LastName = "Von Der Empten" },
                    new Professor { FirstName = "Sissy", LastName = "Plackstone" },
                    new Professor { FirstName = "Tymothy", LastName = "Hasling" },
                    new Professor { FirstName = "Marilin", LastName = "Knotte" },
                    new Professor { FirstName = "Rochella", LastName = "Tulip" },
                    new Professor { FirstName = "Klement", LastName = "Bidewell" },
                    new Professor { FirstName = "Sunny", LastName = "Carradice" },
                    new Professor { FirstName = "Rosabelle", LastName = "Paddingdon" },
                    new Professor { FirstName = "Mose", LastName = "Sitlinton" },
                    new Professor { FirstName = "Audi", LastName = "Lowndsbrough" },
                    new Professor { FirstName = "Merry", LastName = "Emlyn" },
                    new Professor { FirstName = "Kalina", LastName = "Repp" },
                    new Professor { FirstName = "Peggy", LastName = "O'Hanley" },
                    new Professor { FirstName = "Milly", LastName = "Corain" },
                    new Professor { FirstName = "Jyoti", LastName = "Brayfield" },
                    new Professor { FirstName = "Jordana", LastName = "Hartnell" },
                    new Professor { FirstName = "Harmonie", LastName = "Mingo" },
                    new Professor { FirstName = "Lynnett", LastName = "Spittal" },
                    new Professor { FirstName = "Cletis", LastName = "Broke" },
                    new Professor { FirstName = "Annabela", LastName = "Stanistrete" },
                    new Professor { FirstName = "Devan", LastName = "Mewis" },
                    new Professor { FirstName = "Joby", LastName = "Habbes" },
                    new Professor { FirstName = "Sephira", LastName = "Darling" },
                    new Professor { FirstName = "Hamlin", LastName = "Pirot" },
                    new Professor { FirstName = "Steffane", LastName = "Bailey" },
                    new Professor { FirstName = "Shayla", LastName = "Hatwells" },
                    new Professor { FirstName = "Torry", LastName = "MacCrossan" },
                    new Professor { FirstName = "Sheilakathryn", LastName = "Bagworth" },
                    new Professor { FirstName = "Sapphire", LastName = "Pepineaux" },
                    new Professor { FirstName = "Garold", LastName = "Colleer" },
                    new Professor { FirstName = "Dyana", LastName = "Labat" },
                    new Professor { FirstName = "Joannes", LastName = "Dingley" },
                    new Professor { FirstName = "Ad", LastName = "Tuffley" },
                    new Professor { FirstName = "Aviva", LastName = "Rawlins" },
                    new Professor { FirstName = "Roscoe", LastName = "Bater" },
                    new Professor { FirstName = "Karel", LastName = "Tenny" },
                    new Professor { FirstName = "Ennis", LastName = "Saffell" },
                    new Professor { FirstName = "Berkie", LastName = "Mansell" },
                    new Professor { FirstName = "Fiann", LastName = "Slarke" },
                    new Professor { FirstName = "Pauletta", LastName = "Featherstone" },
                    new Professor { FirstName = "Tamra", LastName = "Sawart" },
                    new Professor { FirstName = "Charlena", LastName = "Grieveson" },
                    new Professor { FirstName = "Bette-ann", LastName = "Semens" },
                    new Professor { FirstName = "Mickey", LastName = "Barttrum" },
                    new Professor { FirstName = "Dodie", LastName = "Beslier" },
                    new Professor { FirstName = "Eadmund", LastName = "O'Heyne" },
                    new Professor { FirstName = "Leupold", LastName = "Venediktov" },
                    new Professor { FirstName = "Ellery", LastName = "Note" },
                    new Professor { FirstName = "Lenore", LastName = "Rymmer" },
                    new Professor { FirstName = "Cristian", LastName = "Widger" },
                    new Professor { FirstName = "Gracia", LastName = "Whopples" },
                    new Professor { FirstName = "Vitoria", LastName = "Addyman" },
                    new Professor { FirstName = "Roy", LastName = "Setchell" },
                    new Professor { FirstName = "Monah", LastName = "Guntrip" },
                    new Professor { FirstName = "Sibbie", LastName = "Claw" },
                    new Professor { FirstName = "Teodora", LastName = "Deverose" },
                    new Professor { FirstName = "Germana", LastName = "Westover" },
                    new Professor { FirstName = "Lisha", LastName = "Kirlin" },
                    new Professor { FirstName = "Pall", LastName = "Avesque" },
                    new Professor { FirstName = "Wylie", LastName = "Turbill" },
                    new Professor { FirstName = "Hestia", LastName = "Welchman" },
                    new Professor { FirstName = "Skylar", LastName = "Jouning" },
                    new Professor { FirstName = "Miller", LastName = "Pitkeathly" },
                    new Professor { FirstName = "Charo", LastName = "Southward" },
                    new Professor { FirstName = "Henry", LastName = "Targett" },
                    new Professor { FirstName = "Pen", LastName = "Tavner" }
                );
                context.SaveChanges();
            }
        }
  
    }
}