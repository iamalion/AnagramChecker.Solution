using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnagramChecker.Models;

namespace AnagramChecker.Tests
{
  [TestClass]
  public class WordTests
  {
    [TestMethod]
    public void EchoWord_InputWord_ReturnsSameWord()
    {
        //arrange
        string inputWord = "bread";
        string expectedWord = inputWord;

        Word word = new Word();

        //act
        string echoedWord = word.EchoWord(inputWord);

        //assert
        Assert.AreEqual(expectedWord, echoedWord);
    }
  }
}