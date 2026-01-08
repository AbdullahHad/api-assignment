using Microsoft.AspNetCore.Mvc;
using AssignmentAPI.Models;

namespace AssignmentAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WorkoutsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetWorkouts()
        {
            return Ok(new { message = "Workouts list", workouts = new[] { "Running", "Cycling", "Swimming" } });
        }

        [HttpGet("{id}")]
        public IActionResult GetWorkoutById(int id)
        {
            return Ok(new { message = $"Workout with id: {id}" });
        }

        [HttpPost]
        public IActionResult CreateWorkout([FromBody] Workout workout)
        {
            return Ok(new { message = $"Workout '{workout.Name}' created" });
        }
    }
}