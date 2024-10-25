using System;

namespace Cerberus.API.Common.Constants;

public static class ApiEndpoints
{
        public const string Base = "api/v{Version:apiVersion}";
    public static class UserMgmt
    {
        public const string Users = Base + "/users";
        public const string User = Users + "/{userId}";
    }
}