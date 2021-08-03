using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Pets
{
    class Bear
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int NumberOfFishEaten { get; private set; }

        // Property with a default value
        public string EducationLevel { get; set; } = "GED";
        public Tiger BestTigerFriend { get; set; }

        // read only property
        // public bool LovesHoney {get;}

        // expression-bodied read only property
        public bool LovesHoney => Name == "Winnie the Pooh";

        public Bear(string name, string type)
        {
            Name = name;
            Type = type;
            EducationLevel = "GED";

            if (name == "Yogi")
            {
                EducationLevel = "Above Average";
            }
        }

        // expression bodied method
        public Bear(string name, string type, string educationLevel) : this(name, type) => EducationLevel = educationLevel;
        //{
        //    EducationLevel = educationLevel;
        //}

        public Bear(string name, string type, string educationLevel, int howManyFish) : this(name, type, educationLevel)


    }
}
