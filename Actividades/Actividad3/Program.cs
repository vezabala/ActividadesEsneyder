using Actividad3;
using Actividad3.EjercitoHormigas;
using Actividad3.Hormiguero;
using Actividad3.Tipos;

IHormiguero hormiguero = new HormigueroTierra();

IHormiguero hormigaObrera= new HormigaObrera();

Ejercito ejercito = new Ejercito(hormiguero,hormigaObrera);
