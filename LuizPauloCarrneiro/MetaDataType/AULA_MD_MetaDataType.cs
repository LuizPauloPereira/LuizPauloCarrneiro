using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LuizPauloCarrneiro.Models
{
    [MetadataType(typeof(AULA_MD_MetaDataType))]
    public partial class AULA_MD { }


    public partial class AULA_MD_MetaDataType
    {
        [DisplayName("Código da aula")]
        [DataType(DataType.Custom)]
        public int AulaId { get; set; }

        [DisplayName("Descrição da aula")]
        [Required(ErrorMessage = "este campo é obrigatório")]
        [StringLength(50, MinimumLength =10)]
        public string AulaDescricao { get; set; }
    }
}