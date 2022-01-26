namespace Metaverso
{
    public class Sistema
    {
        public string Meta(int numero) {
            if (numero % 3 == 0 && numero % 5 == 0) {
                return "Metaverso";
            }
            else if (numero % 3 == 0){
                return "Meta";
            }
            else if (numero % 5 == 0){
                return "Verso";
            }
            else {
                return numero.ToString();
            }
        }

         public string Meta(int[] numero) {
            string resultado = "";
            for(int i = 0; i < numero.Length; i++){

            if (numero[i] % 3 == 0){
                resultado = resultado + "Meta ";
            }
            else if (numero[i] % 5 == 0){
                resultado = resultado + "Verso ";
            }
            else if (numero[i] % 3 == 0 && numero[i] % 5 == 0) {
                resultado = resultado + "Metaverso ";
            }
            else {
                return numero[i].ToString()+" ";
            }
        }
        return resultado;
    }


    }
}