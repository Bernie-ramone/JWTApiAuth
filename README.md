# JWTApiAuth

A JWT (JSON Web Token) is a signed string that carries information about the user. 
When a user logs in, your API creates this token and hands it back. 
The client stores it and attaches it to every future request. 
Your API checks the signature, trusts the contents, and lets the request through.

A JWT has three parts, separated by dots: `header.payload.signature.`


* **Header** - JWT and which algorithm signed it (for example, HMAC SHA-256).
* **Payload** - the data(claims). User details and role an expiry time.
* **Signature** - the header and payload signed with a secret key only your server knows.

### JWT Authentication flow

1. The user sends their email and password to a login endpoint.

2. Your API checks the credentials. If they are valid, it builds a JWT with the user’s claims and signs it.

3. The API returns the token. The client stores it.

4. On every protected request, the client sends the token in the Authorization: Bearer <token> header.

5. ASP.NET Core validates the signature and the expiry. If everything checks out, the request is treated as authenticated.

The server never stores the token. It only needs the secret key to validate it. 
That is what makes JWT stateless.


## When Should You Use JWT?

JWT is not the only way to authenticate in ASP.NET Core, 
and it is not always the right one. 

| Approach | Best for | Trade-off |
|--- | --- | --- | 
| JWT bearer tokens | SPAs (React, Angular), mobile apps, and service-to-service calls | You manage token lifetime and refresh yourself |
| Cookie authentication | Server-rendered apps (MVC, Razor Pages) on the same domain | Tied to the browser; needs anti-forgery protection|
| Identity API endpoints (MapIdentityApi) |	Spinning up Identity-backed token endpoints fast | Less control over the token and the login flow|
| API keys | Machine-to-machine and third-party integrations | Identifies an app, not a user - no roles or claims|


Reference: [JWT Authentication in ASP.NET Core - A Complete .NET 10 Guide](https://codewithmukesh.com/blog/jwt-authentication-in-aspnet-core/) (codewithmukesh.com)