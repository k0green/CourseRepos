using Lesson12_FamilyTree.Models;

Mother Helen = new Mother("Helen", "Female", 44);
Father Sergey = new Father("Sergey", "Male", 44);
Son Egor = new Son("Egor", "Male", 19, Helen, Sergey);
Dauther Yana = new Dauther("Yana", "Female", 12, Helen, Sergey);
Dauther Marta = new Dauther("Marta", "Female", 1, Helen, Sergey);

Helen.AddDaughter(Marta);
Helen.AddDaughter(Yana);
Helen.AddSon(Egor);
Sergey.AddDaughter(Marta);
Sergey.AddDaughter(Yana);
Sergey.AddSon(Egor);

Helen.MotherInfo();
Console.WriteLine("\n");
Sergey.FatherInfo();
Console.WriteLine("\n");
Egor.SonInfo();
Console.WriteLine("\n");
Marta.DaughterInfo();
Console.WriteLine("\n");
Yana.DaughterInfo();