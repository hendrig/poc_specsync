# POC - SpecSync and SpecFlow

This is a Proof of Concept (POC) for the usage of [SpecSync](https://www.specsolutions.eu/specsync/) and [SpecFlow](https://specflow.org/) with .NET.

## General Configuration

In order to run this project you need to install and configure `SpecSync`.
You will also need a Microsoft Test Management (MTM) account on Azure DevOps and a license of the type "Basic + Test Plans".

### Generating a PAT

In order to run the tool, you will need to generate a PAT for the project you want to sync. The PAT file needs to have the following permissions:
- Work Itens (Read & write)
- Test Management (Read & write)
- Build (Read)
- Release (Read)

### SpecSync Installation

On your local machine, run the following commands:
- `dotnet new tool-manifest` (it creates a dotnet-tools.json file)
- `dotnet tool install SpecSync.AzureDevOps`

With the PAT token and the project URL in hands, run the command `dotnet specsync init` and follow the instructions on it.

After running it, please change the specsync.json file to add the Test Suite name and id, as follows

```json
{
  "$schema": "https://schemas.specsolutions.eu/specsync4azuredevops-config-latest.json",
  "compatibilityVersion": "3.4",
  "remote": {
    "projectUrl": "https://dev.azure.com/hendrigwernner/mtm2Gherkin",
    "testSuite": {
      "name": "Calculator",
      "testPlanId": 23
    }
  }
}
```

## Synching the scenarios

In order to sync your Gherkin scenarions in the MTM, run the command `dotnet specsync push`.

## Running the tests

To run the tests, execute the command `dotnet test --logger:"trx;LogFileName=C:\temp\testResult.trx"`

## Publishing the test

To publish the test results, run the command bellow:
`dotnet specsync publish-test-results --testResultFile C:\temp\testResult.trx`