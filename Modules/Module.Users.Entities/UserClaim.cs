﻿using Core.Interfaces.Entities;
using Microsoft.AspNetCore.Identity;

namespace Module.Users.Entities
{
    public class UserClaim : IdentityUserClaim<long>, IEntity
    {
    }
}