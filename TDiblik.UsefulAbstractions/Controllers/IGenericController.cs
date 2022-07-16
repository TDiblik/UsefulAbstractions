using Microsoft.AspNetCore.Mvc;

namespace TDiblik.UsefulAbstractions.Controllers
{
    /// <summary>
    /// </summary>
    /// <typeparam name="T">Your model</typeparam>
    /// <typeparam name="I">Type of your ID, intended usage: string/int </typeparam>
    public interface IGenericController<T, I> 
        where T : class 
        where I : notnull
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
        /// public async ... GetById([FromRoute] I id);
        ///
        /// </code>
        /// </example>
        ///
        /// <para>
        /// Don't forget swagger xml documentation!
        /// </para>
        ///
        /// </summary>
        public Task<IActionResult> GetById(I id);

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
        /// public async ... Put([FromRoute] I id, [FromBody] T item);
        ///
        /// </code>
        /// </example>
        ///
        /// <para>
        /// Don't forget swagger xml documentation!
        /// </para>
        ///
        /// </summary>
        public Task<IActionResult> Put(I id, T item);

        /// <summary>
        ///
        /// <example>
        /// Example implementation:
        /// <code>
        ///
        /// [HttpDelete("{id}")]
        /// [ProducesResponseType(StatusCodes.Status200OK)]
        /// [ProducesResponseType(StatusCodes.Status404NotFound)]
        /// public async ... Delete([FromRoute] I id);
        ///
        /// </code>
        /// </example>
        ///
        /// <para>
        /// Don't forget swagger xml documentation!
        /// </para>
        ///
        /// </summary>
        public Task<IActionResult> Delete(I id);
    }
}
