namespace Recu{
    class Bicicleta:Transporte{

        string tipoCombustible;
        public Bicicleta(string nombreTrans,string tipoTrans, string tipoCombus):base(nombreTrans,tipoTrans){
            tipoCombustible = tipoCombus;
        }
        public override void moverse()
        {
            Console.WriteLine($"\tManejando usando los {tipoCombustible}");
        }



    }


}