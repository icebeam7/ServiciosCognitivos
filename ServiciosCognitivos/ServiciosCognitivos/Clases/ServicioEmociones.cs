using Microsoft.ProjectOxford.Emotion;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ServiciosCognitivos.Clases
{
    public class ServicioEmociones
    {
        static string key = "e9a0c54206424ea1a0e4b0c9f8b9e7c2";

        public static async Task<Dictionary<string, float>> ObtenerEmociones(Stream stream)
        {
            EmotionServiceClient cliente = new EmotionServiceClient(key);
            var emociones = await cliente.RecognizeAsync(stream);

            if (emociones == null || emociones.Count() == 0)
                return null;

            return emociones[0].Scores.ToRankedList().ToDictionary(x => x.Key, x => x.Value);
        }
    }
}