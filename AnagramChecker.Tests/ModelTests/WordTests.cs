using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnagramChecker.Models;

namespace AnagramChecker.Tests
{
  [TestClass]
  public class WordTests
  {
    [TestMethod]
    public void WordConstructor_CreatesInstanceOfWord_Word()
    {
        Word newWord = new Word();
        Assert.AreEqual(typeof(Word), newWord.GetType());
    }
    [TestMethod]
    public void IsAnagram()
    {
        string inputtedWordOne = "beard";
        string inputtedWordTwo = "bread";
        Word word = new Word();

        bool result = word.IsAnagram(inputtedWordOne, inputtedWordTwo);

        Assert.IsTrue(result);
    }
  }
  
}