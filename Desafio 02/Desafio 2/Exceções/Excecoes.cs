public interface IExcecoes
{
    void TratamentoExcecoes(Exception ex);
}
public class Excecoes : IExcecoes
{
    public void TratamentoExcecoes(Exception ex)
    {
        System.Console.WriteLine($"Ocorreu um erro. Erro: {ex.Message}");
    }
}