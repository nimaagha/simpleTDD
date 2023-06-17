namespace TDD.Models
{
    public class Sum
    {
        public int Execute(string numbers)
        {
            if(numbers == "" || numbers == "0")
            {
                return 0;
            }
            if(numbers.EndsWith(','))
            {
                numbers = numbers.Substring(0, numbers.Length - 1);
            }
            string[] stringNumbers = numbers.Split(',');
            int[] intNumbers = Array.ConvertAll(stringNumbers, s => int.Parse(s));
            return intNumbers.Sum();
        }
    }
}
