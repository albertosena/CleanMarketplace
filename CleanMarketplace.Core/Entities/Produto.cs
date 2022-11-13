using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMarketplace.Core.Entities
{
    public class Produto
    {
        public int? Id_Produto { get; set; }

        public int Id_Colecao { get; set; }

        public int Id_Categoria { get; set; }

        public int Desconto { get; set; }

        public int Preco { get; set; }

        public string Nome_Produto { get; set; }

        public string Descricao { get; set; }

        public string Url_Produto { get; set; }

        public int Estoque { get; set; }
    }
}
