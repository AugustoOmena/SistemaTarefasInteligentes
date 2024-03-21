namespace SistemaTarefasInteligentes
{
    public class UnitTest1
    {
        [Fact]
        public void CriarTarefasComSucesso()
        {
            var titulo = "Teste";
            var descricao = "Descrição";
            var dataVencimento = DateTime.Now;
            var prioridade = 1;
            var etiquetas = new List<string>() { "Teste1", "Teste2"};

            //var tarefa = new Tarefa();
        }
    }
}