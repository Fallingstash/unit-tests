using Xunit;

public class SpecialMethodsTests {
  [Fact]
  public void DeepClone_ReturnsIndependentCopy() {
    var original = new SquareMatrix(new int[,] { { 1, 2 }, { 3, 4 } });

    var clone = original.DeepClone();
    original.matrix[0, 0] = 100;

    Assert.NotEqual(original.matrix, clone.matrix);
  }

  [Fact]
  public void ToString_ReturnsProperFormat() {
    var matrix = new SquareMatrix(new int[,] { { 1, 2 }, { 3, 4 } });

    var result = matrix.ToString();

    Assert.Equal("1\t2\t\n3\t4\t\n", result);
  }
}