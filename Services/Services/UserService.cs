using Domains;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Services
{
    public class UserService : Users.UsersBase
    {
        private readonly ILogger<UserService> _logger;

        public UserService(ILogger<UserService> logger)
        {
            _logger = logger;
        }

        public override Task<User> Del(FetchUserBySku request, ServerCallContext context)
        {
            return base.Del(request, context);
        }

        public override Task<User> Get(FetchUserBySku request, ServerCallContext context)
        {
            return base.Get(request, context);
        }

        public override Task<User> GetByNameAndPass(FetchUserByNameAndPass request, ServerCallContext context)
        {
            return base.GetByNameAndPass(request, context);
        }

        public override Task<User> GetByTag(FetchUserByTag request, ServerCallContext context)
        {
            return base.GetByTag(request, context);
        }

        public override Task<User> Put(User request, ServerCallContext context)
        {
            return base.Put(request, context);
        }

        public override Task<User> Set(User request, ServerCallContext context)
        {
            return base.Set(request, context);
        }
    }
}
