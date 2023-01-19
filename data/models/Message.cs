﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tchat.data.models
{
    public class Message
    {
        public int Id { get; set; }
        public string Messages { get; set; } = null!;
        public DateTime Date { get; set; }
        public string Image { get; set; } = null!;
        public int IdUser { get; set; }
        public int IdChannel { get; set; }
    }
}
