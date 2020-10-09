﻿//Язык регильаные старндарт > Дополнительные параметры > РАзделитель дробной чатси поставить .
//MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
//builder.Server = "localhost";
//builder.Port = 3306;
//builder.Database = "InventorySystem";
//builder.UserID = "root";
//builder.Password = "";
//builder.CharacterSet = "utf8";
//Console.WriteLine(builder.ConnectionString);// server=localhost;port=3306;database=InventorySystem;user id=root;password=;characterset=utf8

// enable-migrations | add-migration <NameMigration> | update-database

namespace DesktopVersion
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class JobPosition
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[Index(IsUnique = true)]
		[MaxLength(255)]
		public string Name { get; set; }

		public ICollection<Employee> Employees;

		public JobPosition()
		{
			Employees = new List<Employee>();
		}

	}
}