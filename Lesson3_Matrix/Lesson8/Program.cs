using Lesson8;

Vegetable[] mass = new Vegetable[5] { onion, cucumber, tomato, potato, pumpkin };
Inventory inventory = new Inventory(mass);

inventory[0] = new Vegetable { Name = "pepero" };

inventory.Price();


Console.WriteLine("\nFruits\n");

Fruit apple = new Fruit("apple", 0.67, 1);
Fruit pear = new Fruit("pear", 2.74, 2);
Fruit banana = new Fruit("banana", 4.09, 3);
Fruit coconut = new Fruit("coconut", 0.99, 4);
Fruit watermelon = new Fruit("watermelon", 1.23, 5);

Fruit[] massiv = new Fruit[5] { apple, pear, banana, coconut, watermelon };
Invent invent = new Invent(massiv);
invent.Result();