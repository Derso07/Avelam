﻿namespace ApplicationCore.Avelam.Models
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
