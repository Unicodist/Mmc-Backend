using Mechi.Backend.ApiModel.Notice;

namespace Mechi.Backend.ViewModel.Notice;

public class GridQueryModel
{
    public int current { get; set; }
    public int rowCount { get; set; }
    public string searchPhrase { get; set; }
    public long total { get; set; }
    public IEnumerable<object> rows { get; set; }

    public GridQueryModel Fill(IEnumerable<object> obj)
    {
        rows = obj;
        return this;
    }
}
