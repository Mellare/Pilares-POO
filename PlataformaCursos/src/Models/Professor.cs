namespace PlataformaCurso.Models;

public class Professor : Funcionario
{
    public Professor(string nome)
    {
        Nome = nome;
    }

    /*public Professor(int NumeroCadastro, string Nome, string GrauDeFormacao)
    {
        this.NumeroCadastro = NumeroCadastro;
        this.Nome = Nome;
        this.GrauDeFormacao = GrauDeFormacao;
    }*/

    public bool ValidaSeSabeConhecimento(string conhecimento)
    {
        return Conhecimentos.Contains(conhecimento);
    }
}