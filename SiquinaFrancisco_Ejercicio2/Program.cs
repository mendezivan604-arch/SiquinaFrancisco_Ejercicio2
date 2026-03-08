int rol;
int hora;
int dia;
string carnet;
string autorizacion;
string usb;
string acompanado = "N";

Console.WriteLine("CONTROL DE ACCESO AL LABORATORIO");

Console.WriteLine("Rol:");
Console.WriteLine("1 Estudiante");
Console.WriteLine("2 Docente");
Console.WriteLine("3 Técnico IT");
Console.WriteLine("4 Visitante");
rol = int.Parse(Console.ReadLine());

Console.Write("Hora (0-23): ");
hora = int.Parse(Console.ReadLine());

Console.Write("Día (1-7): ");
dia = int.Parse(Console.ReadLine());

Console.Write("Carnet vigente (S/N): ");
carnet = Console.ReadLine().ToUpper();

Console.Write("Autorización escrita (S/N): ");
autorizacion = Console.ReadLine().ToUpper();

Console.Write("¿Trae USB? (S/N): ");
usb = Console.ReadLine().ToUpper();

if (usb == "S")
{
    Console.Write("¿Está acompañado? (S/N): ");
    acompanado = Console.ReadLine().ToUpper();
}


if (hora < 0 || hora > 23)
{
    Console.WriteLine("Error: hora fuera de rango.");
}

if (dia < 1 || dia > 7)
{
    Console.WriteLine("Error: día fuera de rango.");
}

