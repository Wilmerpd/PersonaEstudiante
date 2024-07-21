

namespace PersonaEstudiante
{
    public class Person
    {
        public int Edad { get; set; }
        public string Nombre { get; set; }
        public string Ciudad { get; set; }


        
        public Person(string nombre, int edad, string ciudad)
        {
            Nombre = nombre;
            Edad = edad;
            Ciudad = ciudad;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {Nombre} Edad: {Edad}, Ciudad {Ciudad} ");
        }
        public int CalcularEdad() 
        { 
            return Edad;
        }
    }
    public class Estudiante : Person
    {
        public string Carrera { get; set; }
        public string Matricula { get; set; }

        public Estudiante(string nombre, int edad, string ciudad, string carrera, string matricula)
           : base(nombre, edad, ciudad)
        {
            Carrera = carrera;
            Matricula = matricula;
        }
        public void MostrarInformaciones()
        {
            MostrarInfo();
            Console.WriteLine($"Carrera: {Carrera}, Matricula: {Matricula}");
        }

    }

}
