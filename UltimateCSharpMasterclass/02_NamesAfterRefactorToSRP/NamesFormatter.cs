namespace _02_NamesAfterRefactorToSRP
{
    public class NamesFormatter
    {
        public string Format(List<string> names) =>
        string.Join(Environment.NewLine, names);
    }
}
