namespace TheSlum.Characters
{
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;

    class Healer : Character, IHeal
    {
        private int healingPoints;

        public Healer(string id, int x, int y, int healthPoints, int defensePoints, Team team, int range, int healingPoints)
            : base(id, x, y, healthPoints, defensePoints, team, range)
        {
            this.HealingPoints = healingPoints;
        }

        public int HealingPoints
        {
            get
            {
                return this.healingPoints;
            }
            set
            {
                this.healingPoints = value;
            }
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            return targetsList.OrderBy(c => c.HealthPoints).FirstOrDefault(c => !c.Equals(this));
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
        }
    }
}
