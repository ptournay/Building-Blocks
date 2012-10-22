﻿using System;
using System.Collections.Generic;
using BuildingBlocks.Common;
using BuildingBlocks.Membership.Entities;

namespace BuildingBlocks.Membership.Contract
{
    public interface IUserRepository
    {
        bool HasUserWithName(string username);
        bool HasUserWithEmail(string email);
        IEnumerable<User> FindUsersByNames(string[] usernames);
        User FindUserByName(string username);
        User FindUserByEmail(string email);
        User FindUserById(Guid userId);
        int GetUsersCountWithLastActivityDateGreaterThen(DateTime dateActive);
        void AddUser(User newUser);
        void SaveUser(User user);
        void DeleteUser(User user);
        Page<User> GetUsersPageByEmail(string emailToMatch,int pageIndex, int pageSize);
        Page<User> GetUsersPageByUsername(string usernameToMatch, int pageIndex, int pageSize);
        Page<User> GetUsersPage(int pageIndex, int pageSize);
    }
}