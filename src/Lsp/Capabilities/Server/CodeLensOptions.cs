﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using OmniSharp.Extensions.LanguageServerProtocol.Models;

namespace OmniSharp.Extensions.LanguageServerProtocol.Capabilities.Server
{
    /// <summary>
    ///  Code Lens options.
    /// </summary>
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class CodeLensOptions : ICodeLensOptions
    {
        /// <summary>
        ///  Code lens has a resolve provider as well.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool ResolveProvider { get; set; }

        public static CodeLensOptions Of(ICodeLensOptions options)
        {
            return new CodeLensOptions() { ResolveProvider = options.ResolveProvider };
        }
    }
}