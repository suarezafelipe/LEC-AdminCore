using Microsoft.AspNetCore.Http;


namespace AdminCore.Persistence.Audit
{
    public class SessionManager : ISessionManager
    {
        private readonly IHttpContextAccessor _sessionContext;

        public SessionManager(IHttpContextAccessor sessionContext)
        {
            _sessionContext = sessionContext;
        }
        
        public string SessionId => _sessionContext.HttpContext.Session.Id;
    }
}