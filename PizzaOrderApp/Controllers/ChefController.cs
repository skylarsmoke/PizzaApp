using Microsoft.AspNetCore.Mvc;

namespace PizzaOrderApp.Controllers
{
    [ApiController]
    [Route("api/chef")]
    public class ChefController : ControllerBase
    {

        // we store our data in memory for simplicity, for a more robust application using a SQL database would work well
        private static List<string> Toppings = new List<string> { "Pepperoni", "Cheese" };
        private static List<Pizza> Pizzas = new List<Pizza>();

        [HttpGet("toppings")]
        public IActionResult GetToppings()
        {
            // returns our toppings
            return Ok(Toppings);
        }


        [HttpPost("addtopping")]
        public IActionResult AddTopping([FromBody] string topping)
        {
            // checks if the topping already exists
            if (Toppings.Contains(topping)) return BadRequest("This topping already exists");

            // adds the new topping
            Toppings.Add(topping);
            return Ok();
        }

        [HttpDelete("deletetopping/{topping}")]
        public IActionResult DeleteTopping(string topping)
        {
            // checks if the topping doesn't exist
            if (!Toppings.Contains(topping)) return NotFound("This topping does not exist.");
            
            // deletes the topping
            Toppings.Remove(topping);
            return Ok();
        }

        [HttpGet("pizzas")]
        public IActionResult GetPizzas()
        {
            // returns the lists of pizzas
            return Ok(Pizzas);
        }

        [HttpPost("addpizza")]
        public IActionResult AddPizza([FromBody] Pizza pizza)
        {
            // find the pizza that is passed in
            if (Pizzas.Any(p => p.Name.Equals(pizza.Name, StringComparison.OrdinalIgnoreCase) || (p.Toppings.Count == pizza.Toppings.Count && !p.Toppings.Except(pizza.Toppings).Any()))) return BadRequest("There is already a pizza with this name or toppings.");
            
            // add pizza if it doesn't already exist
            Pizzas.Add(pizza);
            return Ok();
        }

        [HttpPut("pizzas/{name}")]
        public IActionResult UpdatePizza(string name, [FromBody] Pizza pizza) 
        { 
            // find pizza in list
            var pizzaToUpdate = Pizzas.Find(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            // if we don't find the pizza return
            if (pizzaToUpdate is null) return NotFound("Pizza not found.");
            
            // update the pizzas toppings
            pizzaToUpdate.Toppings = pizza.Toppings;
            return Ok();
        }

        [HttpDelete("pizzas/{name}")]
        public IActionResult DeletePizza(string name)
        {
            // delete pizza from pizza list
            var pizzaToDelete = Pizzas.Find(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            // if we don't find the pizza return
            if (pizzaToDelete is null) return NotFound("Pizza not found.");
            
            // remove the pizza
            Pizzas.Remove(pizzaToDelete);
            return Ok();
        }

    }

    /// <summary>
    /// Pizza object that holds details about out pizza
    /// </summary>
    public class Pizza
    {
        public required string Name { get; set; }
        public required List<string> Toppings { get; set; }
    }
}
