﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var settings = Settings.FromJson(jsonString);
using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ParadoxLauncherCustomizer
{

    public partial class LauncherSettings
    {
        [JsonProperty("background")]
        public Background Background { get; set; }

        [JsonProperty("logo")]
        public Logo Logo { get; set; }

        [JsonProperty("button")]
        public Button Button { get; set; }

        [JsonProperty("buttonHover")]
        public ButtonHover ButtonHover { get; set; }
    }

    public partial class Background
    {
        [JsonProperty("backgroundImage")]
        public string BackgroundImage { get; set; }
    }

    public partial class Button
    {
        [JsonProperty("backgroundImage")]
        public string BackgroundImage { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("fontSize")]
        public long FontSize { get; set; }

        [JsonProperty("fontPath")]
        public string FontPath { get; set; }

        [JsonProperty("textShadow")]
        public string TextShadow { get; set; }
    }

    public partial class ButtonHover
    {
        [JsonProperty("color")]
        public string Color { get; set; }
    }

    public partial class Logo
    {
        [JsonProperty("imagePath")]
        public string ImagePath { get; set; }
    }

    public partial class Settings
    {
        public static Settings FromJson(string json) => JsonConvert.DeserializeObject<Settings>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Settings self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}