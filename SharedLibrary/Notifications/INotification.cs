﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Notifications
{
    public interface INotification
    {
        void Send(string to, string message);
    }
}
