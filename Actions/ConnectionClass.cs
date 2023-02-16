using BrovkiTest.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrovkiTest.Actions
{
    internal class ConnectionClass
    {
        // Подключение к БД
        public static det_user7Entities ConnectionPoint { get; set; } = new det_user7Entities();

    }
}
