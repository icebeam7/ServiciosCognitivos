using System.IO;
using System.Linq;
using Microsoft.ProjectOxford.Vision;
using System.Threading.Tasks;
using Microsoft.ProjectOxford.Vision.Contract;

namespace ServiciosCognitivos.Clases
{
    public class ServicioComputerVision
    {
        static string key = "0919d813892f426d9970f39230f13102";

        public static async Task<AnalysisResult> ObtenerDescripcionImagen(Stream imageStream)
        {
            VisionServiceClient cliente = new VisionServiceClient(key);
            VisualFeature[] features =
            {
                VisualFeature.Tags,
                VisualFeature.Categories,
                VisualFeature.Description,
                VisualFeature.Adult,
                VisualFeature.ImageType,
                VisualFeature.Color,
                VisualFeature.Faces
            };

            return await cliente.AnalyzeImageAsync(imageStream, features.ToList(), null);
        }
    }
}
