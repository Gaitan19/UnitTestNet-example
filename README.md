📚 StringManipulation
A C# .NET application that demonstrates various string manipulation operations through a command-line interface, with a focus on clean architecture, interface-based design, and comprehensive unit testing.

🔍 Overview
StringManipulation is a console application that provides a collection of string manipulation utilities ranging from basic operations (concatenation, reversal) to more advanced functionality (Roman numeral conversion, pluralization). The system serves as an example implementation of a well-structured C# application with:

🏗️ Clean separation of concerns between business logic and user interface
🔌 Interface-based design for testability
✅ Comprehensive unit testing with mocking
📦 Integration with external libraries (Humanizer)
📝 Logging capabilities
📂 Project Structure
The solution consists of two main projects:

StringManipulation: The main application containing the core string manipulation functionality
StringManipulation.Tests: The testing project containing unit tests for the main application
✨ Features
The application provides the following string manipulation operations:

🔗 Concatenate strings
🔄 Reverse string
📏 Get string length
🧹 Remove whitespace
✂️ Truncate string
🔍 Check if a word is palindrome
🔢 Count character occurrences
🔤 Pluralize a word
🔡 Express a quantity in words
🏛️ Convert from Roman numeral to number
📄 Read text file
🏛️ Architecture
The system follows a clean architecture with separation of concerns:

StringOperations: Core class that implements all string manipulation methods
IFileReaderConector: Interface for file reading operations
FileReaderConector: Implementation of the file reader interface
Program: Console interface that orchestrates the operations
🔗 Dependencies
🔷 .NET 8.0
🧩 Humanizer (for pluralization and number-to-words conversion)
📝 Microsoft.Extensions.Logging (for logging capabilities)
🧪 Testing
The project includes comprehensive unit tests using:

🧪 xUnit as the testing framework
🔍 Moq for creating mock objects
📊 Coverlet for generating code coverage reports
📈 ReportGenerator for visualizing code coverage
🚀 Getting Started
Prerequisites
🔷 .NET 8.0 SDK or later
Building the Project
# Clone the repository  
git clone https://github.com/Gaitan19/UnitTestNet-example.git  
cd UnitTestNet-example  
  
# Build the solution  
dotnet build
Running the Application
# Navigate to the main project directory  
cd StringManipulation  
  
# Run the application  
dotnet run
Running the Tests
# Navigate to the test project directory  
cd StringManipulation.Tests  
  
# Run the tests  
dotnet test  
  
# Run tests with coverage  
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura  
  
# Generate coverage report  
dotnet reportgenerator -reports:"./coverage.cobertura.xml" -targetdir:"./CoverageReport" -reporttypes:Html
📊 Code Coverage
The project maintains excellent test coverage:

📈 Line Coverage: 80.5% (62 of 77 lines)
🔀 Branch Coverage: 91.6% (11 of 12 branches)
The StringOperations class has nearly complete coverage across all methods, with only one branch condition in the TruncateString method not fully covered.

🧠 Key Design Principles
The StringManipulation system demonstrates several important software design principles:

🔄 Separation of concerns - String manipulation logic is encapsulated in the StringOperations class, separate from the user interface in Program.cs
🔌 Interface-based design - Dependencies are abstracted through interfaces (IFileReaderConector, ILogger), promoting loose coupling and testability
💉 Dependency injection - The StringOperations class accepts an ILogger through its constructor
✅ Comprehensive testing - All methods have corresponding tests, with edge cases and exceptions tested
🧩 External library integration - The system leverages the Humanizer library for certain operations (pluralization, number-to-words conversion)
