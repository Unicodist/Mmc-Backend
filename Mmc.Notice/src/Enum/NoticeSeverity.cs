namespace Mmc.Notice.Enum;

public class NoticeSeverity : BaseEnum
{
    protected NoticeSeverity(int id, string? value) : base(id, value)
    {
    }
    private const string _low  = "Low";
    private const string _medium = "Medium";
    private const string _veryImportant = "Very Important";

    public static readonly NoticeSeverity Low = new(1, _low);
    public static readonly NoticeSeverity Medium = new(2, _medium);
    public static readonly NoticeSeverity VeryImportant = new(3, _veryImportant);
}
