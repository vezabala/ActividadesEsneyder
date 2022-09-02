using Actividad6.Entitys.Entity;
using Actividad6.Homes;

//Inscribir perro en la casa
IHome<Dog> house = new House<Dog>();
house.Enroll(new Dog());

//Inscribir gato a la fundacion de animales
IHome<Cat> animalFoundation = new AnimalFoundation<Cat>();
animalFoundation.Enroll(new Cat());