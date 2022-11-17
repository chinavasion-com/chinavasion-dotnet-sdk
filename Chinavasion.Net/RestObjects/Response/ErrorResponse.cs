using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Chinavasion.Net.RestObjects.Response
{
    /// <summary>
    /// ErrorResponse
    /// </summary>
    public class ErrorResponse
    {
        [JsonPropertyName("error")]
        public string Error { get; set; }

        [JsonPropertyName("error_message")]
        public string ErrorMessage { get; set; }

        [JsonPropertyName("code")]
        public int Code { get; set; }
    }
}
