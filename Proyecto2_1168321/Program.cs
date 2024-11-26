using System;

namespace Proyecto2_1168321
{
    class Program
    {
        public static Random r = new Random();
        public static int limiteX_Y = 0, contador = 0, numero1 = 0, numero2 = 0, punteo = 10, posicion_x = 0, posicion_y = 0, obstaculos, enemigos,numero;
        public static string personaje = "(´°_°`)",opcion,opcion_movimiento,opcion_direccion,opcion_tablero, sMarco="#",sVacio="vacio", volver;
        static void Main(string[] args)
        {
            limiteX_Y = 8;
            obstaculos = 25;
            enemigos = 10;
            string[,] nivel1 = new string[limiteX_Y + 2, limiteX_Y + 2];
            cargarnivel(nivel1);
            cargarobstaculos(nivel1);
            cargarenemigos(nivel1);
            cargarestrella(nivel1);
            cargarpersonaje(nivel1);
            mostrarnivel(nivel1);

            limiteX_Y = 10;
            obstaculos = 50;
            enemigos = 15;
            string[,] nivel2 = new string[limiteX_Y + 2, limiteX_Y + 2];
            cargarnivel(nivel2);
            cargarobstaculos(nivel2);
            cargarenemigos(nivel2);
            cargarestrella(nivel2);
            cargarpersonaje(nivel2);
            mostrarnivel(nivel2);

            limiteX_Y = 12;
            obstaculos = 70;
            enemigos = 30;
            string[,] nivel3 = new string[limiteX_Y + 2, limiteX_Y + 2];
            cargarnivel(nivel3);
            cargarobstaculos(nivel3);
            cargarenemigos(nivel3);
            cargarestrella(nivel3);
            cargarpersonaje(nivel3);
            mostrarnivel(nivel3);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            menu_principal:
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗" + "\n");
            Console.WriteLine("║                                                                                                                      ║" + "\n");
            Console.WriteLine("║                                                                                                                      ║" + "\n");
            Console.WriteLine("║                                                                                                                      ║" + "\n");
            Console.WriteLine("║                                                                                                                      ║" + "\n");
            Console.WriteLine("║                                  Ingrese la acción que desea realizar:__________                                     ║" + "\n");
            Console.WriteLine("║                                                                                                                      ║" + "\n");
            Console.WriteLine("║                                                                                                                      ║" + "\n");
            Console.WriteLine("║                                                                                                                      ║" + "\n");
            Console.WriteLine("║                                                                                                                      ║" + "\n");
            Console.WriteLine("║                                                                                                                      ║" + "\n");
            Console.WriteLine("║                                                         MAZE SCAPE                                                   ║" + "\n");
            Console.WriteLine("║                                                                                                                      ║" + "\n");
            Console.WriteLine("║                                                                                                                      ║" + "\n");
            Console.WriteLine("║                                                    1. Iniciar Juego                                                  ║" + "\n");
            Console.WriteLine("║                                                       a) Tablero1                                                    ║" + "\n");
            Console.WriteLine("║                                                       b) Tablero2                                                    ║" + "\n");
            Console.WriteLine("║                                                       c) Tablero3                                                    ║" + "\n");
            Console.WriteLine("║                                                    2. Salir                                                          ║" + "\n");
            Console.WriteLine("║                                                                                                                      ║" + "\n");
            Console.WriteLine("║                                                                                                                      ║" + "\n");
            Console.WriteLine("║                                                                                                                      ║" + "\n");
            Console.WriteLine("║                                                                                                                      ║" + "\n");
            Console.WriteLine("║                                                                                                                      ║" + "\n");
            Console.WriteLine("║                                                                                                                      ║" + "\n");
            Console.WriteLine("║                                                                                                                      ║" + "\n");
            Console.WriteLine("║                                                                                                                      ║" + "\n");
            Console.WriteLine("║                                                                                                                      ║" + "\n");
            Console.WriteLine("║                                                                                                                      ║" + "\n");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝" + "\n");
            opcion:
            Console.SetCursorPosition(77, 10);
            try
            {
                opcion = Convert.ToString(Console.ReadLine());
            }
            catch
            {
                Console.SetCursorPosition(50, 27);
                Console.WriteLine("Dato ingresado inválido");
                goto opcion;
            }
            if (opcion == "1" || opcion == "2")
            {
                if (opcion == "1")
                {
                    opcion_tablero:
                    Console.SetCursorPosition(35, 6);
                    Console.WriteLine("Ingrese el tablero al que desea ingresar:______");
                    Console.SetCursorPosition(78, 6);
                    try
                    {
                        opcion_tablero = Convert.ToString(Console.ReadLine());
                    }
                    catch
                    {
                        Console.SetCursorPosition(50, 27);
                        Console.WriteLine("Dato ingresado inválido");
                        goto opcion_tablero;
                    }
                    if (opcion_tablero == "a" || opcion_tablero == "b" || opcion_tablero == "c" || opcion_tablero == "A" || opcion_tablero == "B" || opcion_tablero == "C")
                    {
                        if (opcion_tablero == "a" || opcion_tablero == "A")
                        {
                            goto nivel1;
                            nivel1:

                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Clear();
                            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                  Ingrese la acción que desea realizar:__________                                     ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                         MAZE SCAPE                                                   ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                    1. Ingresar comando                                               ║");
                            Console.WriteLine("║                                                    2. Imprimir tablero                                               ║");
                            Console.WriteLine("║                                                    3. Estatus de personaje principal                                 ║");
                            Console.WriteLine("║                                                    4. Terminar partida                                               ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");

                            opcion_tablero1:


                            Console.SetCursorPosition(77, 5);
                            try
                            {
                                opcion = Convert.ToString(Console.ReadLine());
                            }
                            catch
                            {
                                Console.SetCursorPosition(50, 27);
                                Console.WriteLine("Dato ingresado inválido");
                                goto opcion;
                            }
                            if (opcion == "1" || opcion == "2" || opcion == "3" || opcion == "4")
                            {
                                if (opcion == "1")
                                {
                                    moverse_nivel1:
                                    Console.Clear();
                                    Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                        Nivel 1:                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                  Ingrese la acción que desea realizar:__________                                     ║");
                                    Console.WriteLine("║                                  Ingrese la dirección para la acción: __________                                     ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                         MAZE SCAPE                                                   ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║         ACCIONES:                                          DIRECCIONES:                                              ║");
                                    Console.WriteLine("║                                                                 U                                                    ║");
                                    Console.WriteLine("║         Atacar = a                                         ┌─────────┐                                               ║");
                                    Console.WriteLine("║         Mover  = m                                         │    ▲    │                                               ║");
                                    Console.WriteLine("║                                                  ┌─────────┼─────────┼─────────┐                                     ║");
                                    Console.WriteLine("║                                                L │   ◄     │    ▼    │     ►   │ R                                   ║");
                                    Console.WriteLine("║                                                  └─────────┴─────────┴─────────┘                                     ║");
                                    Console.WriteLine("║                                                                 D                                                    ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                 Resultado:                                                                                           ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                                    opcion_movimiento:
                                    Console.SetCursorPosition(77, 5);
                                    try
                                    {
                                        opcion_movimiento = Convert.ToString(Console.ReadLine());
                                    }
                                    catch
                                    {
                                        Console.SetCursorPosition(50, 27);
                                        Console.WriteLine("Dato ingresado inválido");
                                        goto opcion_movimiento;
                                    }

                                    if (opcion_movimiento == "a" || opcion_movimiento == "A" || opcion_movimiento == "m" || opcion_movimiento == "M")
                                    {
                                        opcion_direccion:
                                        Console.SetCursorPosition(77, 6);
                                        try
                                        {
                                            opcion_direccion = Convert.ToString(Console.ReadLine());
                                        }
                                        catch
                                        {
                                            Console.SetCursorPosition(50, 27);
                                            Console.WriteLine("Dato ingresado inválido");
                                            goto opcion_direccion;
                                        }

                                        if (opcion_direccion == "u" || opcion_direccion == "d" || opcion_direccion == "l" || opcion_direccion == "r" || opcion_direccion == "U" || opcion_direccion == "D" || opcion_direccion == "L" || opcion_direccion == "R")
                                        {
                                            //-----MOVIMIENTOS-----
                                            if (opcion_movimiento == "a" || opcion_movimiento == "A")
                                            {
                                                opcion_movimiento = "a";
                                            }
                                            if (opcion_direccion == "l" || opcion_direccion == "L") //IZQUIERDA
                                            {

                                                Console.SetCursorPosition(40, 24);
                                                if (nivel1[posicion_x, posicion_y - 1] == "obstaculo" || nivel1[posicion_x, posicion_y - 1] == sMarco)
                                                {
                                                    if (nivel1[posicion_x, posicion_y--] == "obstaculo")
                                                    {
                                                        Console.WriteLine("Obstaculo encotrado, no se puede mover a la izquierda :|");
                                                    }
                                                    if (nivel1[posicion_x, posicion_y] == sMarco)
                                                    {
                                                        Console.WriteLine("Borde encotrado, no se puede mover a la izquierda, pierdes un punto :/");

                                                    }

                                                }
                                                if (nivel1[posicion_x, posicion_y - 1] == sVacio)
                                                {
                                                    Console.WriteLine("Movimiento exitoso, puedes continuar :)");
                                                    nivel1[posicion_x, posicion_y] = sVacio;
                                                    nivel1[posicion_x, posicion_y - 1] = personaje;
                                                    posicion_y = posicion_y - 1;
                                                }

                                                if (nivel1[posicion_x, posicion_y - 1] == "enemigo")
                                                {
                                                    if (opcion_movimiento =="m"||opcion_movimiento=="M")
                                                    {
                                                        if (punteo > 0)
                                                        {
                                                            Console.WriteLine("¡Un enemigo te ha atacado! Pierdes un punto :(");
                                                            punteo = punteo--;
                                                        }
                                                    }
                                                    if (opcion_movimiento == "a" || opcion_movimiento == "A")
                                                    {
                                                        Console.WriteLine("¡Has derrotado a un enemigo! Ganas un punto :)");
                                                        punteo = punteo++;
                                                    }
                                                }
                                                if (nivel1[posicion_x, posicion_y - 1] == "fin")
                                                {
                                                    Console.WriteLine("¡FELICIDADES! Has ganado, ganas 10 puntos :D");
                                                    punteo = punteo + 10;
                                                    Console.ReadLine();
                                                    goto menu_principal;
                                                }
                                                goto fin_movimiento;


                                            }
                                            if (opcion_direccion == "r" || opcion_direccion == "R") //DERECHA
                                            {
                                                Console.SetCursorPosition(40, 24);
                                                if (nivel1[posicion_x, posicion_y + 1] == "obstaculo" || nivel1[posicion_x, posicion_y + 1] == sMarco)
                                                {
                                                    if (nivel1[posicion_x, posicion_y + 1] == "obstaculo")
                                                    {
                                                        Console.WriteLine("Obstaculo encotrado, no se puede mover a la derecha :|");
                                                        goto opcion_tablero1;
                                                    }
                                                    if (nivel1[posicion_x, posicion_y] == sMarco)
                                                    {
                                                        Console.WriteLine("Borde encotrado, no se puede mover a la derecha, pierdes un punto :/");
                                                        goto opcion_movimiento;

                                                    }

                                                }
                                                if (nivel1[posicion_x, posicion_y + 1] == sVacio)
                                                {
                                                    Console.WriteLine("Movimiento exitoso, puedes continuar :)");
                                                    nivel1[posicion_x, posicion_y] = sVacio;
                                                    nivel1[posicion_x, posicion_y + 1] = personaje;
                                                    posicion_y = posicion_y + 1;
                                                }

                                                if (nivel1[posicion_x, posicion_y + 1] == "enemigo")
                                                {
                                                    if (opcion_movimiento != "a" || opcion_movimiento != "A")
                                                    {
                                                        if (punteo > 0)
                                                        {
                                                            Console.WriteLine("¡Un enemigo te ha atacado! Pierdes un punto :(");
                                                            punteo = punteo--;
                                                        }
                                                    }
                                                    if (opcion_movimiento == "a" || opcion_movimiento == "A")
                                                    {
                                                        Console.WriteLine("¡Has derrotado a un enemigo! Ganas un punto :)");
                                                        punteo = punteo--;
                                                    }
                                                }
                                                if (nivel1[posicion_x, posicion_y + 1] == "fin")
                                                {
                                                    Console.WriteLine("¡FELICIDADES! Has ganado, ganas 10 puntos :D");
                                                    punteo = punteo + 10;
                                                    Console.ReadLine();
                                                    goto menu_principal;
                                                }
                                                goto fin_movimiento;


                                            }
                                            if (opcion_direccion == "u" || opcion_direccion == "U") //ARRIBA
                                            {
                                                Console.SetCursorPosition(40, 24);
                                                if (nivel1[posicion_x - 1, posicion_y] == "obstaculo" || nivel1[posicion_x - 1, posicion_y] == sMarco)
                                                {
                                                    if (nivel1[posicion_x - 1, posicion_y] == "obstaculo")
                                                    {
                                                        Console.WriteLine("Obstaculo encotrado, no se puede mover a la izquierda :|");
                                                    }
                                                    if (nivel1[posicion_x - 1, posicion_y] == sMarco)
                                                    {
                                                        Console.WriteLine("Borde encotrado, no se puede mover arriba, pierdes un punto :/");
                                                    }

                                                }
                                                if (nivel1[posicion_x - 1, posicion_y] == sVacio)
                                                {
                                                    Console.WriteLine("Movimiento exitoso, puedes continuar :)");
                                                    nivel1[posicion_x - 1, posicion_y] = sVacio;
                                                    nivel1[posicion_x - 1, posicion_y] = personaje;
                                                    posicion_y = posicion_y - 1;
                                                }

                                                if (nivel1[posicion_x - 1, posicion_y] == "enemigo")
                                                {
                                                    if (opcion_movimiento != "a" || opcion_movimiento != "A")
                                                    {
                                                        if (punteo > 0)
                                                        {
                                                            Console.WriteLine("¡Un enemigo te ha atacado! Pierdes un punto :(");
                                                            punteo = punteo--;
                                                        }
                                                    }
                                                    if (opcion_movimiento == "a" || opcion_movimiento == "A")
                                                    {
                                                        Console.WriteLine("¡Has derrotado a un enemigo! Ganas un punto :)");
                                                        punteo = punteo--;
                                                    }
                                                }
                                                if (nivel1[posicion_x - 1, posicion_y] == "fin")
                                                {
                                                    Console.WriteLine("¡FELICIDADES! Has ganado, ganas 10 puntos :D");
                                                    punteo = punteo + 10;
                                                    Console.ReadLine();
                                                    goto menu_principal;
                                                }
                                                goto fin_movimiento;


                                            }
                                            if (opcion_direccion == "d" || opcion_direccion == "D") //ABAJO
                                            {
                                                Console.SetCursorPosition(40, 24);
                                                if (nivel1[posicion_x + 1, posicion_y] == "obstaculo" || nivel1[posicion_x + 1, posicion_y] == sMarco)
                                                {
                                                    if (nivel1[posicion_x + 1, posicion_y] == "obstaculo")
                                                    {
                                                        Console.WriteLine("Obstaculo encotrado, no se puede mover a la izquierda :|");
                                                    }
                                                    if (nivel1[posicion_x + 1, posicion_y] == sMarco)
                                                    {
                                                        Console.WriteLine("Borde encotrado, no se puede mover abajo, pierdes un punto :/");

                                                    }

                                                }
                                                if (nivel1[posicion_x + 1, posicion_y] == sVacio)
                                                {
                                                    Console.WriteLine("Movimiento exitoso, puedes continuar :)");
                                                    nivel1[posicion_x + 1, posicion_y] = sVacio;
                                                    nivel1[posicion_x + 1, posicion_y] = personaje;
                                                    posicion_y = posicion_y + 1;
                                                }

                                                if (nivel1[posicion_x + 1, posicion_y] == "enemigo")
                                                {
                                                    if (opcion_movimiento != "a" || opcion_movimiento != "A")
                                                    {
                                                        if (punteo > 0)
                                                        {
                                                            Console.WriteLine("¡Un enemigo te ha atacado! Pierdes un punto :(");
                                                            punteo = punteo--;
                                                        }
                                                    }
                                                    if (opcion_movimiento == "a" || opcion_movimiento == "A")
                                                    {
                                                        Console.WriteLine("¡Has derrotado a un enemigo! Ganas un punto :)");
                                                        punteo = punteo--;
                                                    }
                                                }
                                                if (nivel1[posicion_x + 1, posicion_y] == "fin")
                                                {
                                                    Console.WriteLine("¡FELICIDADES! Has ganado, ganas 10 puntos :D");
                                                    punteo = punteo + 10;
                                                    Console.ReadLine();
                                                    goto menu_principal;
                                                }
                                                goto fin_movimiento;


                                            }

                                            goto fin_movimiento;
                                            fin_movimiento:
                                            Console.SetCursorPosition(20, 25);
                                            Console.WriteLine("Escriba 'v' para volver al menú anterior, sino presione ENTER");
                                            Console.SetCursorPosition(20, 26);
                                            volver = Convert.ToString(Console.ReadLine());
                                            if (volver == "v" || volver == "V")
                                            {
                                                goto nivel1;
                                            }
                                            else
                                            {
                                                goto moverse_nivel1;
                                            }
                                        }
                                        else
                                        {
                                            Console.SetCursorPosition(20, 26);
                                            Console.WriteLine("Esa opción no existe.");
                                            goto opcion_direccion;
                                        }


                                    }
                                    else
                                    {
                                        Console.SetCursorPosition(20, 26);
                                        Console.WriteLine("Esa opción no existe.");
                                        goto opcion_movimiento;
                                    }
                                }
                                if (opcion == "2")
                                {
                                    Console.Clear(); 
                                   
                                            Console.Write(mostrarnivel(nivel1) );
                                        Console.Write("\n");
                                    Console.SetCursorPosition(20, 25);
                                    Console.WriteLine("Presione cualquier tecla para volver");
                                    Console.ReadLine();
                                    goto nivel1;
                                }
                                if (opcion == "3")
                                {
                                    Console.Clear();
                                    Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                   Estatus personaje principal                                        ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                         MAZE SCAPE                                                   ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                    1. Punteo:                                                        ║");
                                    Console.WriteLine("║                                                    2. Posición del personaje en x:                                   ║");
                                    Console.WriteLine("║                                                    3. Posición del personaje en y:                                   ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                      Presione cualquier tecla para volver al menú anterior.                          ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                                    Console.SetCursorPosition(65, 14);
                                    Console.Write(punteo);
                                    Console.SetCursorPosition(85, 15);
                                    Console.Write(posicion_y);
                                    Console.SetCursorPosition(85, 16);
                                    Console.Write(posicion_x);
                                    Console.ReadLine();
                                    goto nivel1; 
                                }
                                if (opcion == "4")
                                {
                                    goto menu_principal;
                                }

                            }

                        }
                        if (opcion_tablero == "b" || opcion_tablero == "B")
                        {
                            goto nivel2;
                            nivel2:

                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Clear();
                            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                  Ingrese la acción que desea realizar:__________                                     ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                         MAZE SCAPE                                                   ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                    1. Ingresar comando                                               ║");
                            Console.WriteLine("║                                                    2. Imprimir tablero                                               ║");
                            Console.WriteLine("║                                                    3. Estatus de personaje principal                                 ║");
                            Console.WriteLine("║                                                    4. Terminar partida                                               ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");

                            opcion_tablero2:


                            Console.SetCursorPosition(77, 5);
                            try
                            {
                                opcion = Convert.ToString(Console.ReadLine());
                            }
                            catch
                            {
                                Console.SetCursorPosition(50, 27);
                                Console.WriteLine("Dato ingresado inválido");
                                goto opcion;
                            }
                            if (opcion == "1" || opcion == "2" || opcion == "3" || opcion == "4")
                            {
                                if (opcion == "1")
                                {
                                    moverse_nivel2:
                                    Console.Clear();
                                    Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                        Nivel 2:                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                  Ingrese la acción que desea realizar:__________                                     ║");
                                    Console.WriteLine("║                                  Ingrese la dirección para la acción: __________                                     ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                         MAZE SCAPE                                                   ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║         ACCIONES:                                          DIRECCIONES:                                              ║");
                                    Console.WriteLine("║                                                                 U                                                    ║");
                                    Console.WriteLine("║         Atacar = a                                         ┌─────────┐                                               ║");
                                    Console.WriteLine("║         Mover  = m                                         │    ▲    │                                               ║");
                                    Console.WriteLine("║                                                  ┌─────────┼─────────┼─────────┐                                     ║");
                                    Console.WriteLine("║                                                L │   ◄     │    ▼    │     ►   │ R                                   ║");
                                    Console.WriteLine("║                                                  └─────────┴─────────┴─────────┘                                     ║");
                                    Console.WriteLine("║                                                                 D                                                    ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                 Resultado:                                                                                           ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                                    opcion_movimiento:
                                    Console.SetCursorPosition(77, 5);
                                    try
                                    {
                                        opcion_movimiento = Convert.ToString(Console.ReadLine());
                                    }
                                    catch
                                    {
                                        Console.SetCursorPosition(50, 27);
                                        Console.WriteLine("Dato ingresado inválido");
                                        goto opcion_movimiento;
                                    }

                                    if (opcion_movimiento == "a" || opcion_movimiento == "A" || opcion_movimiento == "m" || opcion_movimiento == "M")
                                    {
                                        opcion_direccion:
                                        Console.SetCursorPosition(77, 6);
                                        try
                                        {
                                            opcion_direccion = Convert.ToString(Console.ReadLine());
                                        }
                                        catch
                                        {
                                            Console.SetCursorPosition(50, 27);
                                            Console.WriteLine("Dato ingresado inválido");
                                            goto opcion_direccion;
                                        }

                                        if (opcion_direccion == "u" || opcion_direccion == "d" || opcion_direccion == "l" || opcion_direccion == "r" || opcion_direccion == "U" || opcion_direccion == "D" || opcion_direccion == "L" || opcion_direccion == "R")
                                        {
                                            //-----MOVIMIENTOS-----
                                            if (opcion_movimiento == "a" || opcion_movimiento == "A")
                                            {
                                                opcion_movimiento = "a";
                                            }
                                            if (opcion_direccion == "l" || opcion_direccion == "L") //IZQUIERDA
                                            {

                                                Console.SetCursorPosition(40, 24);
                                                if (nivel2[posicion_x, posicion_y - 1] == "obstaculo" || nivel2[posicion_x, posicion_y - 1] == sMarco)
                                                {
                                                    if (nivel2[posicion_x, posicion_y--] == "obstaculo")
                                                    {
                                                        Console.WriteLine("Obstaculo encotrado, no se puede mover a la izquierda :|");
                                                    }
                                                    if (nivel2[posicion_x, posicion_y] == sMarco)
                                                    {
                                                        Console.WriteLine("Borde encotrado, no se puede mover a la izquierda, pierdes un punto :/");

                                                    }

                                                }
                                                if (nivel2[posicion_x, posicion_y - 1] == sVacio)
                                                {
                                                    Console.WriteLine("Movimiento exitoso, puedes continuar :)");
                                                    nivel2[posicion_x, posicion_y] = sVacio;
                                                    nivel2[posicion_x, posicion_y - 1] = personaje;
                                                    posicion_y = posicion_y - 1;
                                                }

                                                if (nivel2[posicion_x, posicion_y - 1] == "enemigo")
                                                {
                                                    if (opcion_movimiento != "a" || opcion_movimiento != "A")
                                                    {
                                                        if (punteo > 0)
                                                        {
                                                            Console.WriteLine("¡Un enemigo te ha atacado! Pierdes un punto :(");
                                                            punteo = punteo--;
                                                        }
                                                    }
                                                    if (opcion_movimiento == "a" || opcion_movimiento == "A")
                                                    {
                                                        Console.WriteLine("¡Has derrotado a un enemigo! Ganas un punto :)");
                                                        punteo = punteo++;
                                                    }
                                                }
                                                if (nivel2[posicion_x, posicion_y - 1] == "fin")
                                                {
                                                    Console.WriteLine("¡FELICIDADES! Has ganado, ganas 10 puntos :D");
                                                    punteo = punteo + 10;
                                                    Console.ReadLine();
                                                    goto menu_principal;
                                                }
                                                goto fin_movimiento;


                                            }
                                            if (opcion_direccion == "r" || opcion_direccion == "R") //DERECHA
                                            {
                                                Console.SetCursorPosition(40, 24);
                                                if (nivel2[posicion_x, posicion_y + 1] == "obstaculo" || nivel2[posicion_x, posicion_y + 1] == sMarco)
                                                {
                                                    if (nivel2[posicion_x, posicion_y + 1] == "obstaculo")
                                                    {
                                                        Console.WriteLine("Obstaculo encotrado, no se puede mover a la derecha :|");
                                                        goto opcion_tablero2;
                                                    }
                                                    if (nivel2[posicion_x, posicion_y] == sMarco)
                                                    {
                                                        Console.WriteLine("Borde encotrado, no se puede mover a la derecha, pierdes un punto :/");
                                                        goto opcion_movimiento;

                                                    }

                                                }
                                                if (nivel2[posicion_x, posicion_y + 1] == sVacio)
                                                {
                                                    Console.WriteLine("Movimiento exitoso, puedes continuar :)");
                                                    nivel2[posicion_x, posicion_y] = sVacio;
                                                    nivel2[posicion_x, posicion_y + 1] = personaje;
                                                    posicion_y = posicion_y + 1;
                                                }

                                                if (nivel2[posicion_x, posicion_y + 1] == "enemigo")
                                                {
                                                    if (opcion_movimiento != "a" || opcion_movimiento != "A")
                                                    {
                                                        if (punteo > 0)
                                                        {
                                                            Console.WriteLine("¡Un enemigo te ha atacado! Pierdes un punto :(");
                                                            punteo = punteo--;
                                                        }
                                                    }
                                                    if (opcion_movimiento == "a" || opcion_movimiento == "A")
                                                    {
                                                        Console.WriteLine("¡Has derrotado a un enemigo! Ganas un punto :)");
                                                        punteo = punteo--;
                                                    }
                                                }
                                                if (nivel2[posicion_x, posicion_y + 1] == "fin")
                                                {
                                                    Console.WriteLine("¡FELICIDADES! Has ganado, ganas 10 puntos :D");
                                                    punteo = punteo + 10;
                                                    Console.ReadLine();
                                                    goto menu_principal;
                                                }
                                                goto fin_movimiento;


                                            }
                                            if (opcion_direccion == "u" || opcion_direccion == "U") //ARRIBA
                                            {
                                                Console.SetCursorPosition(40, 24);
                                                if (nivel2[posicion_x - 1, posicion_y] == "obstaculo" || nivel2[posicion_x - 1, posicion_y] == sMarco)
                                                {
                                                    if (nivel2[posicion_x - 1, posicion_y] == "obstaculo")
                                                    {
                                                        Console.WriteLine("Obstaculo encotrado, no se puede mover a la izquierda :|");
                                                    }
                                                    if (nivel2[posicion_x - 1, posicion_y] == sMarco)
                                                    {
                                                        Console.WriteLine("Borde encotrado, no se puede mover arriba, pierdes un punto :/");
                                                    }

                                                }
                                                if (nivel2[posicion_x - 1, posicion_y] == sVacio)
                                                {
                                                    Console.WriteLine("Movimiento exitoso, puedes continuar :)");
                                                    nivel2[posicion_x - 1, posicion_y] = sVacio;
                                                    nivel2[posicion_x - 1, posicion_y] = personaje;
                                                    posicion_y = posicion_y - 1;
                                                }

                                                if (nivel2[posicion_x - 1, posicion_y] == "enemigo")
                                                {
                                                    if (opcion_movimiento != "a" || opcion_movimiento != "A")
                                                    {
                                                        if (punteo > 0)
                                                        {
                                                            Console.WriteLine("¡Un enemigo te ha atacado! Pierdes un punto :(");
                                                            punteo = punteo--;
                                                        }
                                                    }
                                                    if (opcion_movimiento == "a" || opcion_movimiento == "A")
                                                    {
                                                        Console.WriteLine("¡Has derrotado a un enemigo! Ganas un punto :)");
                                                        punteo = punteo--;
                                                    }
                                                }
                                                if (nivel2[posicion_x - 1, posicion_y] == "fin")
                                                {
                                                    Console.WriteLine("¡FELICIDADES! Has ganado, ganas 10 puntos :D");
                                                    punteo = punteo + 10;
                                                    Console.ReadLine();
                                                    goto menu_principal;
                                                }
                                                goto fin_movimiento;


                                            }
                                            if (opcion_direccion == "d" || opcion_direccion == "D") //IZQUIERDA
                                            {
                                                Console.SetCursorPosition(40, 24);
                                                if (nivel2[posicion_x + 1, posicion_y] == "obstaculo" || nivel2[posicion_x + 1, posicion_y] == sMarco)
                                                {
                                                    if (nivel2[posicion_x + 1, posicion_y] == "obstaculo")
                                                    {
                                                        Console.WriteLine("Obstaculo encotrado, no se puede mover a la izquierda :|");
                                                    }
                                                    if (nivel2[posicion_x + 1, posicion_y] == sMarco)
                                                    {
                                                        Console.WriteLine("Borde encotrado, no se puede mover a la izquierda, pierdes un punto :/");

                                                    }

                                                }
                                                if (nivel2[posicion_x + 1, posicion_y] == sVacio)
                                                {
                                                    Console.WriteLine("Movimiento exitoso, puedes conttinuar :)");
                                                    nivel2[posicion_x + 1, posicion_y] = sVacio;
                                                    nivel2[posicion_x + 1, posicion_y] = personaje;
                                                    posicion_y = posicion_y + 1;
                                                }

                                                if (nivel2[posicion_x + 1, posicion_y] == "enemigo")
                                                {
                                                    if (opcion_movimiento != "a" || opcion_movimiento != "A")
                                                    {
                                                        if (punteo > 0)
                                                        {
                                                            Console.WriteLine("¡Un enemigo te ha atacado! Pierdes un punto :(");
                                                            punteo = punteo--;
                                                        }
                                                    }
                                                    if (opcion_movimiento == "a" || opcion_movimiento == "A")
                                                    {
                                                        Console.WriteLine("¡Has derrotado a un enemigo! Ganas un punto :)");
                                                        punteo = punteo--;
                                                    }
                                                }
                                                if (nivel2[posicion_x + 1, posicion_y] == "fin")
                                                {
                                                    Console.WriteLine("¡FELICIDADES! Has ganado, ganas 10 puntos :D");
                                                    punteo = punteo + 10;
                                                    Console.ReadLine();
                                                    goto menu_principal;
                                                }
                                                goto fin_movimiento;


                                            }

                                            goto fin_movimiento;
                                            fin_movimiento:
                                            Console.SetCursorPosition(20, 25);
                                            Console.WriteLine("Escriba 'v' para volver al menú anterior, sino presione ENTER");
                                            Console.SetCursorPosition(20, 26);
                                            volver = Convert.ToString(Console.ReadLine());
                                            if (volver == "v" || volver == "V")
                                            {
                                                goto nivel2;
                                            }
                                            else
                                            {
                                                goto moverse_nivel2;
                                            }
                                        }
                                        else
                                        {
                                            Console.SetCursorPosition(20, 26);
                                            Console.WriteLine("Esa opción no existe.");
                                            goto opcion_direccion;
                                        }


                                    }
                                    else
                                    {
                                        Console.SetCursorPosition(20, 26);
                                        Console.WriteLine("Esa opción no existe.");
                                        goto opcion_movimiento;
                                    }
                                }
                            }
                            if (opcion == "2")
                            {
                                Console.Clear();

                                Console.Write(mostrarnivel(nivel2));
                                Console.Write("\n");
                                Console.SetCursorPosition(20, 25);
                                Console.WriteLine("Presione cualquier tecla para volver");
                                Console.ReadLine();
                                goto nivel2;
                            }
                            if (opcion == "3")
                            {
                                Console.Clear();
                                Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                                Console.WriteLine("║                                                                                                                      ║");
                                Console.WriteLine("║                                                                                                                      ║");
                                Console.WriteLine("║                                                                                                                      ║");
                                Console.WriteLine("║                                                                                                                      ║");
                                Console.WriteLine("║                                                   Estatus personaje principal                                        ║");
                                Console.WriteLine("║                                                                                                                      ║");
                                Console.WriteLine("║                                                                                                                      ║");
                                Console.WriteLine("║                                                                                                                      ║");
                                Console.WriteLine("║                                                                                                                      ║");
                                Console.WriteLine("║                                                                                                                      ║");
                                Console.WriteLine("║                                                         MAZE SCAPE                                                   ║");
                                Console.WriteLine("║                                                                                                                      ║");
                                Console.WriteLine("║                                                                                                                      ║");
                                Console.WriteLine("║                                                    1. Punteo:                                                        ║");
                                Console.WriteLine("║                                                    2. Posición del personaje en x:                                   ║");
                                Console.WriteLine("║                                                    3. Posición del personaje en y:                                   ║");
                                Console.WriteLine("║                                                                                                                      ║");
                                Console.WriteLine("║                                                                                                                      ║");
                                Console.WriteLine("║                                                                                                                      ║");
                                Console.WriteLine("║                                                                                                                      ║");
                                Console.WriteLine("║                                                                                                                      ║");
                                Console.WriteLine("║                                      Presione cualquier tecla para volver al menú anterior.                          ║");
                                Console.WriteLine("║                                                                                                                      ║");
                                Console.WriteLine("║                                                                                                                      ║");
                                Console.WriteLine("║                                                                                                                      ║");
                                Console.WriteLine("║                                                                                                                      ║");
                                Console.WriteLine("║                                                                                                                      ║");
                                Console.WriteLine("║                                                                                                                      ║");
                                Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                                Console.SetCursorPosition(65, 14);
                                Console.Write(punteo);
                                Console.SetCursorPosition(85, 15);
                                Console.Write(posicion_y);
                                Console.SetCursorPosition(85, 16);
                                Console.Write(posicion_x);
                                Console.ReadLine();
                                goto nivel2;
                            }
                            if (opcion == "4")
                            {
                                goto menu_principal;
                            }
                        }
                        if (opcion_tablero == "c" || opcion_tablero == "C")
                        {
                            goto nivel3;

                            nivel3:

                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Clear();
                            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                  Ingrese la acción que desea realizar:__________                                     ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                         MAZE SCAPE                                                   ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                    1. Ingresar comando                                               ║");
                            Console.WriteLine("║                                                    2. Imprimir tablero                                               ║");
                            Console.WriteLine("║                                                    3. Estatus de personaje principal                                 ║");
                            Console.WriteLine("║                                                    4. Terminar partida                                               ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("║                                                                                                                      ║");
                            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");

                            opcion_tablero3:


                            Console.SetCursorPosition(77, 5);
                            try
                            {
                                opcion = Convert.ToString(Console.ReadLine());
                            }
                            catch
                            {
                                Console.SetCursorPosition(50, 27);
                                Console.WriteLine("Dato ingresado inválido");
                                goto opcion;
                            }
                            if (opcion == "1" || opcion == "2" || opcion == "3" || opcion == "4")
                            {
                                if (opcion == "1")
                                {
                                    moverse_nivel3:
                                    Console.Clear();
                                    Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                        Nivel 3:                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                  Ingrese la acción que desea realizar:__________                                     ║");
                                    Console.WriteLine("║                                  Ingrese la dirección para la acción: __________                                     ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                         MAZE SCAPE                                                   ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║         ACCIONES:                                          DIRECCIONES:                                              ║");
                                    Console.WriteLine("║                                                                 U                                                    ║");
                                    Console.WriteLine("║         Atacar = a                                         ┌─────────┐                                               ║");
                                    Console.WriteLine("║         Mover  = m                                         │    ▲    │                                               ║");
                                    Console.WriteLine("║                                                  ┌─────────┼─────────┼─────────┐                                     ║");
                                    Console.WriteLine("║                                                L │   ◄     │    ▼    │     ►   │ R                                   ║");
                                    Console.WriteLine("║                                                  └─────────┴─────────┴─────────┘                                     ║");
                                    Console.WriteLine("║                                                                 D                                                    ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                 Resultado:                                                                                           ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                                    opcion_movimiento:
                                    Console.SetCursorPosition(77, 5);
                                    try
                                    {
                                        opcion_movimiento = Convert.ToString(Console.ReadLine());
                                    }
                                    catch
                                    {
                                        Console.SetCursorPosition(50, 27);
                                        Console.WriteLine("Dato ingresado inválido");
                                        goto opcion_movimiento;
                                    }

                                    if (opcion_movimiento == "a" || opcion_movimiento == "A" || opcion_movimiento == "m" || opcion_movimiento == "M")
                                    {
                                        opcion_direccion:
                                        Console.SetCursorPosition(77, 6);
                                        try
                                        {
                                            opcion_direccion = Convert.ToString(Console.ReadLine());
                                        }
                                        catch
                                        {
                                            Console.SetCursorPosition(50, 27);
                                            Console.WriteLine("Dato ingresado inválido");
                                            goto opcion_direccion;
                                        }

                                        if (opcion_direccion == "u" || opcion_direccion == "d" || opcion_direccion == "l" || opcion_direccion == "r" || opcion_direccion == "U" || opcion_direccion == "D" || opcion_direccion == "L" || opcion_direccion == "R")
                                        {
                                            //-----MOVIMIENTOS-----
                                            if (opcion_movimiento == "a" || opcion_movimiento == "A")
                                            {
                                                opcion_movimiento = "a";
                                            }
                                            if (opcion_direccion == "l" || opcion_direccion == "L") //IZQUIERDA
                                            {

                                                Console.SetCursorPosition(40, 24);
                                                if (nivel3[posicion_x, posicion_y - 1] == "obstaculo" || nivel3[posicion_x, posicion_y - 1] == sMarco)
                                                {
                                                    if (nivel3[posicion_x, posicion_y--] == "obstaculo")
                                                    {
                                                        Console.WriteLine("Obstaculo encotrado, no se puede mover a la izquierda :|");
                                                    }
                                                    if (nivel3[posicion_x, posicion_y] == sMarco)
                                                    {
                                                        Console.WriteLine("Borde encotrado, no se puede mover a la izquierda, pierdes un punto :/");

                                                    }

                                                }
                                                if (nivel3[posicion_x, posicion_y - 1] == sVacio)
                                                {
                                                    Console.WriteLine("Movimiento exitoso, puedes continuar :)");
                                                    nivel3[posicion_x, posicion_y] = sVacio;
                                                    nivel3[posicion_x, posicion_y - 1] = personaje;
                                                    posicion_y = posicion_y - 1;
                                                }

                                                if (nivel3[posicion_x, posicion_y - 1] == "enemigo")
                                                {
                                                    if (opcion_movimiento != "a" || opcion_movimiento != "A")
                                                    {
                                                        if (punteo > 0)
                                                        {
                                                            Console.WriteLine("¡Un enemigo te ha atacado! Pierdes un punto :(");
                                                            punteo = punteo--;
                                                        }
                                                    }
                                                    if (opcion_movimiento == "a" || opcion_movimiento == "A")
                                                    {
                                                        Console.WriteLine("¡Has derrotado a un enemigo! Ganas un punto :)");
                                                        punteo = punteo++;
                                                    }
                                                }
                                                if (nivel3[posicion_x, posicion_y - 1] == "fin")
                                                {
                                                    Console.WriteLine("¡FELICIDADES! Has ganado, ganas 10 puntos :D");
                                                    punteo = punteo + 10;
                                                    Console.ReadLine();
                                                    goto menu_principal;
                                                }
                                                goto fin_movimiento;


                                            }
                                            if (opcion_direccion == "r" || opcion_direccion == "R") //DERECHA
                                            {
                                                Console.SetCursorPosition(40, 24);
                                                if (nivel3[posicion_x, posicion_y + 1] == "obstaculo" || nivel3[posicion_x, posicion_y + 1] == sMarco)
                                                {
                                                    if (nivel3[posicion_x, posicion_y + 1] == "obstaculo")
                                                    {
                                                        Console.WriteLine("Obstaculo encotrado, no se puede mover a la derecha :|");
                                                        goto opcion_tablero3;
                                                    }
                                                    if (nivel3[posicion_x, posicion_y] == sMarco)
                                                    {
                                                        Console.WriteLine("Borde encotrado, no se puede mover a la derecha, pierdes un punto :/");
                                                        goto opcion_movimiento;

                                                    }

                                                }
                                                if (nivel3[posicion_x, posicion_y + 1] == sVacio)
                                                {
                                                    Console.WriteLine("Movimiento exitoso, puedes continuar :)");
                                                    nivel3[posicion_x, posicion_y] = sVacio;
                                                    nivel3[posicion_x, posicion_y + 1] = personaje;
                                                    posicion_y = posicion_y + 1;
                                                }

                                                if (nivel3[posicion_x, posicion_y + 1] == "enemigo")
                                                {
                                                    if (opcion_movimiento != "a" || opcion_movimiento != "A")
                                                    {
                                                        if (punteo > 0)
                                                        {
                                                            Console.WriteLine("¡Un enemigo te ha atacado! Pierdes un punto :(");
                                                            punteo = punteo--;
                                                        }
                                                    }
                                                    if (opcion_movimiento == "a" || opcion_movimiento == "A")
                                                    {
                                                        Console.WriteLine("¡Has derrotado a un enemigo! Ganas un punto :)");
                                                        punteo = punteo--;
                                                    }
                                                }
                                                if (nivel3[posicion_x, posicion_y + 1] == "fin")
                                                {
                                                    Console.WriteLine("¡FELICIDADES! Has ganado, ganas 10 puntos :D");
                                                    punteo = punteo + 10;
                                                    Console.ReadLine();
                                                    goto menu_principal;
                                                }
                                                goto fin_movimiento;


                                            }
                                            if (opcion_direccion == "u" || opcion_direccion == "U") //ARRIBA
                                            {
                                                Console.SetCursorPosition(40, 24);
                                                if (nivel3[posicion_x - 1, posicion_y] == "obstaculo" || nivel3[posicion_x - 1, posicion_y] == sMarco)
                                                {
                                                    if (nivel3[posicion_x - 1, posicion_y] == "obstaculo")
                                                    {
                                                        Console.WriteLine("Obstaculo encotrado, no se puede mover a la izquierda :|");
                                                    }
                                                    if (nivel3[posicion_x - 1, posicion_y] == sMarco)
                                                    {
                                                        Console.WriteLine("Borde encotrado, no se puede mover arriba, pierdes un punto :/");
                                                    }

                                                }
                                                if (nivel3[posicion_x - 1, posicion_y] == sVacio)
                                                {
                                                    Console.WriteLine("Movimiento exitoso, puedes continuar :)");
                                                    nivel3[posicion_x - 1, posicion_y] = sVacio;
                                                    nivel3[posicion_x - 1, posicion_y] = personaje;
                                                    posicion_y = posicion_y - 1;
                                                }

                                                if (nivel3[posicion_x - 1, posicion_y] == "enemigo")
                                                {
                                                    if (opcion_movimiento != "a" || opcion_movimiento != "A")
                                                    {
                                                        if (punteo > 0)
                                                        {
                                                            Console.WriteLine("¡Un enemigo te ha atacado! Pierdes un punto :(");
                                                            punteo = punteo--;
                                                        }
                                                    }
                                                    if (opcion_movimiento == "a" || opcion_movimiento == "A")
                                                    {
                                                        Console.WriteLine("¡Has derrotado a un enemigo! Ganas un punto :)");
                                                        punteo = punteo--;
                                                    }
                                                }
                                                if (nivel3[posicion_x - 1, posicion_y] == "fin")
                                                {
                                                    Console.WriteLine("¡FELICIDADES! Has ganado, ganas 10 puntos :D");
                                                    punteo = punteo + 10;
                                                    Console.ReadLine();
                                                    goto menu_principal;
                                                }
                                                goto fin_movimiento;


                                            }
                                            if (opcion_direccion == "d" || opcion_direccion == "D") //IZQUIERDA
                                            {
                                                Console.SetCursorPosition(40, 24);
                                                if (nivel3[posicion_x + 1, posicion_y] == "obstaculo" || nivel3[posicion_x + 1, posicion_y] == sMarco)
                                                {
                                                    if (nivel3[posicion_x + 1, posicion_y] == "obstaculo")
                                                    {
                                                        Console.WriteLine("Obstaculo encotrado, no se puede mover a la izquierda :|");
                                                    }
                                                    if (nivel3[posicion_x + 1, posicion_y] == sMarco)
                                                    {
                                                        Console.WriteLine("Borde encotrado, no se puede mover a la izquierda, pierdes un punto :/");

                                                    }

                                                }
                                                if (nivel3[posicion_x + 1, posicion_y] == sVacio)
                                                {
                                                    Console.WriteLine("Movimiento exitoso, puedes conttinuar :)");
                                                    nivel3[posicion_x + 1, posicion_y] = sVacio;
                                                    nivel3[posicion_x + 1, posicion_y] = personaje;
                                                    posicion_y = posicion_y + 1;
                                                }

                                                if (nivel3[posicion_x + 1, posicion_y] == "enemigo")
                                                {
                                                    if (opcion_movimiento != "a" || opcion_movimiento != "A")
                                                    {
                                                        if (punteo > 0)
                                                        {
                                                            Console.WriteLine("¡Un enemigo te ha atacado! Pierdes un punto :(");
                                                            punteo = punteo--;
                                                        }
                                                    }
                                                    if (opcion_movimiento == "a" || opcion_movimiento == "A")
                                                    {
                                                        Console.WriteLine("¡Has derrotado a un enemigo! Ganas un punto :)");
                                                        punteo = punteo--;
                                                    }
                                                }
                                                if (nivel3[posicion_x + 1, posicion_y] == "fin")
                                                {
                                                    Console.WriteLine("¡FELICIDADES! Has ganado, ganas 10 puntos :D");
                                                    punteo = punteo + 10;
                                                    Console.ReadLine();
                                                    goto menu_principal;
                                                }
                                                goto fin_movimiento;


                                            }

                                            goto fin_movimiento;
                                            fin_movimiento:
                                            Console.SetCursorPosition(20, 25);
                                            Console.WriteLine("Escriba 'v' para volver al menú anterior, sino presione ENTER");
                                            Console.SetCursorPosition(20, 26);
                                            volver = Convert.ToString(Console.ReadLine());
                                            if (volver == "v" || volver == "V")
                                            {
                                                goto nivel3;
                                            }
                                            else
                                            {
                                                goto moverse_nivel3;
                                            }
                                        }
                                        else
                                        {
                                            Console.SetCursorPosition(20, 26);
                                            Console.WriteLine("Esa opción no existe.");
                                            goto opcion_direccion;
                                        }


                                    }
                                    else
                                    {
                                        Console.SetCursorPosition(20, 26);
                                        Console.WriteLine("Esa opción no existe.");
                                        goto opcion_movimiento;
                                    }
                                }
                                if (opcion == "2")
                                {
                                    Console.Clear();

                                    Console.Write(mostrarnivel(nivel3));
                                    Console.Write("\n");
                                    Console.SetCursorPosition(20, 25);
                                    Console.WriteLine("Presione cualquier tecla para volver");
                                    Console.ReadLine();
                                    goto nivel3;
                                }
                                if (opcion == "3")
                                {
                                    Console.Clear();
                                    Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                   Estatus personaje principal                                        ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                         MAZE SCAPE                                                   ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                    1. Punteo:                                                        ║");
                                    Console.WriteLine("║                                                    2. Posición del personaje en x:                                   ║");
                                    Console.WriteLine("║                                                    3. Posición del personaje en y:                                   ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                      Presione cualquier tecla para volver al menú anterior.                          ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("║                                                                                                                      ║");
                                    Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                                    Console.SetCursorPosition(65, 14);
                                    Console.Write(punteo);
                                    Console.SetCursorPosition(85, 15);
                                    Console.Write(posicion_y);
                                    Console.SetCursorPosition(85, 16);
                                    Console.Write(posicion_x);
                                    Console.ReadLine();
                                    goto nivel3;
                                }
                                if (opcion == "4")
                                {
                                    goto menu_principal;
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.SetCursorPosition(50, 27);
                        Console.WriteLine("Esa opción no existe");
                        goto opcion_tablero;
                    }

                }
                if (opcion == "2")
                {
                    Console.Clear();
                    Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                    Console.WriteLine("║                                                                                                                      ║");
                    Console.WriteLine("║                                                                                                                      ║");
                    Console.WriteLine("║                                                                                                                      ║");
                    Console.WriteLine("║                                                                                                                      ║");
                    Console.WriteLine("║                                                                                                                      ║");
                    Console.WriteLine("║                                                                                                                      ║");
                    Console.WriteLine("║                                                                                                                      ║");
                    Console.WriteLine("║                                                                                                                      ║");
                    Console.WriteLine("║                                                                                                                      ║");
                    Console.WriteLine("║                                                                                                                      ║");
                    Console.WriteLine("║                                                                                                                      ║");
                    Console.WriteLine("║                                                                                                                      ║");
                    Console.WriteLine("║                                                                                                                      ║");
                    Console.WriteLine("║                              ¿Segur@ que desea salir? s/n_______________                                             ║");
                    Console.WriteLine("║                                                                                                                      ║");
                    Console.WriteLine("║                                                                                                                      ║");
                    Console.WriteLine("║                                                                                                                      ║");
                    Console.WriteLine("║                                                                                                                      ║");
                    Console.WriteLine("║                                                                                                                      ║");
                    Console.WriteLine("║                                                                                                                      ║");
                    Console.WriteLine("║                                                                                                                      ║");
                    Console.WriteLine("║                                                                                                                      ║");
                    Console.WriteLine("║                                                                                                                      ║");
                    Console.WriteLine("║                                                                                                                      ║");
                    Console.WriteLine("║                                                                                                                      ║");
                    Console.WriteLine("║                                                                                                                      ║");
                    Console.WriteLine("║                                                                                                                      ║");
                    Console.WriteLine("║                                                                                                                      ║");
                    Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                    Console.SetCursorPosition(65, 14);
                    opcion_si_no:
                    try
                    {
                        opcion = Convert.ToString(Console.ReadLine());
                    }
                    catch
                    {
                        Console.SetCursorPosition(50, 27);
                        Console.WriteLine("Dato ingresado inválido");
                        goto opcion_si_no;
                    }
                    if (opcion == "s" || opcion == "S")
                    {
                        return;
                    }
                    else
                    {

                        goto menu_principal;
                    }

                }
            }

            




            Console.ReadKey(); 
                Console.Clear();

        }
        static string[,] cargarnivel(string[,] a)
        {
            for (int i = 0; i < a.GetLength(1); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == 0 || j == 0 || i + 1 == a.GetLength(1) || j + 1 == a.GetLength(1))
                    {
                        a[i, j] = sMarco; //Marco
                    }
                    else
                    {
                        a[i, j] = sVacio; //Interior Tablero
                    }
                }
            }
            return a;
        }
        static string[,] cargarobstaculos(string[,] a)
        {
            int cantO_F = 1;
            contador = 1;
            while (obstaculos > 0)
            {
                for (int i = 0; i < a.GetLength(1); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        numero = r.Next(0, 2) % 2;
                        if (a[i, j] == sVacio && numero == 0 && obstaculos > 0 && (cantO_F <= limiteX_Y || contador > 1))
                        {
                            if (i == 1 || (i > 1 && a[i - 1, j] == sVacio) || contador > 1)
                            {
                                a[i, j] = "obstaculo"; //Colocar Obstaculos
                                obstaculos = obstaculos - 1;
                                cantO_F = cantO_F + 1;
                            }
                        }
                    }
                    cantO_F = 1;
                }
                contador = contador + 1;
            }
            return a;
        }
        //Enemigos
        static string[,] cargarenemigos(string[,] a)
        {
            int cantE_F = 1;
            contador = 1;
            while (enemigos > 0)
            {
                for (int i = 0; i < a.GetLength(1); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        numero = r.Next(0, 2) % 2;
                        if (a[i, j] == sVacio && numero == 0 && enemigos > 0 && (cantE_F <= limiteX_Y || contador > 1))
                        {
                            if (i == 1 || (i > 1 && a[i - 1, j] == sVacio) || contador > 1)
                            {
                                a[i, j] = "enemigo"; //Colocar Enemigos
                                enemigos = enemigos - 1;
                                cantE_F = cantE_F + 1;
                            }

                        }
                    }
                    cantE_F = 1;
                }
                contador = contador + 1;
            }
            return a;
        }
        static string[,] cargarestrella(string[,] a)
        {
            contador = 0;
            for (int i = 0; i < a.GetLength(1); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    numero = r.Next(0, 2) % 2;
                    if (a[i, j] == sVacio && numero == 0 && contador == 0)
                    {
                        a[i, j] = "fin" ; //Colocar Estrella
                        contador = 1;
                    }
                }
            }
            return a;
        }
        //Personaje
        static string[,] cargarpersonaje(string[,] a)
        {
            contador = 0;
            for (int i = 0; i < a.GetLength(1); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    numero = r.Next(0, 2) % 2;
                    if (a[i, j] == sVacio & numero == 0 & contador == 0)
                    {
                        a[i, j] = personaje; //Colocar Personaje
                        posicion_x = i;
                        posicion_y= j;
                        contador = 1;
                    }
                }
            }
            return a;
        }
        //Mostrar Nivel
        static string[,] mostrarnivel(string[,] a)
        {
            for (int i = 0; i < a.GetLength(1); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] == personaje)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    if (a[i, j] == "enemigo")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    if (a[i, j] == "obstaculo")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    if (a[i, j] == sMarco)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    if (a[i, j] == "fin")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    Console.Write(a[i, j]+"\t");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine("\n");
            }
            return a;
        }
    }
}
