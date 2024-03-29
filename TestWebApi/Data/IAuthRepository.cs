﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWebApi.Models;

namespace TestWebApi.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string passowrd);

        Task<User> Login(string username, string password);

        Task<bool> UserExict(string username);



    }
}
