﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace MagiciansChessApp.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class StringAux
    {
        /// <summary>
        /// Initializes a new instance of the StringAux class.
        /// </summary>
        public StringAux() { }

        /// <summary>
        /// Initializes a new instance of the StringAux class.
        /// </summary>
        public StringAux(string str = default(string))
        {
            Str = str;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "str")]
        public string Str { get; set; }

    }
}