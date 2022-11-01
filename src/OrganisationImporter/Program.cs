using CommandLine;
using Microsoft.Extensions.DependencyInjection;
using OrganisationImporter.Models;
using OrganisationImporter.Services;

var services = new ServiceCollection()
    .AddSingleton<OrganisationImportService>();

Parser
    .Default
    .ParseArguments<CommandLineArgs>(args)
    .WithParsedAsync(parsedArgs =>
    {
        var organisationImportService = services
            .BuildServiceProvider()
            .GetService<OrganisationImportService>();

        return organisationImportService!.ImportFromUrl(parsedArgs.Url);
    });