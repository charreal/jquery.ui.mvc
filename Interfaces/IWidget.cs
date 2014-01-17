using System;

namespace jui.Interfaces
{
	public interface IWidget<out T>
	{
		T Id(String id);
		T Attr(String attr, String val);
	}
}
