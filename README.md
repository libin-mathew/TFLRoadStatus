# TFL Road Status Finder
A console application powered by the TFL open data REST API to get the Road status update. Application takes Road Code as the input and prints the Road details such as Road Status and Road Status Description.

### Prerequisites
Install the following:
- .NET Core SDK. The SDK also includes the Runtime.
-  Visual Studio 2019 version 16.11
-  Github tool 

### Configuring TFL API Information
Follow the steps:
- Open the project in Visual Studio and locate App.config file under TFLRoadStatus project.
- Configure the file with your TFL API Key by updating the settings key value for TFLApiKey
- Configure the file with your Application Key by updating the settings key value for AppKey

### How to build the code
Follow the steps:
- Clone the repository to your local machine using the git command ***$ git clone https://github.com/libin-mathew/TFLRoadStatus***
- Open Visual Studio Command Prompt and change directory to the Solution Root Directory and run command ***dotnet build***

### How to run the output
Follow the steps:
- Open Visual Studio Command Prompt and change directory to the Project Root Directory(TFLRoadStatus\TFLRoadStatus)
- Run the comman ***dotnet run***
- Provide the Road code and hit enter. The application will List the Road Status and Status Description.
- Then the application will return an informative error if the user provides an invalid Road Code.
- To fetch the exit code in window machine, run command ***echo Exit Code is %errorlevel%***
