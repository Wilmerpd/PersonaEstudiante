using PersonaEstudiante;

Person person = new Person("Wilmer", 19, "Santo Domingo");
person.MostrarInfo();
Console.WriteLine($"Edad en años: {person.CalcularEdad()}");


Estudiante estudiante = new Estudiante("Jose", 12, "San Juan", "Ingeniería de Software", "2024-2022");
estudiante.MostrarInformaciones();