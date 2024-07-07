namespace Rx.Http.CodeGen.Tests;

public abstract class FileGenerationTests
{
    public string ReadInputFile(string filename)
    {
        return File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Files", "Inputs", filename));
    }

    public string ReadOutputFile(string @namespace, string filename)
    {
        return File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Files", "Output", @namespace, filename));
    }

    public string ReadModelFile(string @namespace, string filename)
    {
        return File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Files", "Output", @namespace, "Models", filename));
    }
}