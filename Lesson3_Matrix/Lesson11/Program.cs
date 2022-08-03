using Lesson8;

using reporter = System.Console;

Vegetable onion = new Vegetable("onion", 0.67);
Vegetable cucumber = new Vegetable(null, 2.74);
Vegetable tomato = new Vegetable("tomato", 4.09);
Vegetable potato = new Vegetable("potato", 0.99);
Vegetable pumpkin = new Vegetable("pumpkin", 1.23);
Vegetable[] mass = new Vegetable[5] { onion, cucumber, tomato, potato, pumpkin };
Inventory inventory = new Inventory(mass);

inventory[0] = new Vegetable { Name = "pepero" };

inventory.Price();
reporter.WriteLine($"Name our hero is {onion.GetName()}");

Console.WriteLine("\nFruits\n");

Fruit apple = new Fruit("apple", 0.67, 1);
Fruit pear = new Fruit("pear", 2.74, 2);
Fruit banana = new Fruit("banana", 4.09, 3);
Fruit coconut = new Fruit("coconut", 0.99, 4);
Fruit watermelon = new Fruit("watermelon", 1.23, 5);

Fruit[] massiv = new Fruit[5] { apple, pear, banana, coconut, watermelon };
Invent invent = new Invent(massiv);
invent.Result();