using Microsoft.AspNetCore.Mvc;

namespace TDiblik.UsefulAbstractions.Controllers
{
    public interface IGenericController<T> where T : class
    {
        public Task<IActionResult> GetAll();

        // Example implementation in AspNetCore `[FromRoute] int id` using `Microsoft.AspNetCore.Mvc`
        public Task<IActionResult> GetById([FromRoute] int id);

        // Example implementation in AspNetCore `[FromBody] T item` using `Microsoft.AspNetCore.Mvc`
        public Task<IActionResult> Post([FromBody] T item);

        // Example implementation in AspNetCore `[FromQuery] int id, [FromBody] T item` using `Microsoft.AspNetCore.Mvc`
        public Task<IActionResult> Put([FromQuery] int id, [FromBody] T item);

        // Example implementation in AspNetCore `[FromRoute] int id` using `Microsoft.AspNetCore.Mvc`
        public Task<IActionResult> Delete([FromRoute] int id);
    }

}
