# Genetec.WebSdk - a simple wrapper for .NET Core

## Client configuration

```c#

HttpClientHandler handler = new HttpClientHandler();
handler.Credentials = new NetworkCredential($"{username};{applicationId}", password);

var client = new HttpClient(handler);
client.BaseAddress = new Uri($"{server}:{port}/{baseUri}/");

```

## Usage

```c#

WebSdk webSdk = new WebSdk(client);

```
## Samples

## Get Cardholder

```c#

Cardholder cardholder = await webSdk.GetEntityAsync<Cardholder>(cardholderGuid);

```

## Cardholder Properties

```c#

Console.WriteLine($"FirstName:      {cardholder.FirstName}");
Console.WriteLine($"LastName:       {cardholder.LastName}");
Console.WriteLine($"State:          {cardholder.Status.State}");
Console.WriteLine($"EmailAddress:   {cardholder.EmailAddress}");
Console.WriteLine($"Description:    {cardholder.Description}");

if (cardholder.Status.State == CardholderState.Active)
{
    Console.WriteLine("Cardholder activo");
}

//Cardholder credentials

if (cardholder.Credentials.Collection.Count() < 1)
{
    Console.WriteLine("Cardholder no posee credenciales");
}

foreach (var credential in cardholder.Credentials.Collection)
{
    Console.WriteLine($"Credential Guid:    {credential.Guid}");
}

//Cardholder groups

if (cardholder.Groups.Collection.Count() < 1)
{
    Console.WriteLine("Cardholder no pertenece a ningun groupo");
}

foreach (var group in cardholder.Groups.Collection)
{
    Console.WriteLine($"Group Guid:         {group.Guid}");
}

//Cardholder picture

var picture = cardholder.GetPicture();

if (picture == null)
{
    Console.WriteLine("Cardholder no posee foto.");
}
else
{
    picture.Save("CardholderPicture.jpeg");
}

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

## Dependencies

### Newtonsoft.Json
