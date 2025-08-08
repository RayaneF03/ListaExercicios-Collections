namespace ListaExercicios_Collections
{
    public class tarefas  // Classe Aluno
    {
        public tarefas(int horario, string compromissos) // Metodo construtor com parametros
        {
            this.Horario = horario;
            this.Compromissos = compromissos;
        }

        public int Horario { get; set; } // Atributos
        public string? Compromissos { get; set; }
    }
}