using Domain.Entidades;

namespace SistemaTarefasInteligentes
{
    public class TarefasTests
    {
        [Fact]
        public void CriarTarefasComSucesso()
        {
            var titulo = "Teste";
            var descricao = "Descrição";
            var dataVencimento = DateTime.Now;
            var prioridade = 1;
            var etiquetas = new List<string>() { "Teste1", "Teste2"};

            var tarefa = new Tarefa(titulo, descricao, dataVencimento, prioridade, etiquetas);

            Assert.Equal(titulo, tarefa.Titulo);
            Assert.Equal(tarefa.Descricao, descricao);
            Assert.Equal(tarefa.DataVencimento, dataVencimento);


        }
    }
}