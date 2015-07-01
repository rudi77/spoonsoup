using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpoonSoup
{
	public class ImageInfo
	{
		/// <summary>
		/// Get or set the image id which uniquely identifies
		/// an image.
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		/// Get or set a human readable image name
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Get or set an image tag.
		/// </summary>
		public string Tag { get; set; }

		/// <summary>
		/// Get or set the creation date of an image
		/// </summary>
		public DateTime Created { get; set; }

		/// <summary>
		/// Get or set the image size in MB.
		/// </summary>
		public float Size { get; set; }
	}
}
