using System.Collections.Generic;

namespace sudoku_wizard.BusinessLogic
{
  public class Tile
  {
    public int Value { get; set; }
    public List<int> Domain { get; set; }

    public Tile(int i)
    {
      if (i == 0)
      {
        Value = 0;
        Domain = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
      }
      else
      {
        Value = i;
        Domain = new List<int>();
      }
    }
  }
}