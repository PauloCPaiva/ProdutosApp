namespace ProdutosApp.API.Dtos
{
    /// <summary>
    /// DTO para saída de dados de produtos na API.
    /// </summary>
    public record ProdutoResponse(
        Guid Id,                //Identificador único do produto
        string Nome,            //Nome do produto
        string Descricao,       //Descrição do produto
        decimal Preco,          //Preço do produto
        int Quantidade,         //Quantidade em estoque
        DateTime DataCriacao    //Data de criação do produto
        );
}
