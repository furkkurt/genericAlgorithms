namespace activity5
{
    public class IEqualsPredicate
    {
        public bool CompareTo(object a, object b)
        {
            return a.Equals(b);
        }
        public bool CompareToStartsWith(string a, string b)
        {
            return a.StartsWith(b);
        }
        public bool CompareToEndsWith(string a, string b)
        {
            return a.EndsWith(b);
        }
        public bool CompareToContaines(string a, string b)
        {
            return a.Contains(b);
        }
    }
}