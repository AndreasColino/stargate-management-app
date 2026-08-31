using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms; // ← ajoute cette ligne

namespace Form_Sae24_Stargate
{
    public static class FontHelper
    {
        private static PrivateFontCollection _pfc = new PrivateFontCollection();
        private static bool _loaded = false;

        public static Font GetOrbitron(float taille, FontStyle style = FontStyle.Bold)
        {
            if (!_loaded)
            {
                string path = System.IO.Path.Combine(
                    Application.StartupPath, "Images", "Fonts", "Orbitron-VariableFont_wght.ttf");
                _pfc.AddFontFile(path);
                _loaded = true;
            }
            return new Font(_pfc.Families[0], taille, style);
        }
    }
}