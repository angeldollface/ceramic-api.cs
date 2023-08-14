# CERAMIC-API.CS :iphone: :lock: :wind_face: :spider_web:

![GitHub CI](https://github.com/angeldollface/ceramic-api.cs/actions/workflows/csharp.yml/badge.svg)

***A small API microservice written in C# to validate IMEI numbers. :iphone: :lock: :wind_face: :spider_web:***

## ABOUT :books:

This project is a microservice to validate IMEI numbers of mobile devices. It offers one route that returns a JSON response. This repository contains the source code in C# for this microservice.

## INSTALLATION :inbox_tray:

Assuming you have the `.NET` SDK version 7 or later installed you can build and run this project on your own machine in the following way:

- 1.) Download the source code:

```bash
git clone https://github.com/angeldollface/ceramic-api.cs
```

- 2.) Change directory into the source's root:

```bash
cd ceramic-api.cs
```

- 3.) Build the project

```bash
dotnet build
```

- 4.) Run the application:

```bash
dotnet run
```

- 5.) Visit the address displayed in your console window and put an IMEI number after the root URL!

## USAGE :hammer:

This microservice offers a single route, `/your_imei`. `your_imei` represents an IMEI number you would like to check. The response is a JSON response of the following structure:

```JSON
{
    "number" : "the IMEI you submitted",
    "result" : "either true or false"
}
```

## CHANGELOG :black_nib:

### Version 0.1.0

- Initial release.
- Upload to GitHub.

# NOTE :scroll:

- *Ceramic-API.cs :iphone: :lock: :wind_face: :spider_web:* by Alexander Abraham :black_heart: a.k.a. *"Angel Dollface" :dolls: :ribbon:*
- Licensed under the MIT license.
