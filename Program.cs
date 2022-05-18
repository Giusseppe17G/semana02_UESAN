// See https://aka.ms/new-console-template for more information
using semana02_UESAN;

Console.WriteLine("Hello, World!");


string nombreCurso = "Desarrollo de aplicaciones web 2022-01";
int edad = 22;
double monto = 12.5;

var nombreAlumno = "Luis";
var peso = 60;

//aca se puede crear un listado de personas(ambas formas son iguales)
//List<Persona> listado = new List<Persona>();
var listado = new List<Persona>();

var persona = new Persona();
persona.dni = "123456789";
persona.nombreCompleto = "Luis";
persona.telefono = 985525521;

var persona2 = new Persona("22524155", "Juan", 99501523);

var persona3 = new Persona()
{
    dni = "2551626",
    nombreCompleto = "Pedro",
    telefono = 955224523
};
//ACA SE AGREGAN LAS PERSONAS AL LISTADO
listado.Add(persona);
listado.Add(persona2);
listado.Add(persona3);

//Print listado personas
//el foreach es para recorrer objetos,
//es como un for(si quiero recorrer un
//listado de objetos, si quiero recorrer
//cuantas personas tiene, etc)
foreach (var item in listado) { //listado ese el list persona  y item se convierte en un persona 
    Console.WriteLine(item.dni + " - " + item.nombreCompleto + " - " + item.telefono);
}
//PRIMERA IMAGEN
//PARA HACER BUSQUEDAS(ES COMO SI FUERA UN WHERE A LA BBDD)
var busqueda = listado.Find(x => x.dni == "2551626");
//validar si es null
if (busqueda != null)
    Console.WriteLine(busqueda.dni + " - " + busqueda.nombreCompleto);
else
    Console.WriteLine("No se encontro el registro");

Console.Write("Fin");