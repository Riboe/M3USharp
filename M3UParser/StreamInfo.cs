﻿using System;
using System.Collections.Generic;
using System.Text;

namespace M3USharp
{
    public class StreamInfo
    {
        public string Path { get; internal set; }
        public long Bandwidth { get; internal set; }
        public string Name { get; internal set; }
        public string Codecs { get; internal set; }
        public int ResolutionWidth { get; internal set; }
        public int ResolutionHeight { get; internal set; }
    }
}
