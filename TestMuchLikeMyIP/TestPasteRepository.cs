using MuchLikeMyIP.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestMuchLikeMyIP
{
    public class TestPasteRepository
    {
        [Fact]
        public void TestListPastes()
        {
            var pasteRepository = new PasteRepository().List;
        }
    }
}
