using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using ChartJS.Helpers.MVC;

namespace ChartJS.Helpers.MVC
{
    public static class Chart
    {
        public static string DrawHtml<T>(this T chartTypeObject, string chartID, string height, string width)
        {
            string chart = $"<div style='height:{height};width:{width}'>" + "\n";
            chart += $"<canvas id='{chartID}'></canvas>" + "\n";
            chart += "</div>" + "\n";
            return chart;
        }

        public static string DrawJavascript<T>(this T chartTypeObject, string chartID) where T : IChartType
        {
            string chart = "<script>" + "\n";
            chart += $"var {chartID}_ctx = document.getElementById('{chartID}').getContext('2d');" + "\n";
            chart += $"var {chartID}_Chart = new Chart({chartID}_ctx, {{" + "\n";
            chart += MyConverter.ToJSON(chartTypeObject) + "\n";
            chart += "});" + "\n";
            chart += "</script>" + "\n";
            return chart;
        }
    }

    class MyConverter
    {
        /// <summary>
        /// key => property name
        /// value => chart js object name
        /// </summary>
        private static Dictionary<string, string> _mapper = new Dictionary<string, string>()
        {
            {"LinearData","data" },
            {"XYData","data" },
            {"XYRData","data" },
            {"SFill","fill" },
            {"IFill","fill" },
            {"BFill","fill" },
            { "BSteppedLine","steppedLine"},
            { "SSteppedLine","steppedLine"},
        };
        /// <summary>
        /// convert to JSON
        /// </summary>
        /// <param name="data">only object having properties of complex type and primitve type(string[],int[],string,int,bool)</param>
        /// <param name="indent">specify the indent</param>
        /// <param name="skipKeys">specify the keys which need to be omitted</param>
        /// <returns>returns JSON of the object passed</returns>
        public static string ToJSON(object data, int indent = 0)
        {
            string json = "";
            Type instanceType = data.GetType();
            PropertyInfo[] properties = instanceType.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                string key = property.Name;
                if (property.GetValue(data) == null)
                {
                    //if the value of the property is null, then skip that property
                    continue;
                }
                //if property name is present in _mapper, substitute it for chart js object
                foreach (var pair in _mapper)
                {
                    if (pair.Key.Equals(key))
                    {
                        key = pair.Value;
                        break;
                    }
                }
                key = char.ToLower(key[0]).ToString() + key.Substring(1);

                string value = "";
                if (property.PropertyType == typeof(string[]))
                {
                    string[] values = (string[])property.GetValue(data);
                    value += "[";
                    foreach (string item in values)
                    {
                        value += "'" + item + "',";
                    }
                    value = value.TrimEnd(',') + "]";
                }
                else if (property.PropertyType == typeof(int[]))
                {
                    int[] values = (int[])property.GetValue(data);
                    value += "[";
                    foreach (int item in values)
                    {
                        value += item + ",";
                    }
                    value = value.TrimEnd(',') + "]";
                }
                else if (property.PropertyType == typeof(int?) || property.PropertyType == typeof(double?))
                {
                    value = property.GetValue(data).ToString();
                }
                else if (property.PropertyType == typeof(bool?))
                {
                    value = property.GetValue(data).ToString();
                    value = char.ToLower(value[0]).ToString() + value.Substring(1);
                }
                else if (property.PropertyType == typeof(string))
                {
                    value = "'" + property.GetValue(data).ToString() + "'";
                }
                else if (property.PropertyType.ToString().Contains("[]")) //array of the complex_type (complex_type[])
                {
                    object[] objArray = (object[])property.GetValue(data);
                    value = "[";
                    foreach (object item in objArray)
                    {
                        value += "{\n" + ToJSON(item, ++indent) + Indent(indent) + "},";
                        --indent;
                    }
                    value = value.TrimEnd(',') + "]";
                }
                else//complex_type
                {
                    value = "{\n" + ToJSON(property.GetValue(data), ++indent);
                    --indent;
                    value += Indent(indent) + "}";
                }
                json += Indent(indent) + key + ":" + value + ",\n";
            }
            return json.TrimEnd(',');
        }
        /// <summary>
        /// to apply indent to the getting geneated JSON
        /// </summary>
        /// <param name="far">specify the number of tab's from left margin</param>
        /// <returns>returns no. of tabs</returns>
        private static string Indent(int far)
        {
            string indent = "";
            for (int i = 01; i <= far; i++)
            {
                indent += "\t";
            }
            return indent;
        }
    }
}
namespace System.Web.Mvc
{
    public static class ChartHelper
    {
        public static IHtmlString ChartJSHtml<T>(this HtmlHelper helper, string chartID, T chartTypeObject, string height = "300px", string width = "500px") where T : IChartType
        {
            return new MvcHtmlString(chartTypeObject.DrawHtml(chartID, height, width));
        }

        public static IHtmlString ChartJSJavascript<T>(this HtmlHelper helper, string chartID, T chartTypeObject, string height = "300px", string width = "500px") where T : IChartType
        {
            return new MvcHtmlString(chartTypeObject.DrawJavascript(chartID));
        }
    }
}