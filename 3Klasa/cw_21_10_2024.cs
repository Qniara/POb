using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_21_10_2024
{
	public interface IAnimal
	{
		void MakeSound();
		void Eat();
	}
	public abstract class Animal : IAnimal
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public Animal(string name, int age)
		{
			Name = name;
			Age = age;
		}
		public abstract void MakeSound();
		public void Eat()
		{
			Console.WriteLine($"{Name} je");
		}
	}
	public class Ryba : Animal
	{
		public override void MakeSound()
		{
			Console.WriteLine("Bul bul bul");
		}
	}
	public class Wrobel : Animal
	{
		public Wrobel(string name, int age) : base(name, age)
		{

		}
		public override void MakeSound()
		{
			Console.WriteLine("Meow");
		}
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			Ryba ryba = new Ryba();
			Wrobel kupa = new Wrobel("kupa", 19);
			ryba.MakeSound();
			kupa.MakeSound();
			Console.ReadKey();
			kupa.Eat();
		}
	}
}
