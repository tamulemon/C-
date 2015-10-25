using System;

class Student
{
	private float _grade;

	public float Grade 
	{
		get {return _grade; }

		set 
		{ 
			if (value < 0 || value > 5) 
			{
				Console.WriteLine("Grade out of bound."); // if out of bound, default value is set to 0???
				return;
			}
			_grade = value;
		}
	}
}