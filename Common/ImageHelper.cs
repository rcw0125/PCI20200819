using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace Common
{
    public class ImageHelper
    {
        static string arrow_move = "iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAABBklEQVQ4T6WTv0vDQBTHv8+4WxMFp9arQ9HBQQc3C4Xi35Q494J/kovQvTi0IJ1yRMwgmB+dy/FKCgmxzUFCbjvu+z73vfe+R+i4yFR/NvAeLAvvDD1Jg7eVSVcL6InXwQnxgoALMH6xpcf4ZxbVQWoBjvDWIIzKAuZ1rPzbxoBC6Aw9jgNpfGauKw/tvntHFn3ESl6ZALZw/6DxnHz7X4VmDzgX3j0BcyL0qjceOsj3zMgYGKdKLksHtnAVEV03nSgzB4nyb0pAZwc5Ke8BTmmeBPLS1ANHuBFrTI96YLLeagpVSOccHCZRg54yNQtbBan4C1rjZRPKz1Z/oek4/yWxTVFVuwMoFX0RwZhcqwAAAABJRU5ErkJggg==";
        static string arrow_up = "iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAABM0lEQVQ4T+3TvUrEQBQF4HOHBDZEDAQM+RFstrAUwUJkRR9gbX0DH8zSTksRUQQtLRbEQlBhk5VIBMEiIZEjiYnomqBg65TDPd8wc+cK/rikKx/H8Uye54cAlFJq6HneY1ttK1CGi6I4BrBSh65N01yzLOtpGvkGtISbzMg0zY1p5AuQJMlslmVH9cn3ABYAkGQoIvMARr1eb2Db9nOjfgBlOE3TUxFZIjlWSg1I3gJ4FZE+yQsALslLwzA2G6QC2sKu644nk0leAr7va3Ec94uiOGsQXdfXHcd5qYAwDPdFZAvAg4isep53R1L7DJR1NXIOYI7kXhAE2xUQRdFueW9N04aO49yUe21AXbtI8kBETnzf3+n8B13Aj21sCv6B95eIouiKZBoEwXLX0HV24bdT/gbCjL0Rf5Gt5QAAAABJRU5ErkJggg==";
        static string arrow_down = "iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAABNUlEQVQ4T+2TP0vDUBTFzw3JLAgNyYvFpUMXBwcHBxcRFNHRb9Bv5uqkg2ulWAd3J0GF5kUyBAsWU/LnyKutRNtUwdU73/O7l3PPFfyxZJlea31HchwEwWZdXy2ApB1FUQagUErZ/4AfPNBan5LcchznyHXde2NYnYla6zbJCxG5Ukp1JlcIw/BcRI4BPIvItu/7j4sAcRy38jzvA2gAOFNKnUwASZKspGnaA7BBcmBZ1o7neYPqGadi0+MBuLVte9d13dfPHAyHw9XRaNStQkg+mByISIvkjRGT7DuOs2/EZviXIE0h1wDaAJ4ArH/YwVBE1oy4LMu9ZrP5NgvWXBKjKGqUZdk3U6vpWySe22AmiOPYy7KsV4F0i6I4rE6u3eAb5FJEXnzfPxCR8aJ/WPqNv/n0d/k+yhEaEReWAAAAAElFTkSuQmCC";


        static Image GetImage(string base64string)
        {
            var bytes = Convert.FromBase64String(base64string);

            using (var ms = new MemoryStream(bytes))
            {
                return new Bitmap(ms, true);
            }
        }

        public static Image Image_Arrow_Move => GetImage(arrow_move);
        public static Image Image_Arrow_Up => GetImage(arrow_up);
        public static Image Image_Arrow_Down => GetImage(arrow_down);
    }
}
