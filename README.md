# Desktop Chat App

A desktop chat application built with **WPF** (Windows Presentation Foundation) using the **MVVM** (Model-View-ViewModel) design pattern. The backend is powered by **.NET**.

## Features

- Basic chat functionality (send and receive messages)
- User authentication and management
- Simple, modern UI using WPF

## Technologies Used

- **Frontend**: WPF, MVVM
- **Backend**: .NET (ASP.NET Core for server-side logic)
- **Database**: [SQL Server, SQLite]
- **Authentication**: [ JWT (JSON Web Tokens)]

## Setup & Installation

### Prerequisites

- .NET SDK 6.0 or higher
- Visual Studio 2019 or later
- SQL Server 

### Client (Desktop App)

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/Desktop_Chatapp.git
Open the project in Visual Studio.

Restore NuGet packages:

bash
Copy code
dotnet restore
Build and run the application:

bash
Copy code
dotnet build
dotnet run
Server (API)
Navigate to the server folder in the repository.

Set up your database and configure connection strings in appsettings.json.

Run the server:

bash
Copy code
dotnet run
Contributing
Feel free to fork the repository and submit pull requests for bug fixes, improvements, or new features.

License
This project is licensed under the MIT License - see the LICENSE file for details.

sql
Copy code

This version of the `README.md` reflects the current state of the application (without real-time  messaging yet), provides the necessary setup instructions, and gives room for future updates when real-time communication is added.
