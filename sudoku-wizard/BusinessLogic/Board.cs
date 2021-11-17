

namespace sudoku_wizard.BusinessLogic
{
  public class Board
  {
    public Tile[,] board { get; set; }
    public Board()
    {
      board = new Tile[9, 9];
    }

    public void PopulateBoard(string s)
    {
      int curPosition = 0;
      for (int row = 0; row < 9; row++)
      {
        for (int col = 0; col < 9; col++)
        {
          board[row, col] = new Tile((int)s[curPosition]);
          curPosition++;
        }
      }
    }

    public bool Constrain()
    {
      for (int row = 0; row < 9; row++)
      {
        for (int col = 0; col < 9; col++)
        {
          if (board[row, col].Domain.Count > 1)
          {
            //check row
            //check col
            //check square
          }
        }
      }
      return false;
    }
  }
}