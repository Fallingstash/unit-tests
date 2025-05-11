using Xunit;

public class SquareMatrixExtensionsTests {
  [Fact]
  public void Transpose_Matrix_CorrectlyTransposed() {
    // Arrange
    var matrix = new SquareMatrixExtensions(new int[,] { { 1, 2 }, { 3, 4 } });
    var expected = new int[,] { { 1, 3 }, { 2, 4 } };

    // Act
    matrix.TransposeMatrix(matrix);

    // Assert
    Assert.Equal(expected, matrix.matrix);
  }

  [Fact]
  public void Track_Matrix_ReturnsSumOfDiagonal() {
    // Arrange
    var matrix = new SquareMatrixExtensions(new int[,] { { 1, 2 }, { 3, 4 } });

    // Act
    var track = matrix.Track(matrix);

    // Assert
    Assert.Equal(5, track);
  }
}