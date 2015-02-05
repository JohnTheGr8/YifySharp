using System.ComponentModel;

namespace YifySharp.Models
{
    public enum MovieOrderOption
    {
        /// <summary>
        /// Descending order
        /// </summary>
        [Description("desc")]
        Descending,
        /// <summary>
        /// Ascending order
        /// </summary>
        [Description("asc")]
        Ascending
    }
}
