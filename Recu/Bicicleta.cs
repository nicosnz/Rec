namespace Recu{
    class Bicicleta:Transporte{

        string tipoCombustible;
        public Bicicleta(string tipo, string tipoCombus):base(tipo){
            tipoCombustible = tipoCombus;
        }
        public override void moverse()
        {
            Console.WriteLine($"\tManejando usando los {tipoCombustible}");
        }



    }


}