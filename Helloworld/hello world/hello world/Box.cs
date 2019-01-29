using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world
{
	class Box
	{
		public int Length { get; set; }
		public int Height { get; set; }
		public int Depth { get; set; }
		public int Volume { get; set; }
		public int FrontSurface { get { return Height * Length; } }

		public void DisplayInfo() {
			Console.WriteLine($"Length is {Length}, height is {Height} with is {Depth} which gives a volume of {Volume = Depth * Height * Length}");
			Console.WriteLine($"Front surface is {FrontSurface}");
		}


	}
}
