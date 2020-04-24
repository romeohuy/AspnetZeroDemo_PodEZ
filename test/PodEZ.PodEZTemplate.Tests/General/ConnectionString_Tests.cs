using System.Data.SqlClient;
using Shouldly;
using Xunit;

namespace PodEZ.PodEZTemplate.Tests.General
{
    // ReSharper disable once InconsistentNaming
    public class ConnectionString_Tests
    {
        [Fact]
        public void SqlConnectionStringBuilder_Test()
        {
            var csb = new SqlConnectionStringBuilder("Server=localhost; Database=PodEZTemplate; Trusted_Connection=True;");
            csb["Database"].ShouldBe("PodEZTemplate");
        }
    }
}
