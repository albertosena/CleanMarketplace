using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMarketplace.Sql.Queries
{
    public static class ProdutoQueries
    {
        public static string AllProduto => "SELECT * FROM public2.\"PRODUTO\"";

        public static string ProdutoById => "SELECT * FROM public2.\"PRODUTO\" t WHERE t.\"ID_PRODUTO\" = @ID_PRODUTO";

        public static string AddProduto => @"INSERT INTO public2.""PRODUTO"" (""ID_PRODUTO"", 
                                                                    ""NOME_PRODUTO"", 
                                                                    ""ID_CATEGORIA"", 
                                                                    ""DESCRICAO"", 
                                                                    ""DESCONTO"", 
                                                                    ""ESTOQUE"", 
                                                                    ""PRECO"", 
                                                                    ""URL_PRODUTO"")
                                                            VALUES (@ID_PRODUTO, 
                                                                    @NOME_PRODUTO, 
                                                                    @ID_CATEGORIA, 
                                                                    @DESCRICAO, 
                                                                    @DESCONTO, 
                                                                    @ESTOQUE, 
                                                                    @PRECO, 
                                                                    @URL_PRODUTO)";

        public static string UpdateProduto => @"UPDATE public2.""PRODUTO""
                                                   SET ""NOME_PRODUTO"" = @NOME_PRODUTO, 
                                                       ""ID_CATEGORIA"" = @ID_CATEGORIA, 
                                                       ""DESCRICAO"" = @DESCRICAO, 
                                                       ""DESCONTO"" = @DESCONTO, 
                                                       ""ESTOQUE"" = @ESTOQUE, 
                                                       ""PRECO"" = @PRECO, 
                                                       ""URL_PRODUTO"" = @URL_PRODUTO
                                                 WHERE ""ID_PRODUTO"" = @ID_PRODUTO";

        public static string DeleteProduto => "DELETE FROM public2.\"PRODUTO\" WHERE \"ID_PRODUTO\" = @ID_PRODUTO";



    }
}
