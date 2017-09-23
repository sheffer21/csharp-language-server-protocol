﻿using OmniSharp.Extensions.JsonRpc;
using OmniSharp.Extensions.JsonRpc.Server.Messages;

namespace OmniSharp.Extensions.LanguageServerProtocol.Messages
{
    public class ServerErrorEnd : Error
    {
        internal ServerErrorEnd() : base(null, new ErrorMessage(-32000, "Server Error End")) { }
    }
}