using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace newsApp.News
{
    public class NewsAppService_Test// : NewsAppApplicacionTestBase
    {
        private readonly INewsAppService _newsAppService;
        public NewsAppService_Test()
        {
           // _newsAppService = GetRequiredService<INewsAppService>();
        }
        [Fact]
        public async Task Should_Search_News()
        {
            var query = "Apple";

            var news = await _newsAppService.Search(query);
            news.ShouldNotBeNull();
            news.Count.ShouldBeGreaterThan(1);
        }
    }
}
