﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MakerBotNameSpace.Types;

namespace MakerBotNameSpace.Types
{

	public class File
	{

		[JsonProperty("Id")]
		public int Id { get; set; }

		[JsonProperty("FileName")]
		public string FileName { get; set; }

		[JsonProperty("FilePath")]
		public object FilePath { get; set; }

		[JsonProperty("NumberOfLines")]
		public int NumberOfLines { get; set; }

	}

	public class File2
	{

		[JsonProperty("Id")]
		public int Id { get; set; }

		[JsonProperty("FileName")]
		public string FileName { get; set; }

		[JsonProperty("FilePath")]
		public object FilePath { get; set; }

		[JsonProperty("NumberOfLines")]
		public int NumberOfLines { get; set; }
	}

	public class Printer
	{

		[JsonProperty("Bookings")]
		public object[] Bookings { get; set; }

		[JsonProperty("Id")]
		public int Id { get; set; }

		[JsonProperty("Name")]
		public string Name { get; set; }

		[JsonProperty("UuId")]
		public string UuId { get; set; }

		[JsonProperty("IsBookable")]
		public bool IsBookable { get; set; }

		[JsonProperty("LastSeen")]
		public string LastSeen { get; set; }

		[JsonProperty("BedTemperature")]
		public int BedTemperature { get; set; }

		[JsonProperty("NozzleTemperature")]
		public int NozzleTemperature { get; set; }

		[JsonProperty("Printing")]
		public bool Printing { get; set; }

		[JsonProperty("Paused")]
		public bool Paused { get; set; }

		[JsonProperty("CurrentLine")]
		public int CurrentLine { get; set; }
	}

	public class Booking2
	{

		[JsonProperty("BookingPrintError")]
		public object[] BookingPrintError { get; set; }

		[JsonProperty("File")]
		public File2 File { get; set; }

		[JsonProperty("Printer")]
		public Printer Printer { get; set; }

		[JsonProperty("Id")]
		public int Id { get; set; }

		[JsonProperty("FileId")]
		public int? FileId { get; set; }

		[JsonProperty("UserId")]
		public int UserId { get; set; }

		[JsonProperty("StartTime")]
		public string StartTime { get; set; }

		[JsonProperty("EndTime")]
		public string EndTime { get; set; }

		[JsonProperty("PrinterId")]
		public int PrinterId { get; set; }
	}

	public class UserRole
	{

		[JsonProperty("Users")]
		public object[] Users { get; set; }

		[JsonProperty("Id")]
		public int Id { get; set; }

		[JsonProperty("RoleName")]
		public string RoleName { get; set; }

		[JsonProperty("CanCreateBooking")]
		public bool CanCreateBooking { get; set; }

		[JsonProperty("CanViewDashboard")]
		public bool CanViewDashboard { get; set; }
	}

	public class User
	{

		[JsonProperty("BookingPrintErrors")]
		public object[] BookingPrintErrors { get; set; }

		[JsonProperty("Bookings")]
		public Booking2[] Bookings { get; set; }

		[JsonProperty("UserRole")]
		public UserRole UserRole { get; set; }

		[JsonProperty("Id")]
		public int Id { get; set; }

		[JsonProperty("FirstName")]
		public string FirstName { get; set; }

		[JsonProperty("LastName")]
		public string LastName { get; set; }

		[JsonProperty("Email")]
		public string Email { get; set; }

		[JsonProperty("StudieNummer")]
		public int StudieNummer { get; set; }

		[JsonProperty("AccessCard")]
		public int AccessCard { get; set; }

		[JsonProperty("UserRoleId")]
		public int UserRoleId { get; set; }
	}

	public class Booking
	{

		[JsonProperty("BookingPrintError")]
		public object[] BookingPrintError { get; set; }

		[JsonProperty("File")]
		public File File { get; set; }

		[JsonProperty("User")]
		public User User { get; set; }

		[JsonProperty("Id")]
		public int Id { get; set; }

		[JsonProperty("FileId")]
		public int? FileId { get; set; }

		[JsonProperty("UserId")]
		public int UserId { get; set; }

		[JsonProperty("StartTime")]
		public string StartTime { get; set; }

		[JsonProperty("EndTime")]
		public string EndTime { get; set; }

		[JsonProperty("PrinterId")]
		public int PrinterId { get; set; }
	}

}

namespace MakerBotNameSpace
{

	public class MakerBot
	{

		[JsonProperty("Bookings")]
		public Booking[] Bookings { get; set; }

		[JsonProperty("Id")]
		public int Id { get; set; }

		[JsonProperty("Name")]
		public string Name { get; set; }

		[JsonProperty("UuId")]
		public string UuId { get; set; }

		[JsonProperty("IsBookable")]
		public bool IsBookable { get; set; }

		[JsonProperty("LastSeen")]
		public string LastSeen { get; set; }

		[JsonProperty("BedTemperature")]
		public int BedTemperature { get; set; }

		[JsonProperty("NozzleTemperature")]
		public int NozzleTemperature { get; set; }

		[JsonProperty("Printing")]
		public bool Printing { get; set; }

		[JsonProperty("Paused")]
		public bool Paused { get; set; }

		[JsonProperty("CurrentLine")]
		public int CurrentLine { get; set; }
	}

}