using Microsoft.AspNetCore.Html;

namespace Custom_Helper
{
    public static class CustomHelper
    {
        public static HtmlString Button(string type, string value)
        {
            // Proper formatting and escaping
            return new HtmlString(string.Format("<input type=\"{0}\" value=\"{1}\" />", type, value));
        }
        public static HtmlString Image(string src, string alt, string width, string height)
        {
            string imgTag = string.Format(
                "<img src=\"{0}\" alt=\"{1}\" width=\"{2}\" height=\"{3}\" />",
                src, alt, width, height
            );

            return new HtmlString(imgTag);
        }
    }
   
}
