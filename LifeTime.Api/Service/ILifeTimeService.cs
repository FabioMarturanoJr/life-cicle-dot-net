namespace LifeTime.Api.Service;

public interface ILifeTimeService
{
	string GetIdLifeTime();
}

public interface ILifeTimeServiceTransient : ILifeTimeService
{
}

public interface ILifeTimeServiceScoped : ILifeTimeService
{
}

public interface ILifeTimeServiceSingleton : ILifeTimeService
{ 
}


