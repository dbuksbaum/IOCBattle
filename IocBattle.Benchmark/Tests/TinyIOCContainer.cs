using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IocBattle.Benchmark.Models;
using TinyContainer = TinyIoC.TinyIoCContainer;

namespace IocBattle.Benchmark.Tests
{
  public class TinyIOCContainer : IContainer
  {
    private TinyContainer _container;

    #region Implementation of IContainer
    public string Name
    {
      get { return "TinyIOC"; }
    }
    public T Resolve<T>() where T : class
    {
      return _container.Resolve<T>();
    }
    public void SetupForTransientTest()
    {
      _container = new TinyContainer();

      _container.Register<IRepository, Repository>();
      _container.Register<IAuthenticationService, AuthenticationService>();
      _container.Register<UserController, UserController>();

      _container.Register<IWebService, WebService>();
      _container.Register<IAuthenticator, Authenticator>();
      _container.Register<IStockQuote, StockQuote>();
      _container.Register<IDatabase, Database>();
      _container.Register<IErrorHandler, ErrorHandler>();

      _container.Register<IService1, Service1>();
      _container.Register<IService2, Service2>();
      _container.Register<IService3, Service3>();
      _container.Register<IService4, Service4>();

      _container.Register<ILogger, Logger>();
    }
    public void SetupForSingletonTest()
    {
      _container = new TinyContainer();

      _container.Register<IRepository, Repository>().AsSingleton();
      _container.Register<IAuthenticationService, AuthenticationService>().AsSingleton();
      _container.Register<UserController, UserController>().AsSingleton();

      _container.Register<IWebService, WebService>().AsSingleton();
      _container.Register<IAuthenticator, Authenticator>().AsSingleton();
      _container.Register<IStockQuote, StockQuote>().AsSingleton();
      _container.Register<IDatabase, Database>().AsSingleton();
      _container.Register<IErrorHandler, ErrorHandler>().AsSingleton();

      _container.Register<IService1, Service1>().AsSingleton();
      _container.Register<IService2, Service2>().AsSingleton();
      _container.Register<IService3, Service3>().AsSingleton();
      _container.Register<IService4, Service4>().AsSingleton();

      _container.Register<ILogger, Logger>().AsSingleton();
    }
    #endregion
  }
}
