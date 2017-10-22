using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelixSite.Foundation.Gallery.Models;

namespace HelixSite.Feature.HomeGallery.Models
{
    class GalleryViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
       public IEnumerable<IGalleryItem> GalleryItems { get; set; }

    }
}
