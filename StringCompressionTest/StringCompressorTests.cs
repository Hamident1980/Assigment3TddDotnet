using Xunit;
using Assigment3Dotnet;
using Assignment3Dotnet;


namespace StringCompressionTest
{
    public class StringCompressorTests
    {
        private readonly StringCompressor _compressor = new StringCompressor();

        [Fact]
        public void Compress_EmptyString_ReturnsEmptyString()
        {
            Assert.Equal("", _compressor.Compress(""));
        }

        [Fact]
        public void Compress_NoConsecutiveCharacters_ReturnsSameString()
        {
            Assert.Equal("abc", _compressor.Compress("abc"));
        }

        [Fact]
        public void Compress_ConsecutiveCharacters_CompressesCorrectly()
        {
            Assert.Equal("a2b1c5a3", _compressor.Compress("aabcccccaaa"));
        }

        [Fact]
        public void Compress_NoSizeReduction_ReturnsOriginalString()
        {
            Assert.Equal("abcd", _compressor.Compress("abcd"));
        }
    }
}

