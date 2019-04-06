using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AaronsDayStarter.Services
{
    public static class Formatter
    {

        public static FormattedString HtmlToText(String html)
        {
            Xamarin.Forms.FormattedString convert = new FormattedString();
            Int32 pos = 0;
            Int32 startStyle = 0;
            Int32 endStyle = 0;
            Int32 startPara = 0;
            Int32 endPara = 0;
            List<String> paragraph = new List<string>();
            while (pos < html.Length - 2)
            {
                switch (html.Substring(pos, 2))
                {
                    case "<p": // new paragraph
                        startPara = html.IndexOf(">", pos) + 1;
                        endPara = html.IndexOf("</p>", pos);
                        if (endPara < 1)
                        {
                            endPara = html.IndexOf("<p", startPara); // next new para
                        }
                        if (endPara < 1)
                        {
                            endPara = html.Length;
                        }
                        paragraph.Add(html.Substring(startPara, endPara - startPara));
                        pos = endPara - 2;
                        break;
                }
                pos++;
            }

            StringBuilder working = new StringBuilder();
            foreach (var para in paragraph)
            {
                pos = 0;
                Span span = new Span();
                span.FontSize = 17;
                span.FontAttributes = FontAttributes.None;

                try
                {
                    while (pos < para.Length)
                    {
                        if (pos < para.Length - 3)
                        {

                            switch (para.Substring(pos, 3))
                            {
                                case "<b>": // bold text
                                    convert.Spans.Add(span);
                                    span = new Span();
                                    span.FontAttributes = FontAttributes.Bold;
                                    span.FontSize = 17;
                                    pos += 3;
                                    break;
                                case "</b": // bold text
                                    convert.Spans.Add(span);
                                    span = new Span();
                                    span.FontAttributes = FontAttributes.None;
                                    span.FontSize = 17;
                                    pos += 4;
                                    break;
                                case "<i>": // italic text
                                    convert.Spans.Add(span);
                                    span = new Span();
                                    span.FontAttributes = FontAttributes.Italic;
                                    span.FontSize = 17;
                                    pos = para.IndexOf(">", pos);
                                    break;
                                case "</i": // italic text
                                    convert.Spans.Add(span);
                                    span = new Span();
                                    span.FontAttributes = FontAttributes.None;
                                    span.FontSize = 17;
                                    pos = para.IndexOf(">", pos);
                                    break;
                                case "<h1": // heading text
                                    convert.Spans.Add(span);
                                    span = new Span();
                                    span.FontAttributes = FontAttributes.Bold;
                                    span.FontSize = 20;
                                    pos = para.IndexOf(">", pos);
                                    break;
                                case "</h": // heading text
                                    convert.Spans.Add(span);
                                    span = new Span();
                                    span.FontAttributes = FontAttributes.None;
                                    span.FontSize = 20;
                                    pos = para.IndexOf(">", pos);
                                    break;
                                case "<sp": // span text
                                    pos = para.IndexOf(">", pos);
                                    break;
                                case "</s": // span text
                                    pos = para.IndexOf(">", pos);
                                    break;
                            }
                        }

                        span.Text += para.Substring(pos, 1);
                        pos++;
                    }
                }
                catch (Exception ex)
                {
                    convert.Spans.Add(new Span() { Text = ex.Message, FontAttributes = FontAttributes.Bold });
                }
                span.Text += "\n\n";
                convert.Spans.Add(span);

            }

            return convert;
        }
//        <p class="bodytext">
//        <b>3:16</b> For this is the way God loved the world: He gave his one and only Son, so that everyone who believes in him will not perish but have eternal life.  
//                    <b>17</b> For God did not send his Son into the world to condemn the world, but that the world should be saved through him.  
//                    <p class="bodytext">
//        <b>1:1</b> In the beginning was the Word, and the Word was with God, and the Word was fully God.


//            var opening = new FormattedString();
//        opening.Spans.Add(new Span { Text = "O Lord, Let my soul rise up to meet the morning ", FontAttributes = FontAttributes.None
//    });
//            opening.Spans.Add(new Span { Text = "as the day rises to meet the sun.\n\n", FontAttributes = FontAttributes.Bold
//});
//            opening.Spans.Add(new Span { Text = "Glory to the Father, and to the son, and to the Holy Spirit, as it was in the beginning is now and will be for ever\n\n", FontAttributes = FontAttributes.Bold });
//            opening.Spans.Add(new Span { Text = "Come; let us sing to the lord: Let us shout to the Rock of our salvation", FontAttributes = FontAttributes.None });
    }
}
