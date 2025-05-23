﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Moq;

namespace StringManipulation.Tests
{
    public class StringOperationsTest
    {

        [Fact]
        public void ConcatenateStringsTest()
        {
            // arrange
            var strOperation = new StringOperations();

            // act
            var result = strOperation.ConcatenateStrings("Hello", "World");

            // assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal("Hello World", result);
        }

        [Fact]
        public void ReverseStringTest()
        {
            // arrange
            var strOperation = new StringOperations();

            // act
            var result = strOperation.ReverseString("hello");

            // assert
            Assert.Equal("olleh", result);
        }

        [Fact]
        public void ReverseString_EmptyString()
        {
            // arrange
            var strOperation = new StringOperations();

            // act
            var result = strOperation.ReverseString("");

            // assert
            Assert.Equal("", result);
        }

        [Fact]
        public void GetStringLength_ValidString()
        {
            // arrange
            var strOperation = new StringOperations();

            // act
            var result = strOperation.GetStringLength("hello");

            // assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void GetStringLength_Exception()
        {
            // arrange
            var strOperation = new StringOperations();

            // act and assert
            Assert.Throws<ArgumentNullException>(() =>
            {
                strOperation.GetStringLength(null);
            });
        }

        [Fact]
        public void RemoveWhitespaceTest()
        {
            // arrange
            var strOperation = new StringOperations();

            // act
            var result = strOperation.RemoveWhitespace("Hello World");

            // assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal("HelloWorld", result);
            Assert.DoesNotContain(" ", result);
        }

        [Fact]
        public void TruncateString_ValidInput()
        {
            // arrange
            var strOperation = new StringOperations();

            // act
            var result = strOperation.TruncateString("hello world", 5);

            // assert
            Assert.Equal("hello", result);
        }

        [Fact]
        public void TruncateString_MaxLengthGreaterThanInputLength()
        {
            // arrange
            var strOperation = new StringOperations();

            // act
            var result = strOperation.TruncateString("hello", 10);

            // assert
            Assert.Equal("hello", result);
        }

        [Fact]
        public void TruncateString_InvalidMaxLength()
        {
            // arrange
            var strOperation = new StringOperations();

            // act and assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                strOperation.TruncateString("hello", -1);
            });
        }

        [Fact]
        public void IsPalindrome_true()
        {
            // arrange
            var strOperation = new StringOperations();

            // act
            var result = strOperation.IsPalindrome("madam");

            // assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_false()
        {
            // arrange
            var strOperation = new StringOperations();

            // act
            var result = strOperation.IsPalindrome("hello");

            // assert
            Assert.False(result);
        }

        [Fact]
        public void Pluralize_ValidInput()
        {
            // arrange
            var strOperation = new StringOperations();

            // act
            var result = strOperation.Pluralize("cat");

            // assert
            Assert.Equal("cats", result);
        }

        [Fact]
        public void Pluralize_EmptyString()
        {
            // arrange
            var strOperation = new StringOperations();

            // act
            var result = strOperation.Pluralize("");

            // assert
            Assert.Equal("", result);
        }

        [Fact]
        public void QuantityInWords()
        {
            var strOperation = new StringOperations();

            var result = strOperation.QuantintyInWords("cat", 10);

            Assert.NotNull(result);
            Assert.StartsWith("diez", result);
            Assert.EndsWith("cats", result);
            Assert.Contains("cat", result);
        }

        [Theory]
        [InlineData("V", 5)]
        [InlineData("IV", 4)]
        [InlineData("XL", 40)]
        public void FromRomanToNumber(string romanNumber, int expected)
        {
            var strOperation = new StringOperations();

            var result = strOperation.FromRomanToNumber(romanNumber);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void CountOccurrences()
        {
            var mockLogger = new Mock<ILogger<StringOperations>>();
            var strOperation = new StringOperations(mockLogger.Object);

            var result = strOperation.CountOccurrences("hello world", 'l');

            Assert.Equal(3, result);
        }

        [Fact]
        public void ReadFile()
        {
            var strOperation = new StringOperations();

            var mockFileReader = new Mock<IFileReaderConector>();
            mockFileReader.Setup(p => p.ReadString(It.IsAny<string>())).Returns("Reading file");

            var result = strOperation.ReadFile(mockFileReader.Object, "file.txt");

            Assert.Equal("Reading file", result);
        }
    }
}