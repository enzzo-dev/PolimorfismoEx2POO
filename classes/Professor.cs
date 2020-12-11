namespace PolimorfismoEx2POO.classes
{
    public class Professor : Taxas
    {
        public string turma;

        public virtual void ValeRefeicao(){
            System.Console.WriteLine($"A taxa a ser paga é de 10%");
        }
    }
}