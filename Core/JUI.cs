using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using jui.Builders;
using jui.Controls;

namespace jui.Core
{
	public class JUI<TModel>
	{
		public HtmlHelper<TModel> Html;

		public JUI(HtmlHelper<TModel> _html)
		{
			Html = _html;
		}

		public AlertBuilder<TModel> Begin(Alert alert)
		{
			return new AlertBuilder<TModel>(Html, alert);
		}

		public HighlightBuilder<TModel> Begin(Highlight alert)
		{
			return new HighlightBuilder<TModel>(Html, alert);
		}
	}
}
