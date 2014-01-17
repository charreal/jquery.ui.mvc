using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using jui.Controls;
using jui.Core;

namespace jui.Builders
{
	public class AlertBuilder<TModel> : AbstractBuilder<TModel, Alert>
	{
		internal AlertBuilder(HtmlHelper<TModel> _htmlHelper, Alert _element) 
			: base(_htmlHelper, _element)
		{

		}
	}
}
