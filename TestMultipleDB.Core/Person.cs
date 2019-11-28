using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Abp.Domain.Entities;

namespace TestMultipleDB
{
	[Table("Persons")] //In first database
	public class Person : Entity
	{
		public virtual string PersonName { get; set; }

		public Person()
		{

		}

		public Person(string personName)
		{
			PersonName = personName;
		}
	}
}
