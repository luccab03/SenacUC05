using System.Collections.Generic;

namespace AT01
{
    public static class Pedido
    {
    
        private static List<ItemPedido> pedidos = new List<ItemPedido>();

        public static void addItem(ItemPedido item){
            pedidos.Add(item);
        }

        public static double finalizar(){
            double total = 0;
            foreach(ItemPedido item in pedidos){
                total = total + (item.valor_unitario * item.quantidade);
            }
            return total;
        }

        public static List<ItemPedido> listagem(){
            return pedidos;
        }

    }
}