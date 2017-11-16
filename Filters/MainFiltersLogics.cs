using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using Codec;
using FilteringStation;

namespace Filters
{
    class MainFiltersLogics
    {
        private event Action<Image> OriginalDrawer;
        private event Action<Image> EditedDrawer;
        private Image imgOriginal;
        private Image imgEdited;
        private MyDecoder decoder;
        private Filterer filters;
        
        public void SetDrawer(Action<Image> del, bool flag)
        {
            if (flag)
                OriginalDrawer += del;
            else
                EditedDrawer += del;
        }

        public void LoadImage(string path)
        {
            decoder = new MyDecoder(path);
            imgOriginal = decoder.Decode();
            OriginalDrawer?.Invoke(imgOriginal);
            filters = new Filterer(imgOriginal);
        }

        public void ShowImage(params double[] args)
        {
            if (filters != null)
            {
                filters.SetFilter(args);
                imgEdited = filters.Process();
                EditedDrawer?.Invoke(imgEdited);
            }
        }
    }
}
