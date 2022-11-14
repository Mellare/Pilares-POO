public abstract class Funcionario{
    public int NumeroCadastro { get; private set; }
    public string Nome { get; set; }
    public string GrauDeFormacao { get; set; } = "";
    public List<string> Conhecimentos { get; set; } = new List<string>();
    public List<string> AreasDeAtuacao { get; set; } = new List<string>();
}