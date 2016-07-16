﻿using System.Net;
using System.Threading.Tasks;
using BitBucket.REST.API.Exceptions;
using BitBucket.REST.API.Helpers;
using BitBucket.REST.API.Models;
using BitBucket.REST.API.Wrappers;
using RestSharp;

namespace BitBucket.REST.API.Clients
{
    public class UserClient : ApiClient
    {

        public UserClient(BitbucketRestClient restClient, Connection connection) : base(restClient, connection)
        {

        }

        public async Task<User> GetUser()
        {
            var url = ApiUrls.User();
            var request = new BitbucketRestRequest(url, Method.GET);
            var response = await RestClient.ExecuteTaskAsync<User>(request);
            return response.Data;
        }

    }
}