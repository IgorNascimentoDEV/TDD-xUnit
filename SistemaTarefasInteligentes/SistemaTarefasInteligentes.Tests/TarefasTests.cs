using Domain.Entidades;

namespace SistemaTarefasInteligentes.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CriarTarefaComSucesso()
        {
            // Arrange
            var titulo = "Teste";
            var descricao = "Descrição";
            var dataVencimento = DateTime.Now;
            var prioridade = 1;
            var etiquetas = new List<string>() { "Teste 1", "Teste 2"};

            //Act
            var tarefa = new Tarefa(titulo, descricao, dataVencimento, prioridade, etiquetas);

            //Assert 
            Assert.Equal(tarefa.Titulo, titulo);
            Assert.Equal(tarefa.Descricao, descricao);
            Assert.Equal(tarefa.DataVencimento, dataVencimento);
        }
    }
}