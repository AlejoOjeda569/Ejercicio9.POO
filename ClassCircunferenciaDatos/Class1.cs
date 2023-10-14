using ArrayCircunferencia.Utilidades;

namespace ClassCircunferenciaDatos
{
    public class ReprositorioCirculos
    {
        private List<Circunferencia> ListaCirculos;

        public ReprositorioCirculos()
        {
            ListaCirculos = new List<Circunferencia>();
            
        }

        public void Agregar(Circunferencia circulo)
        {
            
            ListaCirculos.Add(circulo);
        } 
        public int GetCantidad() 
        {
          return ListaCirculos.Count;
        }
        public void Borrar(Circunferencia circulo)
        {
            ListaCirculos.Remove(circulo);
        }
    }
}