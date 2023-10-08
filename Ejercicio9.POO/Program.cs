using ArrayCircunferencia.Utilidades;

namespace Ejercicio9.POO
{
    internal class Program
    {
       /*Almacenar en un array distintas circunferencias.
           *Mostar sus areas y sus perimetros
           */
        
        static void Main(string[] args)
        {

            Circunferencia[] arraycirculos = new Circunferencia[3];
            for (int i = 0; i < arraycirculos.Length; i++) 
            {

                do
                {
                    Console.Write($"Ingrese el Radio del {i + 1}° circulo:");
                    var area = double.Parse(Console.ReadLine());
                    Circunferencia circunferenciaCreada = new Circunferencia(area);
                    if (circunferenciaCreada.Validar())
                    {
                       arraycirculos[i] = circunferenciaCreada;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Radio no es valido");
                    }
                    
                } while (true);
               
            }

            Console.Write("Ingrese el numero del cuadrado a modificar:");
            var index = int.Parse(Console.ReadLine());
            var circuloEditar=arraycirculos[index];
            Console.Write("Ingrese nueva medida:");
            var nuevaMedida = int.Parse(Console.ReadLine());
            circuloEditar.SetRadio(nuevaMedida);
            
            Console.Clear();
            foreach (var item in arraycirculos)
            {
                Console.WriteLine($"Circunferencia de Radio: {item.GetRadio()} - Area:{item.GetArea()} - Perimetro:{item.GetPerimetro() }");
               
            }

            
        }
    }
}