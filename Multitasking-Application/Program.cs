using System;

namespace aplicacion
{
    class Program
    {
        //arreglos contactos
        static string[] nombres = new string[0];
        static string[] apellidos = new string[0];
        static long[] telefonos = new long[0];
        static string[] direcciones = new string[0];
        static string[] correos = new string[0];

        //arreglos eventos
        static string[] nombreseventos = new string[0];
        static string[] fechas = new string[0];
        static string[] horas = new string[0];
        static string[] lugares = new string[0];

        static void Main(string[] args)
        {
            dynamic eleccion = 0;

            do
            {

                Console.Clear();
                Console.WriteLine("Elija la seccion deseada para acceder: ");
                Console.WriteLine("Agenda Electronica[1] - Utilitarios[2] - Salir Del Programa[0]");
                Console.WriteLine();
                Console.Write("eleccion: "); eleccion = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (eleccion)
                {

                    case 1:

                        Console.WriteLine("Estas en la seccion de agenda electronica para elegir servicios escoger con un numero: ");
                        Console.WriteLine("Contactos[1] - Eventos[2]");
                        Console.WriteLine();
                        Console.Write("eleccion: "); eleccion = int.Parse(Console.ReadLine());

                        Console.Clear();

                        if (eleccion == 1)
                        {


                            Console.WriteLine("Elija que desea hacer con la opcion contactos: ");
                            Console.WriteLine("Guardar contacto[1] - Buscar contacto[2] - Editar contacto[3] - Borrar contacto[4]");
                            Console.WriteLine();
                            Console.Write("eleccion: "); eleccion = int.Parse(Console.ReadLine());

                            Console.Clear();

                            switch (eleccion)
                            {
                                case 1:
                                    GuardarContacto();
                                    break;

                                case 2:
                                    BuscarContacto();
                                    break;

                                case 3:
                                    EditarContacto();
                                    break;

                                case 4:
                                    BorrarContacto();

                                    break;

                                default:
                                    Console.WriteLine("Eleccion erronea");
                                    Console.ReadKey();
                                    break;
                            }
                        }
                        else
                            if (eleccion == 2)
                        {


                            Console.WriteLine("Elija con la letra inicial que desea hacer con la opcion eventos:");
                            Console.WriteLine("Crear evento[C] - Buscar evento[B] - Modificar evento[M] - Eliminar evento[E]");
                            Console.WriteLine();
                            Console.Write("eleccion: "); eleccion = char.Parse(Console.ReadLine());
                            eleccion = char.ToUpper(eleccion);

                            Console.Clear();

                            switch (eleccion)
                            {
                                case 'C':
                                    CrearEvento();
                                    break;

                                case 'B':
                                    BuscarEvento();
                                    break;

                                case 'M':
                                    ModificarEvento();
                                    break;

                                case 'E':
                                    EliminarEvento();
                                    break;

                                default:
                                    Console.WriteLine("Eleccion erronea!!!");
                                    Console.ReadKey();
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Opcion incorrecta!");
                            Console.ReadKey();
                        }

                        break;

                    case 2:

                        Console.WriteLine("Para acceder a los siguientes servicios de esta seccion elija la opcion deseada: ");
                        Console.WriteLine("Conversores De Unidades[1] - Calculadora[2]");
                        Console.WriteLine();
                        Console.Write("eleccion: "); eleccion = int.Parse(Console.ReadLine());
                        Console.Clear();

                        if (eleccion == 1)
                        {

                            Console.WriteLine("Elija cual conversor de unidades desea utilizar: ");
                            Console.WriteLine("Conversor de Temperaturas[1] - Conversor de Monedas[2]");
                            Console.WriteLine();
                            Console.Write("Eleccion: "); eleccion = int.Parse(Console.ReadLine());
                            Console.Clear();

                            switch (eleccion)
                            {
                                case 1:
                                    Console.WriteLine("Elija el tipo de temperatura: ");
                                    Console.WriteLine("Celcius°C [1] - Fahrenheit°F [2] - Kelvin°K [3]");
                                    Console.WriteLine();
                                    Console.Write("Eleccion: "); eleccion = int.Parse(Console.ReadLine());
                                    Console.Clear();

                                    switch (eleccion)
                                    {
                                        case 1:
                                            ConversionCelcius();
                                            break;

                                        case 2:
                                            ConversionFahrenheit();
                                            break;

                                        case 3:
                                            ConversionKelvin();
                                            break;

                                        default:
                                            Console.Write("Opcion Incorrecta!");
                                            Console.ReadKey();
                                            break;
                                    }

                                    break;

                                case 2:
                                    Console.WriteLine("Elija el tipo de moneda: ");
                                    Console.WriteLine("PesosRD$ [P] - DolaresUS$ [D] - EurosEUR[E]");
                                    Console.WriteLine();
                                    Console.Write("Eleccion: "); eleccion = char.Parse(Console.ReadLine());
                                    eleccion = char.ToUpper(eleccion);

                                    Console.Clear();

                                    switch (eleccion)
                                    {
                                        case 'P':
                                            ConversionPesos();
                                            break;

                                        case 'D':
                                            ConversionDolares();
                                            break;

                                        case 'E':
                                            ConversionEuros();
                                            break;

                                        default:
                                            Console.Write("Letra Equivocada!");
                                            Console.ReadKey();
                                            break;
                                    }
                                    break;

                                default:
                                    Console.Write("Opcion Incorrecta!");
                                    Console.ReadKey();
                                    break;

                            }


                        }
                        else
                            if (eleccion == 2)

                        {

                            Console.Write("Ingresa el primer numero para calcular: ");
                            int n1 = int.Parse(Console.ReadLine());

                            Console.Write("Ingresa el segundo numero para calcular: ");
                            int n2 = int.Parse(Console.ReadLine());
                            Console.Clear();

                            Console.WriteLine("Elija con la letra inicial la operacion deseada: ");
                            Console.WriteLine("Sumar[S] - Restar[R] - Multiplicar[M] - Dividir[D]");
                            Console.WriteLine();
                            Console.Write("Eleccion: "); eleccion = char.Parse(Console.ReadLine());
                            eleccion = char.ToUpper(eleccion);
                            Console.Clear();
                            int resultado;

                            switch (eleccion)
                            {
                                case 'S':
                                    resultado = Sumar(n1, n2);
                                    Console.Write("La suma de los dos numeros es: " + resultado);
                                    Console.ReadKey();
                                    break;

                                case 'R':
                                    resultado = Restar(n1, n2);
                                    Console.Write("La resta de los dos numeros es: " + resultado);
                                    Console.ReadKey();
                                    break;

                                case 'M':
                                    resultado = Multiplicar(n1, n2);
                                    Console.Write("La multiplicacion de los dos numeros es: " + resultado);
                                    Console.ReadKey();
                                    break;

                                case 'D':
                                    resultado = Dividir(n1, n2);
                                    Console.Write("La division de los dos numeros es: " + resultado);
                                    Console.ReadKey();
                                    break;

                                default:
                                    Console.Write("Letra equivocada!!!");
                                    Console.ReadKey();
                                    break;
                            }


                        }
                        else
                        {
                            Console.WriteLine("Opcion incorrecta!");
                            Console.ReadKey();
                        }
                        break;

                    case 0:
                        Console.WriteLine("saliendo del programa...");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;

                    default:

                        Console.WriteLine("Opcion incorrecta!");
                        Console.ReadKey();
                        break;
                }


            } while (eleccion != 0);
        }



        //CONTACTOS.....

        static void GuardarContacto()
        {
            Console.Write("Digite la cantidad de contactos que desea almacenar: ");
            int cantidad = int.Parse(Console.ReadLine());
            Console.Clear();

            nombres = new string[cantidad];
            apellidos = new string[cantidad];
            telefonos = new long[cantidad];
            direcciones = new string[cantidad];
            correos = new string[cantidad];


            Console.WriteLine("Digite la informacion de los contactos:");
            Console.WriteLine();
            int contador = 1;

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Contacto " + "#" + contador++ + ":");
                Console.WriteLine();
                Console.Write("Nombre: "); nombres[i] = Console.ReadLine().ToUpper();
                Console.Write("Apellido: "); apellidos[i] = Console.ReadLine();
                Console.Write("Telefono: "); telefonos[i] = long.Parse(Console.ReadLine());
                Console.Write("Direccion: "); direcciones[i] = Console.ReadLine();
                Console.Write("Correo electronico: "); correos[i] = Console.ReadLine();
                Console.WriteLine();
            }

            Console.Clear();
            Console.Write("Los contactos se han guardado satisfactoriamente!");
            Console.ReadKey();


        }


