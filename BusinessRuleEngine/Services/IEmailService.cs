﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    public interface IEmailService
    {
        public void SendEmail(string email);
    }
}
