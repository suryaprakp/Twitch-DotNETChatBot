﻿using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;


    public static class SessionExtensions
    {

        public static void Set<T>(this ISession curentSession, string objKey, T objValue)
        {
        curentSession.SetString(objKey, JsonConvert.SerializeObject(objValue));
        }

        public static T Get<T>(this ISession currentSession, string objKey)
        {
            var objValue = currentSession.GetString(objKey);
            return objValue == null ? default(T) : JsonConvert.DeserializeObject<T>(objValue);
        }
    }
