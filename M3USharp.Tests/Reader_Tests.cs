using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace M3USharp.Tests
{
    [TestClass]
    public class Reader_Tests
    {
        private readonly string _testData = "#EXTM3U\r\n#EXT-X-VERSION:4\r\n#EXT-X-STREAM-INF:BANDWIDTH=488000,NAME=\"FPS:30.0\",CODECS=\"avc1.42c015,mp4a.40.2\",RESOLUTION=426x240\r\nchunklist_w223440927_b448000_t64RlBTOjMwLjA=.m3u8\r\n#EXT-X-STREAM-INF:BANDWIDTH=1258000,NAME=\"FPS:30.0\",CODECS=\"avc1.4d401f,mp4a.40.2\",RESOLUTION=854x480\r\nchunklist_w223440927_b1148000_t64RlBTOjMwLjA =.m3u8\r\n#EXT-X-STREAM-INF:BANDWIDTH=2028000,NAME=\"FPS:30.0\",CODECS=\"avc1.4d401f,mp4a.40.2\",RESOLUTION=960x540\r\nchunklist_w223440927_b1848000_t64RlBTOjMwLjA=.m3u8\r\n#EXT-X-STREAM-INF:BANDWIDTH=3396000,NAME=\"FPS:30.0\",CODECS=\"avc1.4d401f,mp4a.40.2\",RESOLUTION=1280x720\r\nchunklist_w223440927_b3096000_t64RlBTOjMwLjA =.m3u8";

        [TestMethod]
        public void M3UReader_Parse()
        {
            M3UFile file = M3UReader.Parse(_testData);

            Assert.IsTrue(file.Version == "4");
        }
    }
}
