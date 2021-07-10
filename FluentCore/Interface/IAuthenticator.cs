﻿using FluentCore.Model.Auth;
using FluentCore.Model.Auth.Mojang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentCore.Interface
{
    public interface IAuthenticator : IDisposable
    {
        Tuple<StandardResponseModel, AuthResponseTypeModel> Authenticate();

        Task<Tuple<StandardResponseModel, AuthResponseTypeModel>> AuthenticateAsync();
    }
}
