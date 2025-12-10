using Bits.Data;
using Bits.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Bits.Tests
{
    public static class TestHelper
    {
        public static BitsContext GetContext()
        {
            var conn = "Server=localhost;Uid=root;Pwd=0909;Database=bits;Port=3306;SslMode=None;AllowPublicKeyRetrieval=True";

            var options = new DbContextOptionsBuilder<BitsContext>()
                .UseMySql(conn, ServerVersion.AutoDetect(conn))
                .Options;

            return new BitsContext(options);
        }
    }
}
