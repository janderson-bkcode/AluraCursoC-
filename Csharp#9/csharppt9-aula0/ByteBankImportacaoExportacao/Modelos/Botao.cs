using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao.Modelos
{
    class Botao
    {
        #region Propriedades

        
        public string Texto { get; set; }
        public int cor { get; set; }
        #endregion

    }
    #region Enum
    enum CoresBotao
    {
        Azul,
        Vermelho,
        Verde
    }

    // Pode se atribuir valores padrões ao Enum 
    enum CoresBotao2
    {
        Azul = 128,
        Vermelho= 256,
        Verde = 512
    }
    //static class Cores Desnecessário criar uma classe para definir propriedades
    //{
    //    public static readonly string Azul = "azul";
    //    public static readonly string Vermelho = "vermelho";
    //    public static readonly string Verde = "verde";
    //}
    #endregion

}
