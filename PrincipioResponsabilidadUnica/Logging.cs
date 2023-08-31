using Serilog;

namespace PrincipioResponsabilidadUnica
{
    public class ILogging
    {
        public void Informacion(string mensaje) {
            Log.Information(mensaje);
        }

        public void Error(string mensaje, Exception ex) {
            Log.Error(ex, mensaje);
        }

        public void Fatal(string mensaje) { Log.Fatal(mensaje); }
    }
}
