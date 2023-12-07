namespace Advent2023
{
    public class DayTwo : DayOne
    {
        public int GetLineValue(Span<char> v)
        {
            var last = int.Parse(v.Reverse().First(x => char.IsDigit(x)).ToString());
            var first = int.Parse(v.First(x => char.IsDigit(x)).ToString());
            return 10 * first + last;
        }
        private short GetValue(int index, Span<char> chars)
        {
            if (char.IsDigit(chars[index]))
            {
                return short.Parse(chars[index].ToString());
            }
            switch (chars[index])
            {
                case 'o':
                case 'O':
                    break;
                case 't' :
                case 'T':
                    break;
                case 'f':
                case 'F':
                    break;
                case 's':
                case 'S':
                    break;
                case 'e':
                case 'E':
                    break;
                case 'n':
                case 'N':
                    break;

            }
        }
    }
}