﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;


namespace newsApp.News
{
    public class NewsAppService : newsAppAppService, INewsAppService
    {
        private readonly INewsService _newsService;

        public NewsAppService(INewsService newsService)
        {
            _newsService = newsService;
        }
        public async Task<ICollection<NewsDto>> Search(string query)
        {
            //registrar los tiempos de acceso a la api
            var news = await _newsService.GetNewsAsync(query);

            return ObjectMapper.Map<ICollection<ArticleDto>, ICollection<NewsDto>>(news);
        }
    }
}
