using EjercicioPatronFactory.Fabricas;

IFactory factory = new Factory();

factory.buildPcPortatil(1, "Windows", 8, "500 GB");

factory.buildPcMesa(2, "Windows", 16, "1TB", "Power Group", "Genus", "LG"); 