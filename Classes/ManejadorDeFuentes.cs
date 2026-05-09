using System;
using System.Drawing;
using System.Drawing.Text;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Linq; // Agregado para facilitar la búsqueda

internal class ManejadorDeFuentes
{
    private static PrivateFontCollection _coleccion;
    public static void Initialize()
    {
        if (_coleccion != null) return;

        _coleccion = new PrivateFontCollection();

        // Lista de recursos a cargar
        string[] recursos = {
            "SGA_Client.Fonts.Bevan-Regular.ttf",
            "SGA_Client.Fonts.Inter-Regular.ttf",
            "SGA_Client.Fonts.Inter-Bold.ttf"
        };

        foreach (var resourceName in recursos)
        {
            CargarFuenteDesdeRecurso(resourceName);
        }
    }

    private static void CargarFuenteDesdeRecurso(string resourceName)
    {
        var assembly = Assembly.GetExecutingAssembly();
        using (var stream = assembly.GetManifestResourceStream(resourceName))
        {
            if (stream == null) return; // O lanzar excepción si es crítico

            byte[] fontData = new byte[stream.Length];
            stream.Read(fontData, 0, fontData.Length);
            IntPtr data = Marshal.AllocCoTaskMem(fontData.Length);
            Marshal.Copy(fontData, 0, data, fontData.Length);

            _coleccion.AddMemoryFont(data, fontData.Length);

            Marshal.FreeCoTaskMem(data);
        }
    }

    /// <summary>
    /// Obtiene una fuente específica. 
    /// </summary>
    /// <param name="familyName">Nombre de la familia (ej: "Inter", "Bevan")</param>
    public static Font GetFont(string familyName, float size, FontStyle style = FontStyle.Regular)
    {
        if (_coleccion != null)
        {
            // Buscamos la familia por nombre dentro de la colección cargada
            var family = _coleccion.Families.FirstOrDefault(f => f.Name.Equals(familyName, StringComparison.OrdinalIgnoreCase));

            if (family != null)
            {
                return new Font(family, size, style);
            }
        }

        // Font de respaldo si no se encuentra la personalizada
        return new Font("Microsoft Sans Serif", size, style);
    }

    public static void Dispose()
    {
        _coleccion?.Dispose();
        _coleccion = null;
    }
}