using Microsoft.AspNetCore.Mvc;

namespace TDiblik.UsefulAbstractions.Controllers
{
    public interface IGenericController<T> where T : class
    {
        /// <summary>
        ///
        /// <example>
        /// Example implementation:
        /// <code>
        ///
        /// [HttpGet()]
        /// [ProducesResponseType(StatusCodes.Status200OK)]
        /// public async ... GetAll();
        ///
        /// </code>
        /// </example>
        ///
        /// <para>
        /// Don't forget swagger xml documentation!
        /// </para>
        ///
        /// </summary>
        public Task<IActionResult> GetAll();

        /// <summary>
        ///
        /// <example>
        /// Example implementation:
        /// <code>
        ///
        /// [HttpGet("{id}")]
        /// [ProducesResponseType(StatusCodes.Status200OK)]
        /// [ProducesResponseType(StatusCodes.Status404NotFound)]
        /// public async ... GetById([FromRoute] int id);
        ///
        /// </code>
        /// </example>
        ///
        /// <para>
        /// Don't forget swagger xml documentation!
        /// </para>
        ///
        /// </summary>
        public Task<IActionResult> GetById(int id);

        /// <summary>
        ///
        /// <example>
        /// Example implementation:
        /// <code>
        ///
        /// [HttpPost()]
        /// [ProducesResponseType(StatusCodes.Status201Created)]
        /// [ProducesResponseType(StatusCodes.Status400BadRequest)]
        /// public async ... Post([FromBody] T item);
        ///
        /// </code>
        /// </example>
        ///
        /// <para>
        /// Don't forget swagger xml documentation!
        /// </para>
        ///
        /// </summary>
        public Task<IActionResult> Post(T item);

        /// <summary>
        ///
        /// <example>
        /// Example implementation:
        /// <code>
        ///
        /// [HttpPut("{id}")]
        /// [ProducesResponseType(StatusCodes.Status200OK)]
        /// [ProducesResponseType(StatusCodes.Status404NotFound)]
        /// public async ... Put([FromRoute] int id, [FromBody] T item);
        ///
        /// </code>
        /// </example>
        ///
        /// <para>
        /// Don't forget swagger xml documentation!
        /// </para>
        ///
        /// </summary>
        public Task<IActionResult> Put(int id, T item);

        /// <summary>
        ///
        /// <example>
        /// Example implementation:
        /// <code>
        ///
        /// [HttpDelete("{id}")]
        /// [ProducesResponseType(StatusCodes.Status200OK)]
        /// [ProducesResponseType(StatusCodes.Status404NotFound)]
        /// public async ... Delete([FromRoute] int id);
        ///
        /// </code>
        /// </example>
        ///
        /// <para>
        /// Don't forget swagger xml documentation!
        /// </para>
        ///
        /// </summary>
        public Task<IActionResult> Delete(int id);
    }
}
