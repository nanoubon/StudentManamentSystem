using System;
using FristApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FristApp.Data
{
	public class ApplicationDBContext:DbContext
	{
		public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) :base(options)
		{
			
		}
		public DbSet<Student> Students { get; set; }
	}
}

