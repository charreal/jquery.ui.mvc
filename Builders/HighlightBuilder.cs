using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using jui.Controls;
using jui.Core;

namespace jui.Builders
{
	public class HighlightBuilder<TModel> : AbstractBuilder<TModel, Highlight>
	{
		internal HighlightBuilder(HtmlHelper<TModel> _htmlHelper, Highlight _element)
			: base(_htmlHelper, _element)
		{

		}
	}
}
