using System;

namespace aularecuperaçao 
{ 
public class Aluno: pessoa 
  {
    public double _matricula;
     public double Matricula
     {  
       get

        return this._matricula 
     
    public aluno (string Nome, double matricula ): base(Nome)
     }   
     this.Matricula = matricula;
    {  
     public override void imprimir ();
      Console.WriteLine ("matricula: {0}", this.matricula);
    } 
  }
}

