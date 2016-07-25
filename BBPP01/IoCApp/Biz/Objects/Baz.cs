using IoCApp.Biz.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCApp.Biz.Objects
{
    class Baz
    { 
        private readonly ILogger _logger;

        /// <summary>
        /// Aquí si que veiem que depenem d'unlogger
        /// </summary>
        /// <param name="logger"></param>
        public Baz(ILogger logger)
        {
            _logger = logger;
        }

        public int Bar()
        {
            _logger.Log("Returning the answer for all...");
            return 42;
        }
    }
}
