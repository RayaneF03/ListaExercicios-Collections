namespace ListaExercicios_Collections
{
    public class tarefas
    {
        public tarefas(int horario, string compromissos)
        {
            this.Horario = horario;
            this.Compromissos = compromissos;
        }

        public int Horario { get; set; }
        public string? Compromissos { get; set; }
    }
}