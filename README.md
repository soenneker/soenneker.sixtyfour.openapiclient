[![](https://img.shields.io/nuget/v/soenneker.sixtyfour.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.sixtyfour.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.sixtyfour.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.sixtyfour.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.sixtyfour.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.sixtyfour.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.sixtyfour.openapiclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.sixtyfour.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Sixtyfour.OpenApiClient

Generated Sixtyfour API client for finding and reversing emails and phone numbers, enriching people and companies, running bulk jobs and workflows, and checking account balance.

## Installation

```bash
dotnet add package Soenneker.Sixtyfour.OpenApiClient
```

For application registration and configuration-based authentication, use `Soenneker.Sixtyfour.OpenApiClientUtil`. Instantiate this package directly when you need to supply your own Kiota request adapter.

## Usage

```csharp
using System.Net.Http.Headers;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Sixtyfour.OpenApiClient;

var httpClient = new HttpClient
{
    BaseAddress = new Uri("https://api.sixtyfour.ai/")
};
httpClient.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", apiKey);

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient)
{
    BaseUrl = httpClient.BaseAddress.ToString().TrimEnd('/')
};

var sixtyfour = new SixtyfourOpenApiClient(adapter);
var balance = await sixtyfour.CheckBalance.GetAsync(
    cancellationToken: cancellationToken);
```

Synchronous endpoints return their result directly. Methods whose names end in `Async` submit background jobs; use the returned job identifier with `JobStatus` to retrieve completion state and results.
