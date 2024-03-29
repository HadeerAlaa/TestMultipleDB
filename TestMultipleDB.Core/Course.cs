﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Abp.Domain.Entities;

namespace TestMultipleDB
{
	[Table("Courses")] //In second database
	public class Course : Entity
	{
		public virtual string CourseName { get; set; }

		public Course()
		{

		}

		public Course(string courseName)
		{
			CourseName = courseName;
		}
	}
}
