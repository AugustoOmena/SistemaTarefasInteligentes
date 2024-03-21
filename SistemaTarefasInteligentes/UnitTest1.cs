using Domain;

namespace SistemaTarefasInteligentes
{
    public class UnitTest1
    {
        [Fact]
        public void CriarTarefasComSucesso()
        {
            var titulo = "Teste";
            var descricao = "Descri��o";
            var dataVencimento = DateTime.Now;
            var prioridade = 1;
            var etiquetas = new List<string>() { "Teste1", "Teste2"};

            var tarefa = new Tarefa(titulo, descricao, dataVencimento, prioridade, etiquetas);

            Assert.Equal(tarefa.Titulo, titulo);
            Assert.Equal(tarefa.Descricao, descricao);
            Assert.Equal(tarefa.DataVencimento, dataVencimento);


        }
    }
}