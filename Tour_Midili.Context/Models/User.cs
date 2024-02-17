﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TourTest.Context.Models.Enums;

namespace TourTest.Context.Models
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; } = string.Empty;
        public string Login { get; set; }
        public string Password { get; set; }
        public RoleType Role { get; set; }
    }
}
