using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace jui.Core
{
	public class AbstractBuilder<TModel, T> : IDisposable where T : HtmlElement<T>
	{
		protected readonly T element;

		protected readonly TextWriter textWriter;
		protected readonly HtmlHelper<TModel> htmlHelper;
		protected readonly AjaxHelper<TModel> ajaxHelper;

		internal AbstractBuilder(HtmlHelper<TModel> _htmlHelper, T _element)
        {
			if (_element == null)
            {
				throw new ArgumentNullException("_element");
            }

			element = _element;
			htmlHelper = _htmlHelper;
            textWriter = htmlHelper.ViewContext.Writer;
            textWriter.Write(element.StartTag);
        }

		internal AbstractBuilder(AjaxHelper<TModel> _ajaxHelper, T _element)
        {
            if (element == null)
            {
				throw new ArgumentNullException("_element");
            }

			element = _element;
			ajaxHelper = _ajaxHelper;
            textWriter = ajaxHelper.ViewContext.Writer;
            textWriter.Write(element.StartTag);
        }

		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual void Dispose()
		{
			textWriter.Write(element.EndTag);
		}
	}
}
