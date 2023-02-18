﻿namespace API.Models
{
    public class RegisterUserRequest
    { 
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Designation { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
