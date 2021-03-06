using System;
using System.Diagnostics;
using System.Threading;

namespace NFApp1
{
    public class Program
    {
        public static void Main()
        {
            const int TRIGGER_PIN_SAIDA = 26;
            const int ECHO_PIN_ENTRADA = 27;

            try
            {
                HCSR04 device = new HCSR04(TRIGGER_PIN_SAIDA, ECHO_PIN_ENTRADA);

                while (true)
                {
                    float distancia = device.ObterDistancia();

                    Debug.WriteLine($"{distancia}");

                    Thread.Sleep(TimeSpan.FromSeconds(1));
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"FALHA: {ex.Message}");
            }

            Thread.Sleep(Timeout.Infinite);
        }
    }
}
