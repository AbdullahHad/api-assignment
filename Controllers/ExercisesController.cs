using Microsoft.AspNetCore.Mvc;
using AssignmentAPI.Models;

namespace AssignmentAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExercisesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetExercises()
        {
            return Ok(new { message = "Exercises list", exercises = new[] { "Push-ups", "Squats", "Deadlifts" } });
        }

        [HttpGet("{id}")]
        public IActionResult GetExerciseById(int id)
        {
            return Ok(new { message = $"Exercise with id: {id}" });
        }

        [HttpPost]
        public IActionResult CreateExercise([FromBody] Exercise exercise)
        {
            return Ok(new { message = $"Exercise '{exercise.Name}' created" });
        }
    }
}