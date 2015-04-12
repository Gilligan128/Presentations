using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Web.Models;

namespace WebDemo
{
    public static class DropDownExtensions
    {
        public static HtmlString QueryDropDown<T, TItem>(this HtmlHelper<T> htmlHelper,
    Expression<Func<T, TItem>> expression, 
    Func<ApplicationDbContext, IEnumerable<SelectListItem>> query
    )
        {
            var expressionText = ExpressionHelper.GetExpressionText(expression);
            ModelMetadata metadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            var selectedItem = (TItem)metadata.Model;

            using (var dbContext = new ApplicationDbContext())
            {
                var items = query(dbContext).ToArray();
                return htmlHelper.DropDownListFor(expression, items);
            }
        }
    }
}