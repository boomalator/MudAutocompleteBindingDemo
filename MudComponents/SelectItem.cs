namespace DefaultBlazor.Server
{
    /// <summary>
    /// Class SelectItem for use by MudAutoCompleteKey.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class SelectItem<T>
    {

#nullable enable
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public T? Id { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>The text.</value>
        public string? Text { get; set; }

#nullable disable

        /// <summary>
        /// Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="string" /> that represents this instance.</returns>
        public override string ToString()
        {
            if (string.IsNullOrEmpty(Text))
            {
                return Id?.ToString() ?? "";
            }

            return $"{Text}".Trim();
        }
    }
}
