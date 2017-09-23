using Newtonsoft.Json;
using OmniSharp.Extensions.LanguageServerProtocol.Converters;

namespace OmniSharp.Extensions.LanguageServerProtocol.Models
{
    [JsonConverter(typeof(NumberEnumConverter))]
    public enum DiagnosticSeverity
    {
        /// <summary>
        /// Reports an error.
        /// </summary>
        Error = 1,
        /// <summary>
        /// Reports a warning.
        /// </summary>
        Warning = 2,
        /// <summary>
        /// Reports an information.
        /// </summary>
        Information = 3,
        /// <summary>
        /// Reports a hint.
        /// </summary>
        Hint = 4,
    }
}