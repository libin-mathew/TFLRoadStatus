# TFL Road Status Finder
A console application powered by the TFL open data REST API to get the Road status update. Application takes Road Code as the input and prints the Road Status details such as Road Status and Road Status Description.

### Prerequisites
Install the following:
- .NET Core SDK. The SDK also includes the Runtime.
-  Visual Studio 2019 version 16.11
-  Github tool 

### Additional Nuget Packages
Requires following Nuget Packages to run the application.
- Newtonsoft.Json 13.0.1
- Microsoft.Extensions.Configuration

### Configuring TFL API Information
Follow the steps:
- Open the project in Visual Studio and locate appsettings.json file under TFLRoadStatus project.
- Configure the file with your TFL API Key by updating the settings key value of TFLApiKey.
- Configure the file with your Application Key by updating the settings key value of AppKey.

If you don't have a TFL API key, you will need to register for a developer key here: https://api-
portal.tfl.gov.uk/

### How to build the code
Follow the steps:
- Clone the repository to your local machine using the git command ***$ git clone https://github.com/libin-mathew/TFLRoadStatus***
- Open Visual Studio Command Prompt and change directory to the Solution Root Directory and run command ***dotnet build***

### How to run the output
Follow the steps:
- Open Visual Studio Command Prompt and change directory to the TFLRoadStatus Project Directory.
- Run the command ***dotnet run***
- Provide the Road code and hit enter. The application will List the Road Status and Status Description.
- Application will return an informative error if the user provides an invalid Road Code.
- To fetch the exit code in window machine, run command ***echo Exit Code is %errorlevel%***

### How to Run Unit Test
Project TFLRoadStatusTest constains the unit test class. Unit Project is using NUnit Test package.
Follow the steps:
- Open the Test Explorer.
- Run the Test Methods
