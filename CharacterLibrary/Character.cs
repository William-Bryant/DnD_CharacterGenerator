using System;
using System.Text;
using System.Collections.Generic;
namespace CharacterLibrary
{
    public class Character
    {
        public Character()
        {
            _strength = 3;
            _intelligence = 3;
            _wisdom = 3;
            _dexterity = 3;
            _constitution = 3;
            _charisma = 3;

            randomNames = new string[3] { "Thor", "Iron Man", "Captain America" };

            Inventory = new List<InventoryItem>();
        }

        public Character(string name)
        {
            CharacterName = name;
        }

        public Character(string name, int str, int wis, int dex)
        {
            CharacterName = name;
            _strength = str;
            _wisdom = wis;
            _dexterity = dex;
        }
        private string[] randomNames;
        private Random rnd = new Random();

        public string CharacterName { get; set; }

        private int _strength;
        public int Strength
        {
            get { return _strength; }
            set
            {
                if (value >= 3 && value <= 18)
                {
                    _strength = value;
                }
                else
                {
                    throw new Exception("Strength must be between 3 and 18");
                }
            }
        }
        private int _intelligence;

        public int Intelligence
        {
            get { return _intelligence; }
            set
            {
                if (value >= 3 && value <= 18)
                {
                    _intelligence = value;
                }
                else
                {
                    throw new Exception("Intelligence must be between 3 and 18");
                }
            }
        }
        private int _wisdom;
        public int Wisdom
        {
            get { return _wisdom; }
            set
            {
                if (value >= 3 && value <= 18)
                {
                    _wisdom = value;
                }
                else
                {
                    throw new Exception("Wisdom must be between 3 and 18");
                }
            }
        }

        private int _dexterity;
        public int Dexterity
        {
            get { return _dexterity; }
            set
            {
                if (value >= 3 && value <= 18)
                {
                    _dexterity = value;
                }
                else
                {
                    throw new Exception("Dexterity must be between 3 and 18");
                }
            }
        }

        private int _constitution;
        public int Constitution
        {
            get { return _constitution; }
            set
            {
                if (value >= 3 && value <= 18)
                {
                    _constitution = value;
                }
                else
                {
                    throw new Exception("Constitution must be between 3 and 18");
                }
            }
        }

        private int _charisma;
        public int Charisma
        {
            get { return _charisma; }
            set
            {
                if (value >= 3 && value <= 18)
                {
                    _charisma = value;
                }
                else
                {
                    throw new Exception("Charisma must be between 3 and 18");
                }
            }
        }

        public int experiencePoints { get; set; }
        public int level
        {
            get { return int.Parse(Math.Floor(experiencePoints / 1000d).ToString()); }
        }

        public List<InventoryItem> Inventory { get; set; }

        public void AddInventoryitem(InventoryItem item)
        {
            Inventory.Add(item);
        }
        private int RollAttributeScore()
        {
            int score = 0;
            int highestScore = 0;
            for (var i = 0; i < 3; i++)
            {
                score = rnd.Next(3, 18);
                if (score > highestScore)
                {
                    highestScore = score;
                }
            }
            return highestScore;
        }

        public void GenerateCharacter()
        {
            CharacterName = getRandomName();
            Strength = RollAttributeScore();
            Intelligence = RollAttributeScore();
            Wisdom = RollAttributeScore();
            Dexterity = RollAttributeScore();
            Constitution = RollAttributeScore();
            Charisma = RollAttributeScore();

            // starting inventory
            Inventory.Clear();
            var cloak = new InventoryItem("Cloak", 4, 2);
            var staff = new InventoryItem("Staff", 3, 5);
            var torch = new InventoryItem("Torch", 1, 1);

            AddInventoryitem(cloak);
            AddInventoryitem(staff);
            AddInventoryitem(torch);
        }

        public string RecommendClass()
        {
            var recommendation = new StringBuilder();

            if (Strength > 12)
            {
                recommendation.AppendLine("This character would make a good fighter.");
            }
            if (Intelligence > 14)
            {
                recommendation.AppendLine("This character should utilize magic");
            }
            else
            {
                recommendation.AppendLine("Maybe " + CharacterName + " shouldn't be a magic user");
            }
            if (Intelligence > 12 && Wisdom > 12)
            {
                recommendation.AppendLine("This character should wield magic");
            }
            if (Strength > 12 || Dexterity > 12)
            {
                recommendation.AppendLine("This character might be good at dual wielding weapons");

            }

            return recommendation.ToString();
        }

        public override string ToString()
        {

            var characterString = new StringBuilder();
            characterString.AppendLine("Character Name: " + CharacterName);
            characterString.AppendLine("Stength: " + Strength);
            characterString.AppendLine("Intelligence: " + Intelligence);
            characterString.AppendLine("Wisdom: " + Wisdom);
            characterString.AppendLine("Dexterity: " + Dexterity);
            characterString.AppendLine("Constitution: " + Constitution);
            characterString.AppendLine("Charisma: " + Charisma);
            characterString.AppendLine("------------ Inventory ----------");

            foreach (var item in Inventory)
            {
                characterString.AppendLine("Item Name: " + item.ItemName);
                characterString.AppendLine("Weight: " + item.Weight);
                characterString.AppendLine("Cost: " + item.Cost + "gp");
                characterString.AppendLine("----------------------------");
            }

            characterString.AppendLine(RecommendClass());
            return characterString.ToString();
        }

        private string getRandomName()
        {
            var randomIndex = rnd.Next(0, randomNames.Length);
            return randomNames[randomIndex];

        }

    }

}
