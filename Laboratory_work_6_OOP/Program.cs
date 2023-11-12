namespace Laboratory_work_6_OOP
{
    class Actor
    {
        public string Name { get; set; }
        public void Event1Hendler()
        {
            Console.WriteLine($"Актор {Name} гримується");
        }
        public void Event2Hendler()
        {
            Console.WriteLine($"Актор {Name} підготувався.");
        }
        public void Event3Hendler()
        {
            Console.WriteLine($"Актор {Name} на сцену.");
        }
    }
    class Spectator
    {
        public string Name { get; set; }
        public void Event1Hendler()
        {
            Console.WriteLine($"Глядач {Name} зайшов у театр");
        }
        public void Event2Hendler()
        {
            Console.WriteLine($"Глядач {Name} здає одяг у гардероб.");
        }
        public void Event3Hendler()
        {
            Console.WriteLine($"Глядач {Name} зайшов до зали.");
        }
    }
    class Bell
    {
        public int N { get; set; }
        public delegate void Events();
        public event Events Event1;
        public event Events Event2;
        public event Events Event3;
        public void Event()
        {
            switch(N)
            {
                case 1:
                    Event1();
                    break;
                case 2:
                    Event2();
                    break;
                case 3:
                    Event3();
                    break;
            }
        }
        public void Event1Hendler()
        {
            Console.WriteLine("Дзвінок 1. Увага!!");
        }
        public void Event2Hendler()
        {
            Console.WriteLine("Дзвінок 2. Підготуватися!");
        }
        public void Event3Hendler()
        {
            Console.WriteLine("Дзвінок 3. Вистава починається.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Actor actor = new Actor() { Name = "Ivan" };
            Spectator spectator = new Spectator() { Name = "Dan" };
            Bell bell1 = new Bell() { N = 1 };
            bell1.Event1 += bell1.Event1Hendler;
            bell1.Event1 += actor.Event1Hendler;
            bell1.Event1 += spectator.Event1Hendler;
            bell1.Event();
            Bell bell2 = new Bell() { N = 2 };
            bell2.Event2 += bell2.Event2Hendler;
            bell2.Event2 += actor.Event2Hendler;
            bell2.Event2 += spectator.Event2Hendler;
            bell2.Event();
            Bell bell3 = new Bell() { N = 3 };
            bell3.Event3 += bell3.Event3Hendler;
            bell3.Event3 += actor.Event3Hendler;
            bell3.Event3 += spectator.Event3Hendler;
            bell3.Event();
        }
    }
}