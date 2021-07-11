using System;
  
   namespace aularecuperaçao 
 {   
   public class abstract  Pessoa :iimprimivel  
   {  
     protected string _nome;
     public string Nome
     {   
       get
       {
         return _nome


      }
       public pessoa (string Nome)
    {    
    this.Nome = nome;
     public virtual void imprimir();
    }
      Console.WriteLine ("nome: {0}",this.nome);
      
    }
} 
