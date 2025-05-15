# 📚 StringManipulation

A C# .NET application demonstrating various string manipulation operations through a clean, testable command-line interface.

![.NET](https://img.shields.io/badge/.NET-512BD4?logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?logo=c-sharp&logoColor=white)
![xUnit](https://img.shields.io/badge/xUnit-512BD4?logo=xunit&logoColor=white)
![Coverage](https://img.shields.io/badge/coverage-80.5%25-brightgreen)
![License](https://img.shields.io/badge/license-MIT-blue)

## 🔍 Overview

StringManipulation is a console application that provides a collection of string manipulation utilities ranging from basic operations (concatenation, reversal) to more advanced functionality (Roman numeral conversion, pluralization). The system serves as an example implementation of a well-structured C# application.

**Key Features:**
- 🏗️ Clean separation of concerns
- 🔌 Interface-based design
- ✅ Comprehensive unit testing
- 📦 External library integration
- 📝 Logging capabilities

## 🏛️ Architecture

The system follows clean architecture principles:
StringManipulation/
├── Core/
│ ├── Interfaces/ # IStringOperations, IFileReaderConector
│ └── Services/ # StringOperations, FileReaderConector
├── Infrastructure/ # Logger implementation
└── Program.cs # Console interface


## ✨ Features

| Icon | Operation               | Description                          |
|------|-------------------------|--------------------------------------|
| 🔗  | Concatenation           | Combine multiple strings             |
| 🔄  | Reversal                | Reverse string contents              |
| 📏  | Length                  | Get string length                    |
| 🏛️  | Roman numerals          | Convert to/from Roman numerals       |
| 🔤  | Pluralization           | Convert words to plural form         |
| 📄  | File reading            | Read and process text files          |
| ✂️  | Truncation              | Shorten strings with ellipsis        |
| 🧹  | Whitespace removal      | Clean extra spaces                   |
| 🔍  | Palindrome check        | Detect palindrome words              |

## 🛠️ Technologies

### Core Stack
![.NET Core](https://img.shields.io/badge/-512BD4?logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/-239120?logo=c-sharp&logoColor=white)

### Testing
![xUnit](https://img.shields.io/badge/-512BD4?logo=xunit&logoColor=white)
![Moq](https://img.shields.io/badge/-black?logo=moq&logoColor=white)

### Dependencies
![Humanizer](https://img.shields.io/badge/-lightgrey?logo=nuget&logoColor=white)
![Microsoft Logging](https://img.shields.io/badge/-lightgrey?logo=microsoft&logoColor=white)

## 🚀 Getting Started

### Prerequisites
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download)

### Installation
```bash
git clone https://github.com/Gaitan19/UnitTestNet-example.git
cd UnitTestNet-example
dotnet restore
```
### Running
```bash
dotnet run --project StringManipulation
```
### Testing
```bash
dotnet test StringManipulation.Tests
```
### Coverage Report
```bash
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura
dotnet reportgenerator -reports:coverage.cobertura.xml -targetdir:CoverageReport
```
