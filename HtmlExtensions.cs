using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using jui.Core;

namespace jui
{
    public static class HtmlExtensions
    {
		public static JUI<TModel> JUI<TModel>(this HtmlHelper<TModel> helper)
		{
			return new JUI<TModel>(helper);
		}

		public static JUIAjax<TModel> JUI<TModel>(this AjaxHelper<TModel> helper)
		{
			return new JUIAjax<TModel>(helper);
		}
    }
}
