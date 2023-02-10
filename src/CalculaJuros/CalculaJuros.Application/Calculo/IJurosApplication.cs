using CalculaJuros.Core.Calculo;

namespace CalculaJuros.Application.Calculo
{
    public interface IJurosApplication
    {
        double CalculaJurosCompostos(JurosCompostos input);
    }
}
