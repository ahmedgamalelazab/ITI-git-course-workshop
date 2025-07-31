using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.Person
{
	internal class Teacher : Person
	{
		private string subject;
		
        private  Teacher(int _id , string _name , int age , string _subject ) : base ( _id , _name , age )
        {
			subject = _subject;
		}
		private static Teacher SingeltonObj = null!;
		
		public static Teacher GetTeacher(int id, string name, int age, string subject)
		{
			if (SingeltonObj == null)
			{
				SingeltonObj = new Teacher(id , name ,age,subject);		
			}
			return SingeltonObj;
		}

    }
}
