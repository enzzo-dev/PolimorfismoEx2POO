namespace PolimorfismoEx2POO.classes
{
    public class Taxas
    {
        public abstract class Taxa{

            private float valor;
            public virtual string ValeRefeicao(){
                return "A taxa a ser paga é de 5%";
            }
        }
    }
}