sing System.Collections.Generic;
namespace aularecuparaçao
{
    public class Turma : iimprimivel
    {
        private string _nome;
        private string _email;
        private List<Item> Itens;
    { 
      public double Nome
        {
            get

        return this._nome
          }
       public double Email
        {
            get

        return this._email
          }



     public Turma(string nome, string email,);
       this.nome = nome;
       this.email = email;
       this.Itens = new List<alunos>();
        
        public void adicionarAluno(Aluno aluno);
        {

         this._aluno.add(aluno); 

        }
    public void imprinir()
    {

        Console.WriteLine("Turma: {0}", this.nome);
        Console.WriteLine("Serie: {0}", this.serie);
        Console.WriteLine("professores: {0} e {1}", this.professor1.Nome, this.professor2.Nome);
        Console.WriteLine("Alunos:");
        foreach (var aluno in this._aluno)
        {
            Console.Write(aluno.Nome);




            foreach (var iten aluno in  Item );

        }

    }



}
