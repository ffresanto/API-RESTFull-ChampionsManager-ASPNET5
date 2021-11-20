using System.ComponentModel.DataAnnotations.Schema;

namespace API_Champions_Manager.Model
{
    [Table("tb_award")]
    public class Award
    {
        [Column("id")]
        public long Id { get; set; }
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
