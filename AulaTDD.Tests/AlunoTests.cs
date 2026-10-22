using AulaTDD.Models;
namespace AulaTDD.Tests
{
    public class AlunoTests
    {
        [Test] //Indica quando algo foi testado 
        public void Deve_Aprovar_Aluno_Com_Media_Maior_Ou_Igual_A_Seis()//Primeiro teste 
        {
            //Arrange - Preparação
            var aluno = new Aluno
            {
                Nota1 = 7.0,
                Nota2 = 5.0
            };

            //ACT - Execução
            bool resultado = aluno.EstaAprovado(aluno.CalcularMedia());
            //Assert Verificação
            //Assert.That(resultado, Is.True);
            Assert.IsTrue(
                resultado,
                "O aluno deveria estar aprovado quando a média for maior ou igual a 6"
            );
        }
        [Test]
        public void Deve_Reprovar_Aluno_Com_Media_Menor_Que_Seis()
        {
            //Arrange - Preparação
            var aluno = new Aluno()
            {
                Nota1 = 4.0,
                Nota2 = 5.0
            };
            //ACT - Execução
            bool resultado = aluno.EstaAprovado(aluno.CalcularMedia());
            //Assert Verificação
            Assert.That(resultado, Is.False);
            Assert.IsFalse(
                resultado,
                "O aluno deveria estar reprovado quando a média for menor que 6"
            );
        }
    }
}