        static void BuscarContacto()
        {

            Console.Write("Ingresa el nombre del contacto que quieres buscar: ");
            string busqueda = Console.ReadLine().ToUpper();
            int i = 0;

            foreach (string nombre in nombres)
            {

                if (busqueda == nombre)
                {
                    Console.WriteLine();
                    Console.WriteLine("Contacto encontrado!");
                    Console.WriteLine();
                    Console.WriteLine("Nombre: " + nombres[i]);
                    Console.WriteLine("Apellido: " + apellidos[i]);
                    Console.WriteLine("Telefono: " + telefonos[i]);
                    Console.WriteLine("Direccion: " + direcciones[i]);
                    Console.WriteLine("Correo electronico: " + correos[i]);

                    Console.ReadKey();
                    break;
                }

                i++;

                if (i != nombres.Length)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("El contacto no existe!");
                    Console.ReadKey();
                }

            }

        }

        static void EditarContacto()
        {
            Console.Write("Escribe el nombre del contacto que vas a editar: ");
            string edicion = Console.ReadLine().ToUpper();
            int i = 0;

            Console.Clear();

            foreach (string nombre in nombres)
            {
                if (edicion == nombre)
                {

                    Console.WriteLine("Elige cual dato deseas editar del contacto:");
                    Console.WriteLine("Nombre[1] - Apellido[2] - Telefono[3] - Direccion[4] - E-mail[5]");
                    int eleccion = int.Parse(Console.ReadLine());

                    Console.Clear();

                    switch (eleccion)
                    {
                        case 1:
                            Console.Write("Escribe el nuevo nombre: ");
                            nombres[i] = Console.ReadLine().ToUpper();
                            Console.WriteLine();
                            Console.WriteLine("Se ha editado el nombre exitosamente!!!");
                            Console.ReadKey();
                            break;

                        case 2:
                            Console.Write("Escribe el nuevo apellido: ");
                            apellidos[i] = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("Se ha editado el apellido exitosamente!!!");
                            Console.ReadKey();
                            break;

                        case 3:
                            Console.Write("Escribe el nuevo telefono: ");
                            telefonos[i] = long.Parse(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine("Se ha editado el telefono exitosamente!!!");
                            Console.ReadKey();
                            break;

                        case 4:
                            Console.Write("Escribe la nueva direccion: ");
                            direcciones[i] = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("Se ha editado la direccion exitosamente!!!");
                            Console.ReadKey();
                            break;

                        case 5:
                            Console.Write("Escribe el nuevo E-mail: ");
                            correos[i] = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("Se ha editado el E-mail exitosamente!!!");
                            Console.ReadKey();
                            break;

                        default:
                            Console.WriteLine("Opcion incorrecta");
                            Console.ReadKey();
                            break;

                    }
                    break;

                }

                i++;
                if (i != nombres.Length)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("El contacto no existe!");
                    Console.ReadKey();
                }

            }

        }

