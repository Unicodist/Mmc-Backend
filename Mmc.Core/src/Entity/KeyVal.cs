namespace Mmc.Core.Entity;

public class KeyVal
{
    public long Id { get; set; }
    public string Key { get; set; }
    public string Value { get; set; }
    public string Group { get; set; }

    public void SetValue(string value)
    {
        Value = value;
    }
}