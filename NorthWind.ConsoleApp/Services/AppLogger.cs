using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
using NorthWind.Entities.ValueObjects;
using NorthWind.Writers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace NorthWind.ConsoleApp.Services
{
    internal class AppLogger(IEnumerable<IUserActionWriter> writers)
    {
        public void WriteLog(string message)
        {
            UserAction Log = new UserAction("System", message);
            foreach (var Writer in writers)
            {
                Writer.Write(Log);
            }
        }
    }
}
