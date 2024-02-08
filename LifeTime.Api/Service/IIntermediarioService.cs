namespace LifeTime.Api.Service;

public interface IIntermediarioService
{
    string GetIdLifeTimeTransient();
    string GetIdLifeTimeScoped();
    string GetIdLifeTimeSingleton();
}
