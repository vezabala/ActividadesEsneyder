using ActividadPolimorfismo;

Entidad apple = new Apple("Pantalla OLED Apple", 900000);
apple.encenderPantalla();
apple.apagarPantalla();
var apple1 = (Apple)apple;
apple1.Comprar();
Console.WriteLine("\n----------------------------\n");
Entidad samsung = new Samsung("Pantalla Quad Samsung", 1500000);
samsung.encenderPantalla();
samsung.apagarPantalla();
var samsung1 = (Samsung)samsung;
samsung1.Comprar();