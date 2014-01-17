using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using jui.Core;
using jui.Interfaces;

namespace jui.Controls
{
	public class Alert : HtmlElement<Alert>
	{
		public Alert()
			: base("div")
		{
			AddClass("ui-state-error");
		}
	}
}
