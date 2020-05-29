﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TMS_Client.Models
{
    public enum Event
    {
        OpenTicket,
        CloseTicket, 
        AssignTicket,
        ReAssignTicket, 
        DeleteTicket,
        AddInternalNote,
        AddThreadMessage
    }
}