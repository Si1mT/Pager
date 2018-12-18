﻿using System.Collections.Generic;

namespace MediaGallery.Data
{
    public abstract class MediaFile : MediaItem
    {
        public string FileName { get; set; }

        public float? Latitude { get; set; }
        public float? Longitude { get; set; }

        public bool HasCoordinates
        {
            get
            {
                return Latitude.HasValue && Longitude.HasValue;
            }
        }

        public string GetUrlPath()
        {
            var path = "";
            var parentItems = new List<string>();
            var parent = ParentFolder;

            while (parent != null)
            {
                parentItems.Add(parent.Title);

                parent = parent.ParentFolder;
            }

            return null;
        }
    }
}
