namespace TheSlum.Items
{
    class Injection : Bonus
    {
        public Injection(string id)
            : base(id, 200, 0, 0, 3)
        {

        }

        public int Timeout { get; set; }

        public int Countdown { get; set; }

        public bool HasTimedOut { get; set; }
    }
}
