using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chinavasion.Net.RestObjects.Response
{
    public class GetBalanceResponse
    {
        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

    }
}
