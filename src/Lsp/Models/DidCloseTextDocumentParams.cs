﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace OmniSharp.Extensions.LanguageServerProtocol.Models
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class DidCloseTextDocumentParams : ITextDocumentIdentifierParams
    {
        /// <summary>
        ///  The document that was closed.
        /// </summary>
        public TextDocumentIdentifier TextDocument { get; set; }
    }
}