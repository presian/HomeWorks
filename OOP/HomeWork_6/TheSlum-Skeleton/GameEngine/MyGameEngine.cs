using System;
using System.Linq;
using TheSlum.Characters;
using TheSlum.Items;

namespace TheSlum.GameEngine
{
    public class MyGameEngine : Engine
    {
        public MyGameEngine() : base()
        {
        }
        private new void AddItem(string[] inputParams)
        {
            Item item;
            switch (inputParams[2].ToLower())
            {
                case "axe":
                    item = new Axe(inputParams[3]);
                    break;
                case "shield":
                    item = new Shield(inputParams[3]);
                    break;
                case "injection":
                    item = new Injection(inputParams[3]);
                    break;
                case "pill":
                    item = new Pill(inputParams[3]);
                    break;
                default:
                    throw new ApplicationException("No such kind of item.");
            }

            var character = this.characterList.First(c => c.Id == inputParams[1]);
            character.AddToInventory(item);
        }

        protected override void CreateCharacter(string[] inputParams)
        {
            Character character;
            Team team;

            switch (inputParams[5].ToLower())
            {
                case "red":
                    team = Team.Red;
                    break;
                case "blue":
                    team = Team.Blue;
                    break;
                default: throw new Exception("This teams are only red and blue!");
            }

            switch (inputParams[1].ToLower())
            {
                case "mage":
                    character = new Mage(inputParams[2], int.Parse(inputParams[3]), int.Parse(inputParams[4]), 100, 20, team, 3, 25);
                    break;
                case "warrior":
                    character = new Warrior(inputParams[2], int.Parse(inputParams[3]), int.Parse(inputParams[4]), 100, 50, team, 7, 50);
                    break;
                case "healer":
                    character = new Healer(inputParams[2], int.Parse(inputParams[3]), int.Parse(inputParams[4]), 100, 0, team, 3, 50);
                    break;
                default: throw new Exception("No such type hero");
            }

            this.characterList.Add(character);
        }

        protected override void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "create":
                    this.CreateCharacter(inputParams);
                    break;
                case "add":
                    this.AddItem(inputParams);
                    break;
                default:
                    base.ExecuteCommand(inputParams);
                    break;
            }
        }
    }
}
