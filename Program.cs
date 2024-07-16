AVLTree b1 = new AVLTree();
string input;
while (true)
{
    System.Console.WriteLine("Digite um numero para inserção,'print' para imprimir a arvore e 'h' para imprimir a altura.Para chamar a interface de remocao, basta digitar r.Para chamar a interface de pesquisa, digite 's'.");
    input = Console.ReadLine();

    switch (input)
    {
        case "print":
            b1.LevelOrderTraversal();
            break;
        case "h" or "H":
            System.Console.WriteLine(b1.Height());
            break;
        case "r" or "R":
            Console.WriteLine("Digite o elemento que deseja remover:");
            input = Console.ReadLine();
            try
            {
                b1.Remove(int.Parse(input));
            }
            catch(Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
            break;
            case "s":
            Console.WriteLine("Digite o elemento que deseja Pesquisar:");
            input = Console.ReadLine();
             try
            {
                Node node=b1.SearchNode(int.Parse(input));
               if(node==null)
                    System.Console.WriteLine("Valor não encontrado");
                else{
                    Console.WriteLine($"Nó de valor {node.value} presente");
                    //Aqui retorno o nó e utilizo isso para dizer se tenho ou nao o valor na arvora. Entretanto, poderia utilizar essa funcao para realizar operacoes na propria arvore,uma vez que estou retornando o no e nao um valor bool.
                }
            }
            catch(Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
                break;
            
        default:
            {
                try
                {
                    b1.Insert(int.Parse(input));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                break;

            }


    }
}


