using System;
using System.collections.Generic;
{

  class Mainclass

{
    public static void Main(string[] args)
    {
        Aluno aluno1 = new aluno("jo", "A78265139");
        Aluno aluno2 = new aluno("Lala", " A27346133");
        Aluno aluno3 = new aluno(" Lis", "A21312312");
        Aluno aluno4 = new aluno("Lô", "A457238423");
        Aluno aluno5 = new aluno(" Titi", "A382735922");
        Aluno aluno6 = new aluno("Juca ", "A018367541");
        Relatorio relatoriodealunos = new Relatorio("alunos", "relatorio de alunos");
        relatoriodealunos.alunos.add(aluno1);
        relatoriodealunos.alunos.add(aluno2);
        relatoriodealunos.alunos.add(aluno3);
        relatoriodealunos.alunos.add(aluno4);
        relatoriodealunos.alunos.add(aluno5);
        relatoriodealunos.alunos.add(aluno6);
        relatoriodealunos.imprimirrelatorio();

    }


    Professor professor1 = new Professor("Anaxarmandra ", "anax@email.com");
    Professor professor2 = new Professor("Hermenegildo", "herm@email.com");
    Professor professor3 = new Professor("Benevides", "bene@email.com");
        {
        
        Relatorio relatoriodeprofessores = new Relatorio("Professores", "relatorio de Professores");
    relatoriodeprofessores.Professor.add(professor1);
        relatoriodeprofessores.Professor.add(professor2);
        relatoriodeprofessores.Professor.add(professor3);
        relatoriodeprofessores.imprimirrelatorio();
         }

        Turma  turma1 = new turma ("101", "1º série",professor1, professor2);
       turma1.adicionarAluno(aluno1);
        turma1.adicionarAluno(aluno2)
        turma1.adicionarAluno(aluno3)
        { }
      Turma  turma2 = new turma ("201", "2ºserie",professor2, professor3);
      turma1.adicionarAluno(aluno4)
      turma1.adicionarAluno(aluno5)
      turma1.adicionarAluno(aluno6)


     Relatorio relatoriodeturma = new Relatorio("Turna", "relatorio de turma");
       relatoriodeturma.turma.add(turma1);
        relatoriodeturma.turma.add(turma2);
        relatoriodeturma.imprimirrelatorio();
        }
  }

}
