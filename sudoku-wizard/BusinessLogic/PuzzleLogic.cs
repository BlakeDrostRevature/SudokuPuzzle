namespace sudoku_wizard.BusinessLogic
{
  public class PuzzleLogic
  {
    public Board puzzle { get; set; }

    public PuzzleLogic(string s)
    {
      puzzle = new Board();
      puzzle.PopulateBoard(s);
    }

    public bool ConstrainPuzzle()
    {
      return puzzle.Constrain();
    }
  }
}