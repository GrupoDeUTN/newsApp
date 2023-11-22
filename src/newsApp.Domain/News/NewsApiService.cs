using NewsAPI;
using NewsAPI.Constants;
using NewsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OpenIddict.Abstractions.OpenIddictConstants;
using Statuses = NewsAPI.Constants.Statuses; 

namespace newsApp.News
{
    public class NewsApiService : INewsService
    {
        public async Task<ICollection<ArticleDto>> GetNewsAsync(string query)
        {
            ICollection<ArticleDto> responseList = new List<ArticleDto>();
            var newsApiClient = new NewsApiClient("70b5099630c94de7b2085f63398b0a6c");
            var articlesResponse = await newsApiClient.GetEverythingAsync(new EverythingRequest
            {
                Q = query,
                SortBy = SortBys.Popularity,
                Language = Languages.EN,
                From = DateTime.Now.AddMonths(-1)
            });

            //se deberia lanzar una excepcion si la consulta de la api da error
            if (articlesResponse.Status == Statuses.Ok)
            {
                articlesResponse.Articles.ForEach(t => responseList.Add(new ArticleDto
                {
                    Autor = t.Author,
                    Titulo = t.Title,
                    Descripcion = t.Description,
                    URL = t.Url,
                    PublishedAt = t.PublishedAt
                }));
            }
            //falta registrar los tiempos de acceso a al api
            return responseList;
        }
    }
}
