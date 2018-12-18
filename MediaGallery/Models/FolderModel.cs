using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaGallery.Data;

namespace MediaGallery.Models
{
    public class FolderModel : MediaItem
    {
        public PagedResult<MediaItem> PageThing { get; set; }

        public IList<MediaItem> Items { get; set; }
        public override string Thumbnail
        {
            get
            {
                return "folder.jpg";
            }
            set { }
        }

        public FolderModel()
        {
            Items = new List<MediaItem>();
        }
    }
}
