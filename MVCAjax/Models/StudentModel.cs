﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCAjax.Models
{
	public class StudentModel
	{
		[Key]
		public int ID { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string Address { get; set; }
		public string LastName { get; set; }
		public int StudentCode { get; set; }
		public DateTime CreationDate { get; set; }
		public DateTime EditDate { get; set; }
		public bool State { get; set; }
	}
}