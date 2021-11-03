namespace AdventOfCode.Common

{
    public class InputManager
    {
        private readonly int _year;
    
        public InputManager(int year)
        {
            _year = year;
        }


        public string GetInputDay(int day) => File.ReadAllText(@$"Inputs\{_year}-{day:D2}.txt");
    }
}
