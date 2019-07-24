using System;
namespace webapialmunos.Models
{
    public class Alumno
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public string especialidad { get; set; }

        public Alumno(int id, string nam, string ape, int edad, string espec)
        {
            this.id = id;
            this.nombre = nam;
            this.apellido = ape;
            this.edad = edad;
            this.especialidad = espec;
        }
        //public Product(int id,string nam,string des)
    }
}