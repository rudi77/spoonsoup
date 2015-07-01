using System.Collections.Generic;

namespace SpoonSoup
{
	public interface ISpoon
	{
		IEnumerable<ImageInfo> GetLocalImages();
	}
}
