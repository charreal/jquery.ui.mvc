using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace jui.Core
{
	public class JUIAjax<TModel>
	{
		public AjaxHelper<TModel> Ajax;

		public JUIAjax(AjaxHelper<TModel> ajax)
        {
            Ajax = ajax;
        }
	}
}
