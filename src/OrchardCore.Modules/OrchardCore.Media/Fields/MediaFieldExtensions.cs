using System;
using Newtonsoft.Json.Linq;
using SixLabors.ImageSharp;

namespace OrchardCore.Media.Fields
{
    public static class MediaFieldExtensions
    {
        /// <summary>
        /// Centers are a less well known property of a media field.
        /// </summary>
        public static float?[][] GetCenters(this MediaField mediaField)
        {
            var centers = mediaField.Content["Centers"] as JArray;

            return centers != null ? centers.ToObject<float?[][]>() : Array.Empty<float?[]>();
        }

        /// <summary>
        /// Tags names are a less well known property of a media field.
        /// </summary>
        public static void SetCenters(this MediaField mediaField, float?[][] centers)
        {
            mediaField.Content["Centers"] = JArray.FromObject(centers);
        }

    }
}