using OrganisationImporter.Services;
using FluentAssertions;
using Xunit;
using AutoFixture.Xunit2;
using System;
using System.Threading.Tasks;

namespace OrganisationImporterTests.Services;

public static class OrganisationImportServiceTests
{
    [Theory]
    [AutoData]
    public static Task ImportFromUrl_Returns(
        Uri importUrl,
        OrganisationImportService service)
        => service.Invoking(x => x.ImportFromUrl(importUrl)).Should().NotThrowAsync();
}