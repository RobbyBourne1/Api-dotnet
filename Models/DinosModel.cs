using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Api_dotnet.Models
{
   
    public class DinosModel 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Diet { get; set; }

        public DinosModel()
        {

        }

        public List<DinosModel> DinoListGetter()
        {
            var DinosList = new List<DinosModel>();
            var TRex = new DinosModel
            {
                Id = 1,
                Name = "T-Rex",
                Color = "Red" ,
                Diet = "Carnivore"
            };

            var Raptor = new DinosModel
            {
                Id = 2,
                Name = "Raptor",
                Color = "Blue" ,
                Diet = "Carnivore"
            };

            var Stegosaurus = new DinosModel
            {
                Id = 3,
                Name = "Stegosaurus",
                Color = "Green" ,
                Diet = "Herbivore"
            };

            DinosList.Add(TRex);
            DinosList.Add(Raptor);
            DinosList.Add(Stegosaurus);
            return DinosList;
        }
    }
}