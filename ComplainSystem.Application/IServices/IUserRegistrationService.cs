﻿using ComplainSystem.DomainModelCore.CoreEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplainSystem.Application.IServices
{
    //This is the use case
    public interface IUserRegistrationService
    {
        UserRegistartion NewUserRegistration(UserRegistartion userModel);

        List<UserRegistartion> GetAllRegisteredUsers();
    }
}
