using API_Champions_Manager.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Champions_Manager.Model
{
    [Table("tb_award")]
    public class Award : BaseEntity
    {
        [Column("name")]
        public string Name { get; set; }
        [Column("origin")]
        public string Origin { get; set; }
        [Column("organization")]
        public string Organization { get; set; }
        [Column("national")]
        public bool National { get; set; }
    }
}
