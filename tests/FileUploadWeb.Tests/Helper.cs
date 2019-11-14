using System;
using SampleApp.Utilities;
using Xunit;

namespace FileUploadWeb.Tests
{
    public class Helper
    {
        [Fact]
        public void SetLocalPathToTempFolder()
        {
            var result = FileHelpers.SetLocalPath("SomeFileName.zip");
            Assert.NotNull(result);

        }
    }
}
