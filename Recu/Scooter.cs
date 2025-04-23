namespace Recu{
    class Scooter:Transporte{

        string tipoCombustible;
        public Scooter(string tipo, string tipoCombus):base(tipo){
            tipoCombustible = tipoCombus;
        }
        public override void moverse()
        {
            Console.WriteLine($"\tAvanzando {tipoCombustible}");
        }



    }


}