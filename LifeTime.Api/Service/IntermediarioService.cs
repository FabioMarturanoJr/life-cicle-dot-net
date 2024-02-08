namespace LifeTime.Api.Service
{
    public class IntermediarioService(
        ILifeTimeServiceTransient lifeTimeServiceTransient, 
        ILifeTimeServiceScoped lifeTimeServiceScoped,
        ILifeTimeServiceSingleton lifeTimeServiceSingleton
        ) : IIntermediarioService
    {


        public string GetIdLifeTimeTransient()
        {
            return lifeTimeServiceTransient.GetIdLifeTime();
        }
        public string GetIdLifeTimeScoped()
        {
            return lifeTimeServiceScoped.GetIdLifeTime();
        }

        public string GetIdLifeTimeSingleton()
        {
            return lifeTimeServiceSingleton.GetIdLifeTime();
        }
    }
}
