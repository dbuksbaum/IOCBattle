using IocBattle.Benchmark.Models;
using Caliburn.Micro;

namespace IocBattle.Benchmark.Tests
{
  public class CaliburnContainer : IContainer
  {
    private SimpleContainer _container;

    #region Implementation of IContainer
    public string Name
    {
      get { return "Caliburn.Micro SimpleContainer"; }
    }
    public T Resolve<T>() where T : class
    {
      return (T)_container.GetInstance(typeof(T), null);
    }
    public void SetupForTransientTest()
    {
      _container = new SimpleContainer();

      _container.RegisterPerRequest(typeof(IRepository), null, typeof(Repository));
      _container.RegisterPerRequest(typeof(IAuthenticationService), null, typeof(AuthenticationService));
      _container.RegisterPerRequest(typeof(UserController), null, typeof(UserController));

      _container.RegisterPerRequest(typeof(IWebService), null, typeof(WebService));
      _container.RegisterPerRequest(typeof(IAuthenticator), null, typeof(Authenticator));
      _container.RegisterPerRequest(typeof(IStockQuote), null, typeof(StockQuote));
      _container.RegisterPerRequest(typeof(IDatabase), null, typeof(Database));
      _container.RegisterPerRequest(typeof(IErrorHandler), null, typeof(ErrorHandler));

      _container.RegisterPerRequest(typeof(IService1), null, typeof(Service1));
      _container.RegisterPerRequest(typeof(IService2), null, typeof(Service2));
      _container.RegisterPerRequest(typeof(IService3), null, typeof(Service3));
      _container.RegisterPerRequest(typeof(IService4), null, typeof(Service4));

      _container.RegisterPerRequest(typeof(ILogger), null, typeof(Logger));
    }
    public void SetupForSingletonTest()
    {
      _container = new SimpleContainer();

      _container.RegisterSingleton(typeof(IRepository), null, typeof(Repository));
      _container.RegisterSingleton(typeof(IAuthenticationService), null, typeof(AuthenticationService));
      _container.RegisterSingleton(typeof(UserController), null, typeof(UserController));

      _container.RegisterSingleton(typeof(IWebService), null, typeof(WebService));
      _container.RegisterSingleton(typeof(IAuthenticator), null, typeof(Authenticator));
      _container.RegisterSingleton(typeof(IStockQuote), null, typeof(StockQuote));
      _container.RegisterSingleton(typeof(IDatabase), null, typeof(Database));
      _container.RegisterSingleton(typeof(IErrorHandler), null, typeof(ErrorHandler));

      _container.RegisterSingleton(typeof(IService1), null, typeof(Service1));
      _container.RegisterSingleton(typeof(IService2), null, typeof(Service2));
      _container.RegisterSingleton(typeof(IService3), null, typeof(Service3));
      _container.RegisterSingleton(typeof(IService4), null, typeof(Service4));

      _container.RegisterSingleton(typeof(ILogger), null, typeof(Logger));
    }
    #endregion
  }
}