using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
  [TestClass]
  public class StringHandlerTest
  {
    [TestMethod]
    public void CheckForNullValues()
    {
      // Arrange
      string source = null;
      string expected = null;
      var handler = new StringHandler();

      // Act
      var actual = handler.InsertSpaces(source);

      // Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CheckForSpaces()
    {
      // Arrange
      var source = " ";
      string expected = null;
      var handler = new StringHandler();

      // Act
      var actual = handler.InsertSpaces(source);

      // Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void InsertSpacesTestValid()
    {
      // Arrange
      var source = "SonicScrewdriver";
      var expected = "Sonic Screwdriver";
      var handler = new StringHandler();

      // Act
      var actual = handler.InsertSpaces(source);

      // Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void InsertSpacesTestWithExistingSpace()
    {
      // Arrange
      var source = "Sonic Screwdriver";
      var expected = "Sonic Screwdriver";
      var handler = new StringHandler();

      // Act
      var actual = handler.InsertSpaces(source);

      // Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void InsertSpacesTestMultipleCapitalWords()
    {
      // Arrange
      var source = "Sonic Screwdriver NewOne";
      var expected = "Sonic Screwdriver New One";
      var handler = new StringHandler();

      // Act
      var actual = handler.InsertSpaces(source);

      // Assert
      Assert.AreEqual(expected, actual);
    }

  }
}
