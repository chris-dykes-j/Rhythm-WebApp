using Microsoft.AspNetCore.Mvc;
using SkiaSharp;

namespace RhythmApi.Controllers;

[ApiController]
[Route("/{time:int}/{div:int}/{notes:int}")]
public class RhythmController : ControllerBase
{
   public string Get(int time, int div, int notes)
   {
      var data = new RhythmData(time, div, notes);
      var rhythmBuilder = new RhythmBuilder(data);
      rhythmBuilder.MakeRhythm();
      return rhythmBuilder.GetImagePath();
   } 
}