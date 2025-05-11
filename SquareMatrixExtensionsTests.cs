using Xunit;

public class SquareMatrixExtensionsTests {
  [Fact]
  public void Transpose_Matrix_CorrectlyTransposed() {
    var matrix = new SquareMatrixExtensions(new int[,] { { 1, 2 }, { 3, 4 } });
    var expected = new int[,] { { 1, 3 }, { 2, 4 } };

    matrix.TransposeMatrix(matrix);

    Assert.Equal(expected, matrix.matrix);
  }

  [Fact]
  public void Track_Matrix_ReturnsSumOfDiagonal() {
    var matrix = new SquareMatrixExtensions(new int[,] { { 1, 2 }, { 3, 4 } });

    var track = matrix.Track(matrix);

    Assert.Equal(5, track);
  }
}
