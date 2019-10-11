using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConjuntosMENU
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }

        private static void menu()
        {
            int dato = 0;
            Console.WriteLine("\n\t\t\t\t\t\t\t Universidad de Occidente");
            Console.WriteLine("\n\t\t\t\t\t\t\t Mazatenango, Suchitepéquez");
            Console.WriteLine("\n\t\t\t\t\t\t\t Conjuntos");
            Console.WriteLine("\n\t\t\t\t\t\t\t SONRÍE YAHSHUA TE AMA");
            Console.WriteLine("_____________________________________________________________________________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine();
           
            Console.WriteLine("1. Nómina de estudiantes");
            Console.WriteLine();
            Console.WriteLine("2. Unión de conjuntos");
            Console.WriteLine();
            Console.WriteLine("3. Intersección de conjuntos");
            Console.WriteLine();
            Console.WriteLine("4. Diferencia de conjuntos");
            Console.WriteLine();
            Console.WriteLine("5. Diferencia Simétrica de conjuntos");
            Console.WriteLine();
            Console.WriteLine("Opción: ");
            dato = Convert.ToInt32(Console.ReadLine());

            switch (dato)
            {
                case 1:
                    {
                        Console.Clear();
                        nominaEstudiantes();
                        break;
                    }

                case 2:
                    {
                        Console.Clear();
                        unionConjuntos();
                        break;
                    }

                case 3:
                    {
                        Console.Clear();
                        interConjuntos();
                        break;
                    }

                case 4:
                    {
                        Console.Clear();
                        diferenciaConjuntos();
                        break;
                    }

                case 5:
                    {
                        Console.Clear();
                        difSimetricaConjuntos();
                        break;
                    }

                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Número incorrecto");
                        break;
                    }
            }

        }

        private static void nominaEstudiantes()
        {
            int dato = 0;
            Console.WriteLine("\n\t\t\t\t\t\t\t Nómina de estudiantes");
            Console.WriteLine();
            Console.WriteLine("--- Patrick Manrique Cubías Quintana ---");
            Console.WriteLine("--- Brandon Estuardo Meneses ---");
            Console.WriteLine("--- Cervando André Martinez Cabrera ---");
            Console.WriteLine("--- Miguel Stuardo Coronado Batres ---");
            Console.WriteLine("--- Alberto Chay ---");
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();

            do
            {
                Console.WriteLine("6. Regresar al menú");
                Console.WriteLine("0. Salir del programa");
                Console.WriteLine("Opción: ");
                dato = Convert.ToInt32(Console.ReadLine());

                if (dato == 6)
                {
                    Console.Clear();
                    menu();
                }
                else if (dato == 0)
                {
                    Environment.Exit(-1);
                }

                Console.Clear();

            } while ((dato != 6) && (dato != 0));
        }

        private static void unionConjuntos()
        {
            int dato = 0, rptaFinal = 0;
            string respuesta = "";
            HashSet<int> conjunto1 = new HashSet<int>();
            HashSet<int> conjunto2 = new HashSet<int>();
            HashSet<int> conjunto3 = new HashSet<int>();

            Console.WriteLine();
            Console.WriteLine("--- Unión de conjuntos ---");
            Console.WriteLine();
            Console.WriteLine("--- Primer Conjunto ---");
            Console.WriteLine();
            do
            {
                Console.WriteLine("Ingrese un elemento: ");
                dato = Convert.ToInt32(Console.ReadLine());
                conjunto1.Add(dato);

                Console.Clear();
                Console.WriteLine("Si desea ingresar otro elemento ingrese si, de lo contrario ingrese no: ");
                respuesta = Console.ReadLine();

               
                Console.Clear();
            } while ((respuesta == "Si") || (respuesta == "si"));


            Console.WriteLine("--- Segundo Conjunto ---");
            Console.WriteLine();
            do
            {
                Console.WriteLine("Ingrese un elemento: ");
                dato = Convert.ToInt32(Console.ReadLine());
                conjunto2.Add(dato);

                Console.Clear();
                Console.WriteLine("Si desea ingresar otro elemento ingrese si, de lo contrario ingrese no: ");
                respuesta = Console.ReadLine();

                
                Console.Clear();
            } while ((respuesta == "Si") || (respuesta == "si"));

            Console.WriteLine("--- Tercer Conjunto ---");
            Console.WriteLine();
            do
            {
                Console.WriteLine("Ingrese un elemento: ");
                dato = Convert.ToInt32(Console.ReadLine());
                conjunto3.Add(dato);

                Console.Clear();
                Console.WriteLine("Si desea ingresar otro elemento ingrese si, de lo contrario ingrese no: ");
                respuesta = Console.ReadLine();

                
                Console.Clear();
            } while ((respuesta == "Si") || (respuesta == "si"));

            do {
                Console.WriteLine("--- Conjunto 1 ---");
                foreach (int i in conjunto1)
                {
                    Console.WriteLine(i);

                }

                Console.WriteLine();

                Console.WriteLine("--- Conjunto 2 ---");
                foreach (int i in conjunto2)
                {
                    Console.WriteLine(i);

                }

                Console.WriteLine();

                Console.WriteLine("--- Conjunto 3 ---");
                foreach (int i in conjunto3)
                {
                    Console.WriteLine(i);

                }

                Console.WriteLine();

                HashSet<int> UnionConjuntos = new HashSet<int>(conjunto1);
                UnionConjuntos.UnionWith(conjunto2);

                HashSet<int> UnionConjuntos2 = new HashSet<int>(UnionConjuntos);
                UnionConjuntos2.UnionWith(conjunto3);

                Console.WriteLine("--- Unión de conjuntos ---");
                foreach (int i in UnionConjuntos2)
                {
                    Console.WriteLine(i);

                }
                Console.ReadKey();
                do
                {
                    Console.Clear();
                    Console.WriteLine("6. Regresar al menú.");
                    Console.WriteLine("7. Visualizar nuevamente los conjuntos.");
                    Console.WriteLine("0. Salir del rpograma.");
                    Console.WriteLine();
                    Console.WriteLine("Opción: ");
                    rptaFinal = Convert.ToInt32(Console.ReadLine());

                    if (rptaFinal == 6)
                    {
                        Console.Clear();
                        menu();
                    }
                    else if (rptaFinal == 0)
                    {
                        Environment.Exit(-1);
                    }
                    Console.Clear();
                } while ((rptaFinal != 6) && (rptaFinal != 0) && (rptaFinal != 7));
            } while (rptaFinal == 7);

        }

        private static void interConjuntos()
        {
            int dato = 0, rptaFinal = 0;
            string respuesta = "";
            HashSet<int> conjunto1 = new HashSet<int>();
            HashSet<int> conjunto2 = new HashSet<int>();
            HashSet<int> conjunto3 = new HashSet<int>();

            Console.WriteLine();
            Console.WriteLine("--- Intersección de conjuntos ---");
            Console.WriteLine();
            Console.WriteLine("--- Primer Conjunto ---");
            Console.WriteLine();
            do
            {
                Console.WriteLine("Ingrese un elemento: ");
                dato = Convert.ToInt32(Console.ReadLine());
                conjunto1.Add(dato);

                Console.Clear();
                Console.WriteLine("Si desea ingresar otro elemento ingrese si, de lo contrario ingrese no: ");
                respuesta = Console.ReadLine();

               
                Console.Clear();
            } while ((respuesta == "Si") || (respuesta == "si"));


            Console.WriteLine("--- Segundo Conjunto ---");
            Console.WriteLine();
            do
            {
                Console.WriteLine("Ingrese un elemento: ");
                dato = Convert.ToInt32(Console.ReadLine());
                conjunto2.Add(dato);

                Console.Clear();
                Console.WriteLine("Si desea ingresar otro elemento ingrese si, de lo contrario ingrese no: ");
                respuesta = Console.ReadLine();

                
                Console.Clear();
            } while ((respuesta == "Si") || (respuesta == "si"));

            Console.WriteLine("--- Tercer Conjunto ---");
            Console.WriteLine();
            do
            {
                Console.WriteLine("Ingrese un elemento: ");
                dato = Convert.ToInt32(Console.ReadLine());
                conjunto3.Add(dato);

                Console.Clear();
                Console.WriteLine("Si desea ingresar otro elemento ingrese si, de lo contrario ingrese no: ");
                respuesta = Console.ReadLine();

                
                Console.Clear();
            } while ((respuesta == "Si") || (respuesta == "si"));

            do
            {
                Console.WriteLine("--- Conjunto 1 ---");
                foreach (int i in conjunto1)
                {
                    Console.WriteLine(i);

                }

                Console.WriteLine();

                Console.WriteLine("--- Conjunto 2 ---");
                foreach (int i in conjunto2)
                {
                    Console.WriteLine(i);

                }

                Console.WriteLine();

                Console.WriteLine("--- Conjunto 3 ---");
                foreach (int i in conjunto3)
                {
                    Console.WriteLine(i);

                }

                Console.WriteLine();

                HashSet<int> interConjuntos = new HashSet<int>(conjunto1);
                interConjuntos.IntersectWith(conjunto2);

                HashSet<int> interConjuntos2 = new HashSet<int>(interConjuntos);
                interConjuntos2.IntersectWith(conjunto3);

                Console.WriteLine("--- Intersección de conjuntos ---");
                foreach (int i in interConjuntos2)
                {
                    Console.WriteLine(i);

                }
                Console.ReadKey();
                do
                {
                    Console.Clear();
                    Console.WriteLine("6. Regresar al menú.");
                    Console.WriteLine("7. Visualizar nuevamente los conjuntos.");
                    Console.WriteLine("0. Salir del rpograma.");
                    Console.WriteLine();
                    Console.WriteLine("Opción: ");
                    rptaFinal = Convert.ToInt32(Console.ReadLine());

                    if (rptaFinal == 6)
                    {
                        Console.Clear();
                        menu();
                    }
                    else if (rptaFinal == 0)
                    {
                        Environment.Exit(-1);
                    }
                    Console.Clear();
                } while ((rptaFinal != 6) && (rptaFinal != 0) && (rptaFinal != 7));
            } while (rptaFinal == 7);
        }

        private static void diferenciaConjuntos()
        {
            int dato = 0, rptaFinal = 0;
            string respuesta = "";
            HashSet<int> conjunto1 = new HashSet<int>();
            HashSet<int> conjunto2 = new HashSet<int>();
            HashSet<int> conjunto3 = new HashSet<int>();

            Console.WriteLine();
            Console.WriteLine("--- Diferencia de conjuntos ---");
            Console.WriteLine();
            Console.WriteLine("--- Primer Conjunto ---");
            Console.WriteLine();
            do
            {
                Console.WriteLine("Ingrese un elemento: ");
                dato = Convert.ToInt32(Console.ReadLine());
                conjunto1.Add(dato);

                Console.Clear();
                Console.WriteLine("Si desea ingresar otro elemento ingrese si, de lo contrario ingrese no: ");
                respuesta = Console.ReadLine();


                Console.Clear();
            } while ((respuesta == "Si") || (respuesta == "si"));


            Console.WriteLine("--- Segundo Conjunto ---");
            Console.WriteLine();
            do
            {
                Console.WriteLine("Ingrese un elemento: ");
                dato = Convert.ToInt32(Console.ReadLine());
                conjunto2.Add(dato);

                Console.Clear();
                Console.WriteLine("Si desea ingresar otro elemento ingrese si, de lo contrario ingrese no: ");
                respuesta = Console.ReadLine();


                Console.Clear();
            } while ((respuesta == "Si") || (respuesta == "si"));

            Console.WriteLine("--- Tercer Conjunto ---");
            Console.WriteLine();
            do
            {
                Console.WriteLine("Ingrese un elemento: ");
                dato = Convert.ToInt32(Console.ReadLine());
                conjunto3.Add(dato);

                Console.Clear();
                Console.WriteLine("Si desea ingresar otro elemento ingrese si, de lo contrario ingrese no: ");
                respuesta = Console.ReadLine();


                Console.Clear();
            } while ((respuesta == "Si") || (respuesta == "si"));

            do
            {
                Console.WriteLine("--- Conjunto 1 ---");
                foreach (int i in conjunto1)
                {
                    Console.WriteLine(i);

                }

                Console.WriteLine();

                Console.WriteLine("--- Conjunto 2 ---");
                foreach (int i in conjunto2)
                {
                    Console.WriteLine(i);

                }

                Console.WriteLine();

                Console.WriteLine("--- Conjunto 3 ---");
                foreach (int i in conjunto3)
                {
                    Console.WriteLine(i);

                }

                Console.WriteLine();

                HashSet<int> diferenciaConjuntos = new HashSet<int>(conjunto1);
                diferenciaConjuntos.ExceptWith(conjunto2);

                HashSet<int> diferenciaConjuntos2 = new HashSet<int>(diferenciaConjuntos);
                diferenciaConjuntos2.ExceptWith(conjunto3);

                Console.WriteLine("--- Diferencia de conjuntos ---");
                foreach (int i in diferenciaConjuntos2)
                {
                    Console.WriteLine(i);

                }
                Console.ReadKey();
                do
                {
                    Console.Clear();
                    Console.WriteLine("6. Regresar al menú.");
                    Console.WriteLine("7. Visualizar nuevamente los conjuntos.");
                    Console.WriteLine("0. Salir del rpograma.");
                    Console.WriteLine();
                    Console.WriteLine("Opción: ");
                    rptaFinal = Convert.ToInt32(Console.ReadLine());

                    if (rptaFinal == 6)
                    {
                        Console.Clear();
                        menu();
                    }
                    else if (rptaFinal == 0)
                    {
                        Environment.Exit(-1);
                    }
                    Console.Clear();
                } while ((rptaFinal != 6) && (rptaFinal != 0) && (rptaFinal != 7));
            } while (rptaFinal == 7);
        }

        private static void difSimetricaConjuntos()
        {
            int dato = 0, rptaFinal = 0;
            string respuesta = "";
            HashSet<int> conjunto1 = new HashSet<int>();
            HashSet<int> conjunto2 = new HashSet<int>();
            HashSet<int> conjunto3 = new HashSet<int>();

            Console.WriteLine();
            Console.WriteLine("--- Diferencia Simétrica de conjuntos ---");
            Console.WriteLine();
            Console.WriteLine("--- Primer Conjunto ---");
            Console.WriteLine();
            do
            {
                Console.WriteLine("Ingrese un elemento: ");
                dato = Convert.ToInt32(Console.ReadLine());
                conjunto1.Add(dato);

                Console.Clear();
                Console.WriteLine("Si desea ingresar otro elemento ingrese si, de lo contrario ingrese no: ");
                respuesta = Console.ReadLine();


                Console.Clear();
            } while ((respuesta == "Si") || (respuesta == "si"));


            Console.WriteLine("--- Segundo Conjunto ---");
            Console.WriteLine();
            do
            {
                Console.WriteLine("Ingrese un elemento: ");
                dato = Convert.ToInt32(Console.ReadLine());
                conjunto2.Add(dato);

                Console.Clear();
                Console.WriteLine("Si desea ingresar otro elemento ingrese si, de lo contrario ingrese no: ");
                respuesta = Console.ReadLine();


                Console.Clear();
            } while ((respuesta == "Si") || (respuesta == "si"));

            Console.WriteLine("--- Tercer Conjunto ---");
            Console.WriteLine();
            do
            {
                Console.WriteLine("Ingrese un elemento: ");
                dato = Convert.ToInt32(Console.ReadLine());
                conjunto3.Add(dato);

                Console.Clear();
                Console.WriteLine("Si desea ingresar otro elemento ingrese si, de lo contrario ingrese no: ");
                respuesta = Console.ReadLine();


                Console.Clear();
            } while ((respuesta == "Si") || (respuesta == "si"));

            do
            {
                Console.WriteLine("--- Conjunto 1 ---");
                foreach (int i in conjunto1)
                {
                    Console.WriteLine(i);

                }

                Console.WriteLine();

                Console.WriteLine("--- Conjunto 2 ---");
                foreach (int i in conjunto2)
                {
                    Console.WriteLine(i);

                }

                Console.WriteLine();

                Console.WriteLine("--- Conjunto 3 ---");
                foreach (int i in conjunto3)
                {
                    Console.WriteLine(i);

                }

                Console.WriteLine();

                HashSet<int> difSimetricaConjuntos = new HashSet<int>(conjunto1);
                difSimetricaConjuntos.SymmetricExceptWith(conjunto2);

                HashSet<int> difSimetricaConjuntos2 = new HashSet<int>(difSimetricaConjuntos);
                difSimetricaConjuntos2.SymmetricExceptWith(conjunto3);

                Console.WriteLine("--- Diferencia Simétrica de conjuntos ---");
                foreach (int i in difSimetricaConjuntos2)
                {
                    Console.WriteLine(i);

                }
                Console.ReadKey();
                do
                {
                    Console.Clear();
                    Console.WriteLine("6. Regresar al menú.");
                    Console.WriteLine("7. Visualizar nuevamente los conjuntos.");
                    Console.WriteLine("0. Salir del rpograma.");
                    Console.WriteLine();
                    Console.WriteLine("Opción: ");
                    rptaFinal = Convert.ToInt32(Console.ReadLine());

                    if (rptaFinal == 6)
                    {
                        Console.Clear();
                        menu();
                    }
                    else if (rptaFinal == 0)
                    {
                        Environment.Exit(-1);
                    }
                    Console.Clear();
                } while ((rptaFinal != 6) && (rptaFinal != 0) && (rptaFinal != 7));
            } while (rptaFinal == 7);
        }
      
    }
}
