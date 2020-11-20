# Genetec.WebSdk - a simple wrapper for .NET Core

## Usage

```c#

HttpClientHandler handler = new HttpClientHandler();
handler.Credentials = new NetworkCredential($"{username};{applicationId}", password);

var client = new HttpClient(handler);
client.BaseAddress = new Uri($"{server}:{port}/{baseUri}/");

WebSdk webSdk = new WebSdk(client);
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
