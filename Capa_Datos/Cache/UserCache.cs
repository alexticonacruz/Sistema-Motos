﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Capa_Datos.Cache
{
    public static class UserCache
    {
        public static int IdUser { get; set; }
        public static string LoginName { get; set; }
        public static string Password { get; set; }

        public static string Position { get; set; }

    }
}
