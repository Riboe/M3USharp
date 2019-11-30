using System;
using System.Collections.Generic;
using System.Text;

namespace M3USharp
{
    public class M3UFile
    {
        private List<StreamInfo> _streams = new List<StreamInfo>();

        public string Version { get; internal set; }
        public IReadOnlyList<StreamInfo> Streams
        {
            get => _streams;
        }

        internal void AddStream(StreamInfo stream)
        {
            _streams.Add(stream);
        }
    }
}
