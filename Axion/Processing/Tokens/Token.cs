﻿using System;
using Axion.Enums;
using Newtonsoft.Json;

namespace Axion.Processing.Tokens {
   [JsonObject]
   public class Token {
      [JsonProperty(Order = 0)] public TokenID ID;
      [JsonProperty(Order = 2)] public string Value;
      [JsonProperty(Order = 1001)] internal int StartLnPos;
      [JsonProperty(Order = 1002)] internal int StartClPos;
      [JsonProperty(Order = 1003)] internal int EndLnPos;
      [JsonProperty(Order = 1004)] internal int EndClPos;

      public Token(TokenID id, string value, int startLnPos, int startClPos) {
         ID = id;
         Value = value ?? throw new ArgumentNullException(nameof(value));
         StartLnPos = startLnPos;
         StartClPos = startClPos;
         // TODO it is only for oneline tokens; correct it
         EndLnPos = StartLnPos;
         EndClPos = StartClPos + value.Length;
      }

      public virtual string ToCppCode(int tabLevel) {
         string tabs = "";
         for (int i = 0; i < tabLevel; i++) {
            tabs += "  ";
         }

         return $"{tabs}[token (not implemented yet)]";
      }
   }
}