﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.UserGithubs.Dtos
{
    public class UserGithubByIdDto
    {
        public int Id { get; set; }
        public string GithubAdderess { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
