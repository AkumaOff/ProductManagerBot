﻿using Microsoft.EntityFrameworkCore;
using ProductManagerBot.Data.Entities;
using ProductManagerBot.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagerBot.Services.UserService
{
    internal class UserService : IUserService
    {
        private readonly AppDbContext _appDbContext;
        public UserService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        /*public async void Add(int userid, int productid)
        {
            await _appDbContext.FavoriteProducts.AddAsync(new FavoriteProduct() { UserId = userid, ProductId = productid });
            await _appDbContext.SaveChangesAsync();
        }
        */

        public async void Delete(int id)
        {
            _appDbContext.Users.Remove(new User() { Id = id });
            await _appDbContext.SaveChangesAsync();
        }
        /*
        public async void Update(int id, int userid, int productid)
        {
            _appDbContext.Entry(new FavoriteProduct { Id = id, UserId = userid, ProductId = productid })
                         .State = EntityState.Modified;
            await _appDbContext.SaveChangesAsync();

        }
        */
    }
}
