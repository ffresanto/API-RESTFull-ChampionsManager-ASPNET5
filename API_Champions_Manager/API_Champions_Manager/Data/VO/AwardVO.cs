using API_Champions_Manager.HyperMedia;
using API_Champions_Manager.HyperMedia.Abstract;
using API_Champions_Manager.Model.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_Champions_Manager.Data.VO
{
    public class AwardVO : ISupportsHyperMedia
    {
        public long Id { get; set; }
       //[JsonPropertyName("Premio")]
        public string Name { get; set; }
        //[JsonPropertyName("Origem")]
        public string Origin { get; set; }
        //[JsonPropertyName("Organizacao")]
        public string Organization { get; set; }
        //[JsonPropertyName("Nacional")]
        public bool National { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
