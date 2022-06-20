using Mechi.Backend.ApiModel.Notice;

namespace Mechi.Backend.ViewModel.Notice;

public class NoticeGridQueryModel
{
    public int current { get; set; }
    public int rowCount { get; set; }
    public string searchPhrase { get; set; }
    public long total { get; set; }
    public IEnumerable<NoticeResponseApiModel> rows { get; set; }

    public NoticeGridQueryModel Fill(IEnumerable<NoticeResponseApiModel> obj)
    {
        rows = obj;
        return this;
    }
}