namespace Domain.Entidades
{
    public class Tarefa
    {
        public string Titulo {get;set;}
        public string Descricao { get; set; }
        public DateTime DataVencimento { get; set; }
        public int Prioridade { get; set; }
        public List<string> Etiquetas { get; set; } = new List<string>();


        public Tarefa(string titulo, string descricao, DateTime dataVencimento, int prioridade, List<string> etiquetas)
        {
            Titulo = titulo ?? throw new ArgumentNullException(nameof(titulo));
            Descricao = descricao;
            DataVencimento = dataVencimento;
            Prioridade = prioridade;
            Etiquetas = etiquetas;
        }
    }
}