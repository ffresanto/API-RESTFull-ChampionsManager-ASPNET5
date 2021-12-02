using System.Collections.Generic;

namespace API_Champions_Manager.HyperMedia.Abstract
{
    public interface ISupportsHyperMedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}
