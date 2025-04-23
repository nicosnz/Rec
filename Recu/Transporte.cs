namespace Recu{
    class Transporte{

        private string tipoTransporte;

        public Transporte(string tipo){
            tipoTransporte = tipo;
        }
        public virtual void moverse(){
            Console.WriteLine("El vehiculo se esta moviendo");
        }
        public string getTipo(){
            return tipoTransporte;
        }
    }



}