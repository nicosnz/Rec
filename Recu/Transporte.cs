namespace Recu{
    class Transporte{

        private string nombreTransporte;
        private string tipoTransporte;

        public Transporte(string nombre,string tipoTrans){
            nombreTransporte = nombre;
            tipoTransporte = tipoTrans;
        }
        public virtual void moverse(){
            Console.WriteLine("El vehiculo se esta moviendo");
        }
        public string getNombre(){
            return nombreTransporte;
        }
        public string getTipo(){
            return tipoTransporte;
        }
    }



}