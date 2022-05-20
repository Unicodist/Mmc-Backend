namespace Mmc.Core.Entity;

public class KeyVal
{
    public string Key { get; set; }
    public string Value { get; set; }

    public void SetValue(string value)
    {
        Value = value;
    }
}