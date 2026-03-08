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

bool acceso = false;
string permiso = "Sin acceso";

switch (rol)
{
    case 1: 
        if (dia >= 1 && dia <= 5)
        {
            if (hora >= 7 && hora <= 18)
            {
                if (carnet == "S")
                {
                    acceso = true;
                    permiso = "Uso académico del laboratorio";
                }
            }
        }
        break;

    case 2: 
        if (carnet == "S")
        {
            acceso = true;
            permiso = "Acceso docente completo";
        }
        break;

    case 3: 
        if (hora >= 7 && hora <= 18)
        {
            acceso = true;
            permiso = "Mantenimiento técnico";
        }
        else
        {
            if (autorizacion == "S")
            {
                acceso = true;
                permiso = "Mantenimiento fuera de horario";
            }
        }
        break;

    case 4: 
        if (autorizacion == "S")
        {
            if (acompanado == "S")
            {
                acceso = true;
                permiso = "Visita supervisada";
            }
        }
        break;

    default:
        Console.WriteLine("Rol inválido.");
        return;
}


if (usb == "S")
{
    if (autorizacion == "S" && acompanado == "S")
    {
        
    }
    else
    {
        acceso = false;
        permiso = "USB no permitido";
    }
}

Console.WriteLine("RESULTADO:");
if (acceso)
{
    Console.WriteLine("Acceso permitido");
    Console.WriteLine("Nivel de permiso: " + permiso);
}
else
{
    Console.WriteLine("Acceso denegado");
    Console.WriteLine("Nivel de permiso: " + permiso);
}