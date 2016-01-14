namespace RectangleChecker
{
  public class Cube
  {
    private Rectangle face;
    public Cube (Rectangle side)
    {
      face = side;
    }


    public int GetVolume()
    {
      int length = face.GetLength();
      return length * length * length;
    }

    public int GetSurfaceArea()
    {
      return face.GetArea() * 6;
    }

  }
}
