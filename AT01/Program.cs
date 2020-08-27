using System;

namespace AT01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Criar uma classe “ItemPedido” com as propriedades “descricao”, “valor_unitario” e “quantidade”.
            Criar uma classe “Pedido” com uma propriedade privada do tipo lista (List<>) de “ItemPedido” e métodos para incluir item no pedido e para totalizar o pedido – este, retorna um valor Double com o total de todos os itens da lista.
            Inclua também um construtor em “Pedido” para instanciar uma nova lista na propriedade criada.
            Crie um programa em que seja possível informar vários itens de um pedido.
            O usuário informa descrição, valor e quantidade.
            O programa pergunta se deseja inserir novo pedido. Se sim, usuário pode incluir novo pedido. Se não, o programa exibe o total do pedido.
            */
            
            comeco: Console.WriteLine("Qual é o seu pedido?");
            Console.Write("Descrição: ");
            String desc = Console.ReadLine();
            Console.Write("Valor: ");
            double valor = Double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            int qtd = Int32.Parse(Console.ReadLine());
            Pedido.addItem(new ItemPedido(desc, valor, qtd));
            add: Console.WriteLine("Deseja adicionar mais algum item?");
            String resp = Console.ReadLine();
            if(resp == "s" || resp == "Sim"){
                goto comeco;
            } else if(resp == "n" || resp == "Nao"){
                Console.WriteLine("O Seu pedido é: ");
                foreach(ItemPedido a in Pedido.listagem()){
                    Console.WriteLine("Descrição: " + a.descricao + ". Valor: " + a.valor_unitario + ". Quantidade: " + a.quantidade);
                }
                Console.WriteLine("O total do pedido é: " + Pedido.finalizar());
            } else {
                Console.WriteLine("Comando não entendido, por favor use Sim ou Nao");
                goto add;
            }
        }
    }
}
