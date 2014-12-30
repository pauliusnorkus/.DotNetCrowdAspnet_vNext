using Microsoft.AspNet.Razor.Runtime.TagHelpers;
using System;

namespace MyLib
{
    [ContentBehavior(Microsoft.AspNet.Razor.TagHelpers.ContentBehavior.Append)]
    public class EmailTagHelper :TagHelper
    {
        public static string DomainName = "company.com";
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Content = output.Content + "@" + DomainName;
            output.Attributes["href"] = "mailto:" + output.Content;
        }
    }
}
