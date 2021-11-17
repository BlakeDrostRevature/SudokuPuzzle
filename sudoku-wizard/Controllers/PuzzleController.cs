using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sudoku_wizard.BusinessLogic;

namespace sudoku_wizard.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class PuzzleController : ControllerBase
  {
    static string freshBoard = "001700509573024106800501002700295018009400305652800007465080071000159004908007053";
    public static PuzzleLogic logic = new PuzzleLogic(freshBoard);

    [HttpGet]
    public Board Get()
    {
      return logic.puzzle;
    }
  }
}