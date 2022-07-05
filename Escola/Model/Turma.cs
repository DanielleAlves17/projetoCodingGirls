using System.Text.Json.Serialization;

namespace Escola.Model
{
    public class Turma
    {
        public int id { get; set; }
        public string nome { get; set; }

        public bool ativo { get; set; }

        public virtual List<Aluno>? Alunos { get; set; }


    }
}
