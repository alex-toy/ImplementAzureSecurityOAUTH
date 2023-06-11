# Implement Azure Security - OAUTH


## OAUTH

### Postman tool

- add an **App Registration**
<img src="/pictures/app_registration.png" title="app registration"  width="500">

- add role assignments to the storage account
<img src="/pictures/role.png" title="role assignment"  width="900">

Now the postman **App Registration** needs an access token in order to access the blob storage.

- grab the url endpoint to get an access token
<img src="/pictures/url_access_token.png" title="OAuth 2.0 token endpoint (v1)"  width="900">

- get the client id
<img src="/pictures/url_access_token1.png" title="OAuth 2.0 token endpoint (v1)"  width="900">

- create a secret for postman
<img src="/pictures/url_access_token1b.png" title="OAuth 2.0 token endpoint (v1)"  width="900">

- use that endpoint, client id and secret to get an access token
<img src="/pictures/url_access_token2.png" title="OAuth 2.0 token endpoint (v1)"  width="900">
<img src="/pictures/url_access_token3.png" title="OAuth 2.0 token endpoint (v1)"  width="900">

- finally, retrieve the access token
<img src="/pictures/url_access_token4.png" title="OAuth 2.0 token endpoint (v1)"  width="900">

- and use the access token to retrieve the blob
<img src="/pictures/url_access_token5.png" title="OAuth 2.0 token endpoint (v1)"  width="900">

### Azure Key Vault

- create an **Azure Key Vault**

- create a secret
<img src="/pictures/kv2.png" title="Azure Key Vault"  width="900">

- add get access for postman
<img src="/pictures/kv3.png" title="Azure Key Vault"  width="900">

- get the secret identifier and use it for postman. Append "?api-version=7.1"
<img src="/pictures/kv4.png" title="Azure Key Vault"  width="500">

- get access token for *vault*
<img src="/pictures/kv41.png" title="Azure Key Vault"  width="900">

- use it in postman to retrieve the secret
<img src="/pictures/kv5.png" title="Azure Key Vault"  width="900">

### Graph API

- remove the *User.Read* permission
<img src="/pictures/api.png" title="api"  width="900">

- add a permission. Choose *Microsoft Graph* the *application permission*
<img src="/pictures/api2.png" title="api"  width="500">
<img src="/pictures/api3.png" title="api"  width="500">

- get access token for *graph*
<img src="/pictures/api4.png" title="api"  width="900">

### Implementing sign in - sign out

- install packages
```
Microsoft.Identity.Web
Microsoft.Identity.Web.UI
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.Sqlite
```

- create an application in *Active Directory*
<img src="/pictures/webapp.png" title="api"  width="500">

- grab the client id and tenant id and use it in *appsettings.json*
<img src="/pictures/webapp2.png" title="api"  width="900">

- add a platform. Choose Web platform.
<img src="/pictures/webapp3.png" title="api"  width="900">

- add new scaffolded item
<img src="/pictures/webapp4.png" title="api"  width="500">
<img src="/pictures/webapp5.png" title="api"  width="500">

- run the app. Clic on accept and you are signed in.
<img src="/pictures/webapp6.png" title="api"  width="900">

### Get Access Token

- add a permission. Choose **Azure Storage**, **Delegated Permissions**
<img src="/pictures/access_token.png" title="access token"  width="900">

- add roles for another user
<img src="/pictures/access_token2.png" title="access token"  width="900">

- add a secret for the app
<img src="/pictures/access_token3.png" title="access token"  width="900">

- run the app
<img src="/pictures/access_token4.png" title="access token"  width="900">

### Group Claims

- add group claims
<img src="/pictures/group_claims.png" title="group claims"  width="900">

- run the app
<img src="/pictures/group_claims2.png" title="group claims"  width="900">

### Azure AD Authentication

- create web app and add its url to the app registration
<img src="/pictures/ad_auth.png" title="group claims"  width="900">

- run the app
<img src="/pictures/ad_auth2.png" title="group claims"  width="900">
