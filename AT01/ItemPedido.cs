namespace AT01
{
    public class ItemPedido
    {
        public ItemPedido(string desc, double valor, int qtd){
            this.descricao = desc;
            this.valor_unitario = valor;
            this.quantidade = qtd;
        }

        public string descricao;

        public double valor_unitario;

        public int quantidade;
    }
}