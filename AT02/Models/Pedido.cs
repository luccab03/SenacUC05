using System.Collections.Generic;

namespace AT02.Models
{
    public class Pedido
    {
        private List<ItemPedido> pedidos = new List<ItemPedido>();

        public void addItem(ItemPedido pedido){
            pedidos.Add(pedido);
        }



        public List<ItemPedido> listar(){
            return pedidos;
        }

        public double finalizar(){
            double total = 0;
            foreach(ItemPedido item in pedidos){
                total = total + (item.ValorUnidade * item.Quantidade);
            }
            return total;
        }
    }
}