using Autofac;
using IoCApp.Biz.Logger;

namespace IoCApp.Biz
{
    class Foo
    {
        //private readonly IContainer _cntr;
        private readonly ILogger _logger;

        ///// <summary>
        ///// Amb aixó no sabem de que depenem, es una implementacio service locator(factoria) - Antipatró
        ///// </summary>
        ///// <param name="container"></param>
        //public Foo(IContainer container)
        //{
        //    _cntr = container;
        //}

        /// <summary>
        /// Aquí si que veiem que depenem d'unlogger
        /// </summary>
        /// <param name="logger"></param>
        public Foo(ILogger logger)
        {
            _logger = logger;
        }

        public int Bar()
        {
            //Antipatró
            //_logger = _cntr.Resolve<ILogger>();
            _logger.Log("Returning the answer for all...");
            return 42;
        }
    }
}
