using System;

namespace RectangleChecker
{
  public class Rectangle
  {
    private int length;
    private int width;

    public Rectangle(int sideLength, int sideWidth)
    {
      length = sideLength;
      width = sideWidth;
    }

    public int GetLength()
    {
      return length;
    }
    public void SetLength(int newLength)
    {
      length = newLength;
    }

    public int GetWidth()
    {
      return width;
    }
    public void SetWidth(int newWidth)
    {
      width = newWidth;
    }

    public int GetArea()
    {
      return length * width;
    }

    public bool IsSquare()
    {
      if (length == width) {
        return true;
      } else {
        return false;
      }
    }
  }
}
