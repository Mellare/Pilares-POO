namespace PlataformaCurso.Models;

public class Coordenador : Funcionario
{
    public Coordenador(string nome)
    {
        this.Nome = nome;
    }

    public bool ValidaSeSabeConhecimento(string conhecimento)
    {
        return Conhecimentos.Contains(conhecimento)
            || AreasDeAtuacao.Contains(conhecimento);
    }
}