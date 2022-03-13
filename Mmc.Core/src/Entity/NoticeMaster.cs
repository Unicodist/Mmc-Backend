using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mmc.Core.Entity
{
    public class NoticeMaster
    {
        public long Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Body { get; set; }
        public string? NoticePicture { get; set; }
    }
}
