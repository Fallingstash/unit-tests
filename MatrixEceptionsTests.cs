using Xunit;

public class MatrixExceptionsTests {
  [Fact]
  public void Add_DifferentSizes_ThrowsMatrixSizeException() {
    // Arrange
    var matrix2x2 = new SquareMatrix(2);
    var matrix3x3 = new SquareMatrix(3);

    // Act & Assert
    Assert.Throws<MatrixSizeException>(() => matrix2x2 + matrix3x3);
  }
}