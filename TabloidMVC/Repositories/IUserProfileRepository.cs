﻿using System.Collections.Generic;
using TabloidMVC.Models;

namespace TabloidMVC.Repositories
{
    public interface IUserProfileRepository
    {
        UserProfile GetByEmail(string email);
        public List<UserProfile> GetAllUserProfiles();
        UserProfile GetById(int id);
        public void DeactiveUser(int id);
        void EditUser(UserProfile user);
    }
}