using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mmc.Core.Entity
{
    public class NoticeMaster
    {
        public long NoticeMasterId { get; set; }
        public string NoticeMasterTitle { get; set; } = null!;
        public string? NoticeMasterBody { get; set; }
        public string? NoticeMasterNoticePicture { get; set; }
        
        public virtual UserMaster NoticeMasterAuthor { get; set; }
    }
}
