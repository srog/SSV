using System.Collections.Generic;

namespace CMS.Data
{
    public static class StaticData
    {
        public static Dictionary<string, string> Bookmarks
        {
            get
            {
                var bookmarks = new Dictionary<string, string>
                    {
                        {"Reddit", "http://www.reddit.com"},
                        {"Twitter", "http://www.twitter.com"},
                        {"Wired", "http://www.wired.com"},
                        {"IMDB", "http://www.IMDB.com"},
                        {"BBC", "http://www.bbc.co.uk"}
                    };

                return bookmarks;
            }
        }
    }
}
