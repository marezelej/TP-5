﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        IAccountRepository AccountRepository { get; set; }
        IClientRepository ClientRepository { get; set; }
        void Complete();
    }
}
