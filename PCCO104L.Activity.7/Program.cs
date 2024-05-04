namespace PCCO104L.Encapsulation.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Railway MRT = new Railway(60.00, "MRT", 1000);
            MRT.SetLocation("North Avenue");
            MRT.SetOperator("Allen");
            MRT.Speed();

            Railway LRT = new Railway(50.00, "LRT", 800);
            LRT.SetLocation("Baclaran");
            LRT.SetOperator("Daniel");
            LRT.Speed();

            Railway PNR = new Railway(40.00, "PNR", 600);
            PNR.SetLocation("Binan");
            PNR.SetOperator("Denzie");
            PNR.Speed();
        }
    }

    public class Railway
    {
        public string Name { get; set; }
        public int Capacity { get; set; }

        private double _Speed { get; set; }
        private string _Location { get; set; }
        private string _Operator { get; set; }

        public Railway()
        {
            _Location = "Unknown";
            _Operator = "Unknown";
        }

        public Railway(double speed, string name) : this()
        {
            _Speed = speed;
            Name = name;
        }

        public Railway(double speed, string name, int capacity) : this(speed, name)
        {
            Capacity = capacity;
        }

        public void Speed()
        {
            Console.WriteLine($"{Name} - {_Speed} km/h, Capacity: {Capacity}, Location: {_Location}, Operator: {_Operator}");
        }

        public void SetLocation(string location)
        {
            _Location = location;
        }

        public string GetLocation()
        {
            return _Location;
        }

        public void SetOperator(string operatorName)
        {
            _Operator = operatorName;
        }

        public string GetOperator()
        {
            return _Operator;
        }
    }
}