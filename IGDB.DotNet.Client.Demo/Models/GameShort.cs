﻿using Apicalypse.DotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace IGDB.DotNet.Client.Demo.Models
{
    class GameShort
    {
        public string Name { get; set; }

        [Include]
        public CoverPath Cover { get; set; }
    }
}
