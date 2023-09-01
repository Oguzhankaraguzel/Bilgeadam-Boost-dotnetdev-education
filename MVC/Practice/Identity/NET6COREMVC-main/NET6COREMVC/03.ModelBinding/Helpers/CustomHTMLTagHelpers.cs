using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace _03.ModelBinding.Helpers
{
    public static class CustomHTMLTagHelpers
    {
        public static string KalinYaz<TModel>(this IHtmlHelper<TModel> helper)
        {
            
            return "<b>Kalın Yazı</b>";
        }

        public static IHtmlContent KalinYaz<TModel>(this IHtmlHelper<TModel> helper, string yazi)
        {

            return helper.Raw($"<b>{yazi}</b>");
        }

        public static IHtmlContent CreateTable<TModel>(this IHtmlHelper<TModel> helper, List<string> columnNames, Dictionary<int,List<string>> rows, string style)
        {
            string thTags = "";
            foreach (var columnName in columnNames)
            {
                thTags += "<th>" + columnName + "</th>";
            }

            string dataTrTags = "";
            foreach (var rowKey in rows.Keys)
            {
                dataTrTags += "<tr>";
                foreach (var currentCellValue in rows[rowKey])
                {
                    dataTrTags += $"<td>{currentCellValue}</td>";
                }
                dataTrTags += "</tr>";
            }
            
            string bilgi = $"<table style='{style}'>" +
                $"<thead>" +
                $"<tr>" +
                $"{thTags}" +
                $"</tr>" +
                $"</thead>" +
                $"<tbody>" +
                $"{dataTrTags}"+
                $"</tbody>" +
                $"</table>";

            return helper.Raw(bilgi);
        }



    }
}
