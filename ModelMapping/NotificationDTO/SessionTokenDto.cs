﻿namespace ModelMapping.NotificationDTO
{
    using System;
    using Newtonsoft.Json;

    [Serializable]
    public class SessionTokenDto
    {
        [JsonProperty("session_token")]
        public string sessionToken;
    }
}