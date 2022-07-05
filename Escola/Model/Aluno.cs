using System.Text.Json.Serialization;

namespace Escola.Model
{
    public class Aluno
    {
        public int id { get; set; }
        public string nome { get; set; }

        public DateTime dataNascimento { get; set; }

        public char sexo { get; set; }

        public int totalFaltas { get; set; }

        public int turmaId { get; set; }

        //[JsonIgnore]
        public virtual Turma? Turma { get; set; }

    }
}
