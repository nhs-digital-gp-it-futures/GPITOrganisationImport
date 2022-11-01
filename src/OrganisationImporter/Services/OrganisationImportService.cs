namespace OrganisationImporter.Services;

public class OrganisationImportService
{
    public Task ImportFromUrl(Uri url)
    {
        Console.WriteLine($"Received {url}");

        return Task.CompletedTask;
    }
}