        static void BorrarContacto()
        {
            Console.Write("Escribe el nombre del contacto que quiere borrar: ");
            string eliminacion = Console.ReadLine().ToUpper();
            int i = 0;
            foreach (string nombre in nombres)
            {
                if (nombre == eliminacion)
                {
                    Array.Clear(nombres, i, 1);
                    Array.Clear(apellidos, i, 1);
                    Array.Clear(telefonos, i, 1);
                    Array.Clear(direcciones, i, 1);
                    Array.Clear(correos, i, 1);

                    Console.WriteLine();
                    Console.WriteLine("Tu contacto se ha eliminado por completo!!!");
                    Console.ReadKey();
                    break;
                }
                i++;

                if (i != nombres.Length)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("El contacto no existe!");
                    Console.ReadKey();
                }

            }

        }


        //EVENTOS....

        static void CrearEvento()
        {

            Console.Write("Introduzca la cantidad de eventos que desea crear: ");
            int cantidad = int.Parse(Console.ReadLine());

            nombreseventos = new string[cantidad];
            fechas = new string[cantidad];
            horas = new string[cantidad];
            lugares = new string[cantidad];

            Console.WriteLine();
            int contador = 1;

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Evento " + "#" + contador++ + ":");
                Console.WriteLine();
                Console.Write("Nombre del evento: "); nombreseventos[i] = Console.ReadLine().ToUpper();
                Console.Write("Fecha: "); fechas[i] = Console.ReadLine();
                Console.Write("Hora: "); horas[i] = Console.ReadLine();
                Console.Write("Lugar: "); lugares[i] = Console.ReadLine();
                Console.WriteLine();
            }

            Console.Clear();
            Console.Write("Los eventos se han guardado satisfactoriamente!");
            Console.ReadKey();
        }

        static void BuscarEvento()
        {

            Console.Write("Ingresa el nombre del evento que quieres buscar: ");
            string busqueda = Console.ReadLine().ToUpper();

            Console.WriteLine();
            int i = 0;

            foreach (string nombre in nombreseventos)
            {
                if (busqueda == nombre)
                {
                    Console.WriteLine("Evento encontrado!");
                    Console.WriteLine();
                    Console.WriteLine("Nombre del evento: " + nombreseventos[i]);
                    Console.WriteLine("Fecha: " + fechas[i]);
                    Console.WriteLine("Hora: " + horas[i]);
                    Console.WriteLine("Lugar: " + lugares[i]);
                    Console.ReadKey();
                    break;
                }
                i++;

                if (i != nombreseventos.Length)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("El evento no existe!");
                    Console.ReadKey();

                }
            }
        }


        static void ModificarEvento()
        {
            Console.Write("Digite el nombre del evento que desea editar: ");
            string edicion = Console.ReadLine().ToUpper();
            int i = 0;

            foreach (string nombre in nombreseventos)
            {
                if (edicion == nombre)
                {
                    Console.Clear();
                    Console.WriteLine("Elija cual valor del evento desea editar: ");
                    Console.WriteLine("Nombre del Evento[1] - Fecha[2] - Hora[3] - Lugar[4]");
                    Console.WriteLine();
                    Console.Write("Eleccion: "); int eleccion = int.Parse(Console.ReadLine());

                    Console.Clear();

                    switch (eleccion)
                    {
                        case 1:
                            Console.Write("Introduce el nuevo nombre del evento: ");
                            nombreseventos[i] = Console.ReadLine().ToUpper();
                            Console.WriteLine();
                            Console.WriteLine("El nombre del evento se cambio satisfactoriamente!!!");
                            Console.ReadKey();
                            break;

                        case 2:
                            Console.Write("Introduce la nueva fecha del evento: ");
                            fechas[i] = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("La fecha del evento se cambio satisfactoriamente!!!");
                            Console.ReadKey();
                            break;

                        case 3:
                            Console.Write("Introduce la nueva hora del evento: ");
                            horas[i] = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("La hora del evento se cambio satisfactoriamente!!!");
                            Console.ReadKey();
                            break;

                        case 4:
                            Console.Write("Introduce el nuevo lugar del evento: ");
                            lugares[i] = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("El lugar del evento se cambio satisfactoriamente!!!");
                            Console.ReadKey();
                            break;

                        default:
                            Console.WriteLine("Eleccion equivocada!");
                            Console.ReadKey();
                            break;
                    }

                }
                i++;

            }

        }


        static void EliminarEvento()
        {
            Console.Write("Escriba el nombre del evento para eliminarlo: ");
            string eliminacion = Console.ReadLine().ToUpper();
            Console.WriteLine();

            int i = 0;
            foreach (string nombre in nombreseventos)
            {
                if (eliminacion == nombre)
                {
                    Array.Clear(nombreseventos, i, 1);
                    Array.Clear(fechas, i, 1);
                    Array.Clear(horas, i, 1);
                    Array.Clear(lugares, i, 1);

                    Console.WriteLine("El evento se ha eliminado completamente!");
                    Console.ReadKey();
                    break;
                }

                i++;
                if (i != nombreseventos.Length)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("El evento no existe!");
                    Console.ReadKey();
                }
            }

        }


        //CONVERSOR DE TEMPERATURAS.....



        static void ConversionCelcius()
        {

            double gradosC, gradosF, gradosK;

            Console.Write("Digita la cantidad de grados celcius para su respectiva conversion: ");
            gradosC = int.Parse(Console.ReadLine());

            Console.WriteLine();

            gradosF = Math.Round((gradosC * 9 / 5) + 32);
            gradosK = Math.Round(gradosC + 273.15);

            Console.WriteLine("Grados Fahrenheit = " + gradosF + "°F");
            Console.WriteLine("Grados Kelvin = " + gradosK + "K");
            Console.ReadKey();

        }


        static void ConversionFahrenheit()
        {

            double gradosC, gradosF, gradosK;

            Console.Write("Digita la cantidad de grados Fahrenheit para su respectiva conversion: ");
            gradosF = int.Parse(Console.ReadLine());
            Console.WriteLine();

            gradosC = Math.Round((gradosF - 32) * 5 / 9);
            gradosK = Math.Round((gradosF - 32) * 5 / 9 + 273.15);

            Console.WriteLine("Grados Celcius = " + gradosC + "°C");
            Console.WriteLine("Grados Kelvin = " + gradosK + "K");
            Console.ReadKey();
        }


        static void ConversionKelvin()
        {

            double gradosC, gradosF, gradosK;

            Console.Write("Digita la cantidad de grados Kelvin para su respectiva conversion: ");
            gradosK = int.Parse(Console.ReadLine());
            Console.WriteLine();


            gradosF = Math.Round((gradosK - 273.15) * 9 / 5 + 32);
            gradosC = Math.Round(gradosK - 273.15);

            Console.WriteLine("Grados Fahrenheit = " + gradosF + "°F");
            Console.WriteLine("Grados Celcius = " + gradosC + "°C");
            Console.ReadKey();
        }


        //CONVERSION DE MONEDAS.....


        static void ConversionPesos()
        {

            double pesos, dolares, euros;

            Console.Write("Ingresa la cantidad de pesos RD$ para su respectiva conversion: ");
            pesos = int.Parse(Console.ReadLine());
            Console.WriteLine();

            dolares = Math.Round(pesos / 56.81);
            euros = Math.Round(pesos / 64.18);

            Console.WriteLine("Los Pesos en Dolares es = US$ " + dolares);
            Console.WriteLine("Los Pesos en Euros es = EUR€ " + euros);
            Console.ReadKey();
        }

        static void ConversionDolares()
        {

            double pesos, dolares, euros;

            Console.Write("Digita la cantidad de dolares US$ para su respectiva conversion: ");
            dolares = int.Parse(Console.ReadLine());
            Console.WriteLine();

            pesos = (dolares * 56.81);
            euros = (dolares * 0.89);

            Console.WriteLine("Los Dolares en Pesos es = RD$ " + pesos);
            Console.WriteLine("Los Dolares en Euros es = EUR€ " + euros);
            Console.ReadKey();
        }


        static void ConversionEuros()
        {

            double pesos, dolares, euros;

            Console.Write("Digita la cantidad de euros EUR€ para su respectiva conversion: ");
            euros = int.Parse(Console.ReadLine());
            Console.WriteLine();
            dolares = (euros * 1.13);
            pesos = (euros * 64.18);

            Console.WriteLine("Los Euros en Dolares es = US$ " + dolares);
            Console.WriteLine("Los Euros en Pesos es = RD$ " + pesos);
            Console.ReadKey();
        }


        //CALCULADORA....


        static int Sumar(int n1, int n2)
        {
            Console.Clear();
            return n1 + n2;


        }


        static int Restar(int n1, int n2)
        {
            Console.Clear();
            return n1 - n2;
        }


        static int Multiplicar(int n1, int n2)
        {
            Console.Clear();
            return n1 * n2;
        }


        static int Dividir(int n1, int n2)
        {
            Console.Clear();
            return n1 / n2;
        }
    }





}
