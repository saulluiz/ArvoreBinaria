
BinaryTree b1 = new BinaryTree();
b1.insert(1);
b1.insert(2);
b1.insert(5);
b1.insert(7);
b1.insert(4);
b1.insert(3);
b1.insert(6);
b1.InOrder();
Console.WriteLine("------------------------");
b1.postOrder();
Console.WriteLine("------------------------");
b1.OrderLevelTraversal();