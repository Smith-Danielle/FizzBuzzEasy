namespace TwistedFizzBuzz
{
    public class Twisted
    {
        public int Start { get; set; }
        public int End { get; set; }
        public List<int> NumberSet { get; set; } = new List<int>();
        public Dictionary<int, string> NameDivisor { get; set; } = new Dictionary<int, string>();

        public List<string> CreateFizzBuzz()
        {
            //List to iterate through.
            List<int> numberSelection = new List<int>();

            //List to fill for final answer.
            List<string> fizzBuzzList = new List<string>();

            //Check if NumberSet is filled. If so, this would mean a set of numbers was entered. Otherwise, a range (Start and End) was entered.
            if (NumberSet.Any())
            {
                numberSelection = NumberSet;
            }
            else
            {
                numberSelection = Enumerable.Range(Start, End).ToList();
            }

            //Fill list.
            for (int i = 0; i < numberSelection.Count(); i++)
            {
                var divisibleGroup = NameDivisor.Where(x => numberSelection[i] % x.Key == 0);
                if (divisibleGroup.Any())
                {
                    fizzBuzzList.Add(string.Join("", divisibleGroup.Select(x => x.Value)));
                }
                else
                {
                    fizzBuzzList.Add($"{numberSelection[i]}");
                }
            }
            return fizzBuzzList;
        }
    }
}