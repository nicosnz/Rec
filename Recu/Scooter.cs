namespace Recu{
    class Scooter:Transporte{

        string tipoCombustible;
        public Scooter(string nombreTrans,string tipoTrans, string tipoCombus):base(nombreTrans,tipoTrans){
            tipoCombustible = tipoCombus;
        }
        public override void moverse()
        {
            Console.WriteLine($"\tAvanzando {tipoCombustible}");
        }



    }


}