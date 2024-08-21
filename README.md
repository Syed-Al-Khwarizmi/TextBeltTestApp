# TextBeltTestApp

**TextBeltTestApp** is a simple console application built using .NET, designed to send SMS messages using the TextBelt API. This application demonstrates how to interact with a third-party SMS service through HTTP requests, manage configuration settings securely, and handle exceptions effectively.

## Table of Contents

- [Features](#features)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Configuration](#configuration)
- [Usage](#usage)
- [Contributing](#contributing)

## Features

- **Send SMS Messages:** Easily send SMS messages using the TextBelt API.
- **Configuration Management:** Securely manage API keys and other configurations using `appsettings.json`.
- **Exception Handling:** Comprehensive error handling for network requests and API interactions.
- **Modular Codebase:** Follows best practices with a modular and object-oriented approach.

## Prerequisites

To build and run this application, you need:

- [.NET SDK 6.0+](https://dotnet.microsoft.com/download)
- A TextBelt API key (You can get one from [TextBelt](https://textbelt.com/))

## Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/Syed-Al-Khwarizmi/TextBeltTestApp.git
   ```

2. Navigate to the project directory:

   ```bash
   cd TextBeltTestApp
   ```

3. Restore the required packages:

   ```bash
   dotnet restore
   ```

## Configuration

Before running the application, configure your API settings in `appsettings.json`. Here's an example:

```json
{
  "TextBeltSettings": {
    "ApiUrl": "http://textbelt.com/text",
    "ApiKey": "your_api_key_here",
    "Sender": "YourSenderID"
  }
}
```

- **ApiUrl:** The API endpoint for TextBelt.
- **ApiKey:** Your TextBelt API key.
- **Sender:** The sender ID for your messages (if applicable).

> **Note:** Ensure that `appsettings.json` is not tracked by Git by adding it to `.gitignore`, especially if it contains sensitive information like your API key.

## Usage

To send an SMS message using the application:

1. Open your terminal in the project directory.
2. Build and run the application:

   ```bash
   dotnet run
   ```

3. The application will send an SMS using the configuration provided in `appsettings.json`.

## Contributing

Contributions are welcome! Please fork the repository and use a feature branch. Pull requests are warmly welcome.

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Create a new Pull Request
