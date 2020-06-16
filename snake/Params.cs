﻿using System;
using Snake_N2;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace snake
{
    class Params
    {
        private string resourcesFolder;

        public Params()
        {
            var ind = Directory.GetCurrentDirectory().ToString()
                .IndexOf("bin", StrinsComparison.Ordinal);

            string binFolder =
                Directory.GetCurrentDirectory().ToString().Substring(0, ind)

            resourcesFolder = binFolder + "resources//";
        }

        public string GetResourceFolder()
        {
            return resourcesFolder;
        }
    }
}