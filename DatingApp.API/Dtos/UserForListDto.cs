using System;
using System.Collections.Generic;
using DatingApp.API.Model;

namespace DatingApp.API.Dtos
{
    public class UserForListDto
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string KnownAs { get; set; }

        public DateTime Created { get; set; }

        public DateTime lastActive { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public ICollection<Photo> Photos { get; set; }

        public string PhotoUrl { get; set; }
    }
}