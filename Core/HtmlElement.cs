using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace jui.Core
{
	public abstract class HtmlElement<TControl> where TControl : HtmlElement<TControl>
	{
		public IDictionary<string, object> htmlAttributes;
		protected string tag;
		protected string classToEnsure;

		internal HtmlElement(string _tag)
		{
			htmlAttributes = new Dictionary<string, object>();
			tag = _tag;
		}

		internal string EndTag
		{
			get
			{
				return string.IsNullOrEmpty(tag) ? string.Empty : string.Format("</{0}>", tag);
			}
		}

		internal virtual string StartTag
		{
			get
			{
				/*if (string.IsNullOrEmpty(this.tag)) return string.Empty;
				TagBuilder builder = new TagBuilder(this.tag);
				builder.MergeAttributes<string, object>(this.htmlAttributes);
				return builder.ToString(TagRenderMode.StartTag);*/
				if (string.IsNullOrEmpty(tag)) return string.Empty;
				return string.Format("<{0}>", tag);
			}
		}

		internal string IdValue
		{
			get;
			set;
		}

		protected void AddClass(string className)
		{
			if (htmlAttributes.ContainsKey("class"))
			{
				string currentValue = htmlAttributes["class"].ToString();
				if (!currentValue.Contains(className))
				{
					htmlAttributes["class"] += " " + className;
				}
			}
			else
			{
				//MergeHtmlAttribute("class", className);
			}
		}

		protected void RemoveClass(string className)
		{
			if (!htmlAttributes.ContainsKey("class")) return;

			string currentValue = htmlAttributes["class"].ToString();
			if (currentValue.Contains(className))
			{
				htmlAttributes["class"] = currentValue.Replace(className, "").Replace("  ", "").Trim();
			}
		}

		public TControl Id(String id)
		{
			IdValue = id;
			return this as TControl;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString() { return base.ToString(); }

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj) { return base.Equals(obj); }

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode() { return base.GetHashCode(); }

		[EditorBrowsable(EditorBrowsableState.Never)]
		public new Type GetType() { return base.GetType(); }
	}
}
