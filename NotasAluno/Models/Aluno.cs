namespace NotasAluno.Models
{
    public class Aluno
    {
        public string Nome {get; set;}
        public int Idade {get; set;}
        public string Disciplina {get; set;}
        public double Nota {get; set;}

        public bool Aprovado(){
            return Nota >= 6;
        }
    }
}