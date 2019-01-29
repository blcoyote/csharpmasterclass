﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world
{

	
    class Human
    {
		//member variable
        private string firstName;
		private string lastName;
		private string eyecolour;
		private int age;

		//constructor
		public Human()
		{
			Console.WriteLine("Constructer called, object created!");
		}

		public Human(string firstName, string lastName, string eyecolour, int age) {
			this.lastName = lastName;
			this.firstName = firstName;
			this.eyecolour = eyecolour;
			this.age = age;
		}

		public void IntroduceMyself() {
			if (age != 0)
			{
				Console.WriteLine($"Hi, I'm {firstName} {lastName}, my eyes are {eyecolour} and I'm {age} years old");
			}
			else {
				Console.WriteLine($"Hi, I'm {firstName} {lastName}, my eyes are {eyecolour}");
			}
        }

    }
}
