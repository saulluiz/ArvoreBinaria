


BinaryTree b1 = new BinaryTree();
b1.insert(4);
b1.insert(2);
b1.insert(7);
b1.insert(5);
b1.insert(9);
b1.insert(1);




b1.preOrderTraversal();
Console.WriteLine("------------------------");
b1.InOrderTraversal();
Console.WriteLine("altura " + b1.Length());
b1.remove(4);
b1.remove(-7);
b1.remove(9);

    Console.WriteLine("------------------------");
b1.InOrderTraversal();
Console.WriteLine("altura " +b1.Length());

//Console.WriteLine("Menor"+b1.min());
//b1.InOrder();
//Console.WriteLine("------------------------");
//b1.postOrder();
//Console.WriteLine("------------------------");
//b1.OrderLevelTraversal();

