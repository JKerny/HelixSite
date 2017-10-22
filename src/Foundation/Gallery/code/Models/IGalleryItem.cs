using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelixSite.Foundation.Gallery.Models
{
    public interface IGalleryItem
    {
        Guid Id { get; set; }
        string Title { get; set; }
        string Description { get; set; }
    }
}
