using Rx.Http;
using Rx.Http.Extensions;
using Rx.Http.Interceptors;

namespace Keycloak.Dict
{
    class KeycloakTokenInterceptor : RxRequestInterceptor
    {
        public void Intercept(RxHttpRequestOptions request)
        {
            // Implement your logic to handle your token here
            request.UseBearerAuthorization("token");
        }
    }
}
