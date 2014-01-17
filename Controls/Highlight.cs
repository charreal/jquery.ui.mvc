using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using jui.Core;

namespace jui.Controls
{
	public class Highlight : HtmlElement<Highlight>
	{
		public Highlight()
			: base("div")
		{
			AddClass("ui-state-highlight");
		}
	}
}
