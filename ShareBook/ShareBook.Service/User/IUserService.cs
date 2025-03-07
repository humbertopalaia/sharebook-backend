﻿using ShareBook.Domain;
using ShareBook.Domain.Common;
using ShareBook.Domain.DTOs;
using ShareBook.Service.Generic;
using System;
using System.Collections.Generic;

namespace ShareBook.Service
{
    public interface IUserService : IBaseService<User>
    {
        Result<User> AuthenticationByEmailAndPassword(User user);
        bool IsValidPassword(User user, string decryptedPass);
        new Result<User> Update(User user);
        Result<User> ValidOldPasswordAndChangeUserPassword(User user, string newPassword);
        Result<User> ChangeUserPassword(User user, string newPassword);
        Result GenerateHashCodePasswordAndSendEmailToUser(string email);
        Result ConfirmHashCodePassword(string hashCodePassword);
        IList<User> GetFacilitators(Guid userIdDonator);
        IList<User> GetBySolicitedBookCategory(Guid BookCategoryId);
        UserStatsDTO GetStats(Guid? userId);
        Result<User> Insert(RegisterUserDTO userDto);
        void ParentAproval(string parentHashCodeAproval);
    }
}
