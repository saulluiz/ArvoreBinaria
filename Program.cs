AVLTree b1 = new AVLTree();
string input;
while (true)
{
    System.Console.WriteLine("Digite um numero para inserção,'print' para imprimir a arvore e 'h' para imprimir a altura");
    input = Console.ReadLine();

    switch (input)
    {
        case "print":
            b1.OrderLevelTraversal();
            break;
        case "h" or "H":
            System.Console.WriteLine(b1.Height());
            break;
        default:
            {
                try
                {
                    b1.insert(int.Parse(input));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                break;

            }


    }
}


//Console.WriteLine("Menor"+b1.min());
//b1.InOrder();
//Console.WriteLine("------------------------");
//b1.postOrder();
//Console.WriteLine("------------------------");
//b1.OrderLevelTraversal();

