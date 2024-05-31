using PdfSharp.Fonts;
using System.IO;

public class FontResolver : IFontResolver
{
    public string DefaultFontName => "Arial";

    public FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
    {
        string path = "c:\\windows\\fonts\\";
        string suffix = "";

        if (isBold && isItalic)
            suffix = "bi";
        else if (isBold)
            suffix = "bd";
        else if (isItalic)
            suffix = "i";

        path += familyName.ToLower() + suffix + ".ttf";

        return new FontResolverInfo(Path.GetFileNameWithoutExtension(path));
    }

    public byte[] GetFont(string faceName)
    {
        string path = $"c:\\windows\\fonts\\{faceName}.ttf";
        using (FileStream fs = File.OpenRead(path))
        {
            byte[] bytes = new byte[fs.Length];
            fs.Read(bytes, 0, bytes.Length);
            return bytes;
        }
    }
}
