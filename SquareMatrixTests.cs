using System;
using Xunit;

public class SquareMatrixTests {
  private readonly SquareMatrix _matrix2x2;
  private readonly SquareMatrix _anotherMatrix2x2;
  private readonly SquareMatrix _matrix3x3;

  public SquareMatrixTests() {
    var rand = new Random(42);
    _matrix2x2 = new SquareMatrix(2, rand);
    _anotherMatrix2x2 = new SquareMatrix(2, rand);
    _matrix3x3 = new SquareMatrix(3, rand);
  }

  [Fact]
  public void Add_TwoSameSizeMatrices_ReturnsCorrectMatrix() {
    var expected = new int[,] { { _matrix2x2.matrix[0, 0] + _anotherMatrix2x2.matrix[0, 0], _matrix2x2.matrix[0, 1] + _anotherMatrix2x2.matrix[0, 1] },
                                 { _matrix2x2.matrix[1, 0] + _anotherMatrix2x2.matrix[1, 0] , _matrix2x2.matrix[1, 1] + _anotherMatrix2x2.matrix[1, 1] } };

    var result = _matrix2x2 + _anotherMatrix2x2;

    Assert.Equal(expected, result.matrix);
  }

  [Fact]
  public void Multiply_Matrix() {
    var expected = new int[,] { { _matrix2x2.matrix[0, 0] * _anotherMatrix2x2.matrix[0, 0] + _matrix2x2.matrix[0, 1] * _anotherMatrix2x2.matrix[1, 0], _matrix2x2.matrix[0, 0] * _anotherMatrix2x2.matrix[0, 1] + _matrix2x2.matrix[0, 1] * _anotherMatrix2x2.matrix[1, 1] },
      { _matrix2x2.matrix[1, 0] * _anotherMatrix2x2.matrix[0, 0] + _matrix2x2.matrix[1, 1] * _anotherMatrix2x2.matrix[1, 0], _matrix2x2.matrix[1, 0] * _anotherMatrix2x2.matrix[0, 1] + _matrix2x2.matrix[1, 1] * _anotherMatrix2x2.matrix[1, 1] } };

    var result = _matrix2x2 * _anotherMatrix2x2;

    Assert.Equal(expected, result.matrix);
  }

  [Fact]
  public void Compare_Matrices_ReturnsCorrectResult() {
    var matrixA = new SquareMatrix(new int[,] { { 1, 2 }, { 3, 4 } });
    var matrixB = new SquareMatrix(new int[,] { { 1, 2 }, { 3, 4 } });

    Assert.True(matrixA == matrixB);
  }

  [Fact]
  public void Determinant_2x2Matrix_ReturnsCorrectValue() {
    var matrix = new SquareMatrix(new int[,] { { 1, 2 }, { 3, 4 } });

    var det = matrix.Determinant();

    Assert.Equal(-2, det);
  }
}