using System.Collections.Generic;


namespace NotasAluno.Models
{
    public static class BaseDados
    {
        public static List<Aluno> alunos = new List<Aluno>();
        public static void Adicionar(Aluno aluno){
            alunos.Add(aluno);
        }

        public static List<Aluno> Listar(){
            return alunos;
        }


        public static Aluno PegaAluno(int index){
            return alunos[index];
        }
        public static int Index(Aluno aluno){
            return alunos.IndexOf(aluno);
        }
    }
}