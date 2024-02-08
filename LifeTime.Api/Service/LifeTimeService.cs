namespace LifeTime.Api.Service
{
    public class LifeTimeService : ILifeTimeServiceTransient, ILifeTimeServiceScoped, ILifeTimeServiceSingleton
    {
        readonly string _idLifeTime;
        public LifeTimeService() => _idLifeTime = Guid.NewGuid().ToString();

        public string GetIdLifeTime()
        {
            return _idLifeTime;
        }
    }
}
