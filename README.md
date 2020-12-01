# Genetec.WebSdk - a simple wrapper for .NET Core

## Usage

```c#

WebSdk webSdk = new WebSdk(client);

```

## Get Cardholder

```c#

Cardholder cardholder = await webSdk.GetEntityAsync<Cardholder>(cardholderGuid);

Console.WriteLine($"FirstName:      {cardholder.FirstName}");
Console.WriteLine($"LastName:       {cardholder.LastName}");
Console.WriteLine($"State:          {cardholder.Status.State}");
Console.WriteLine($"EmailAddress:   {cardholder.EmailAddress}");
Console.WriteLine($"Description:    {cardholder.Description}");

```

## Features
Some of features:

|    |    |    |    |
| ------ | ------ | ------ | ------ |
| GetEntityAsync | CreateEntityAsync | DeleteEntityAsync | EntityConfigurationQuery |

## Entities supported

|    |    |    |    |
| ------ | ------ | ------ | ------ |
| Entity | Cardholder | Credential | EntityConfigurationQuery |
