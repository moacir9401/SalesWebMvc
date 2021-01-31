using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class DbConcurrencyExceptions:ApplicationException
    {
        public DbConcurrencyExceptions(string menssage):base(menssage)
        {
        }
}
}
