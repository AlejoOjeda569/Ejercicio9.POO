namespace ArrayCircunferencia.Utilidades
{
    public class Circunferencia
    {
        private double _radio;

        private double _valorRadio;

        public Circunferencia()
        { 

        }
        public Circunferencia(double valorArea) 
        {
              _valorRadio = valorArea;
        }

        public bool Validar() 
        {
           return _valorRadio > 0;
        }
       
        public double GetRadio() => _valorRadio;

        public void SetRadio(double radio)
        {
            if (radio>0)
            {
               _valorRadio = radio;
            }
           
        }

        public double GetPerimetro() => Math.Truncate(2 * Math.PI * _valorRadio);

        public double GetArea() =>Math.Truncate(Math.PI * (Math.Pow( _valorRadio,2)));
       
    }
}