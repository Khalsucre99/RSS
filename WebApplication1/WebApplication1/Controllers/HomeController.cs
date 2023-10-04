using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SQLitePCL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context, ILogger<HomeController> logger)
        {
            _logger = logger;
            _context = context;

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult Index()
        {
           
            List<String> rssUrls = _context.Feeds.Select(feed => feed.Url).ToList();


            List<Article> articles = new List<Article>();

            // Vérifier si la liste des URLs est vide
            if (!rssUrls.Any())
            {
                ViewBag.FeedMessage = "Aucun flux RSS disponible actuellement.";
                return View(articles); // articles sera une liste vide dans ce cas
            }

            foreach (var rssUrl in rssUrls)
            {
                PopulateArticlesFromRssUrl(rssUrl, articles);

            }
            
                return View( articles);
        }

        public IActionResult ArticlesFromFeed( DateTime? startDate, DateTime? endDate, int? feedId = 1)
        {
            ViewBag.start = startDate;
            ViewBag.end = endDate;
            ViewBag._feedId = feedId;
            List<Article> articles = new List<Article>();
           
               
                var feed = _context.Feeds.FirstOrDefault(f => f.FeedId == feedId);
                
                if (feed == null)
                {
                    return NotFound("Feed not found.");
                }

                var rssUrl = feed.Url;
                PopulateArticlesFromRssUrl(rssUrl, articles);
                ViewBag.FeedId = feedId;
                if (startDate.HasValue && endDate.HasValue)
                {
                    endDate = endDate.Value.AddDays(1).AddTicks(-1);


                    articles = articles.Where(a => DateTime.Compare(a.PublicationDate, (DateTime)startDate) >= 0 && DateTime.Compare(a.PublicationDate, (DateTime)endDate) <= 0).ToList();
                }
                else if (startDate.HasValue)
                {
                    articles = articles.Where(a => DateTime.Compare(a.PublicationDate, (DateTime)startDate) >= 0).ToList();
                }
                else if (endDate.HasValue)
                {
                    endDate = endDate.Value.AddDays(1).AddTicks(-1);
                    articles = articles.Where(a => DateTime.Compare(a.PublicationDate, (DateTime)endDate) <= 0).ToList();
                }
                Console.WriteLine("this is the articles : ", articles);
 
            
            return View(articles);
        }
      
        private void PopulateArticlesFromRssUrl(string rssUrl, List<Article> articles)
        {
            try
            {
                using (XmlReader reader = XmlReader.Create(rssUrl))
                {
                    SyndicationFeed feed = SyndicationFeed.Load(reader);

                    foreach (var item in feed.Items)
                    {
                        Article article = new Article
                        {
                            Title = item.Title.Text,
                            Link = item.Links.FirstOrDefault()?.Uri.ToString(),
                            Guid = item.Id,
                            PublicationDate = item.PublishDate.DateTime,
                            Description = item.Summary?.Text,
                            Categories = item.Categories.Select(c => c.Name).ToList(),
                            // La propriété MediaContent nécessite une logique supplémentaire basée sur le flux RSS.
                            // Keywords pourrait nécessiter une logique supplémentaire.
                            Creator = item.Authors.FirstOrDefault()?.Name,
                            Publisher = feed.Title.Text, // Habituellement, le publisher est lié au feed, pas à l'item.
                        };
                        // Extract media:thumbnail
                        var thumbnailExtension = item.ElementExtensions.FirstOrDefault(ext => ext.OuterName == "thumbnail" && ext.OuterNamespace == "http://search.yahoo.com/mrss/");
                        if (thumbnailExtension != null)
                        {
                            XElement thumbnailElement = thumbnailExtension.GetObject<XElement>();
                            string thumbnailUrl = thumbnailElement.Attribute("url")?.Value;
                            article.ThumbnailUrl = thumbnailUrl;
                        }

                        // Extract media:keywords
                        var keywordsExtension = item.ElementExtensions.FirstOrDefault(ext => ext.OuterName == "keywords" && ext.OuterNamespace == "http://search.yahoo.com/mrss/");
                        if (keywordsExtension != null)
                        {
                            XElement keywordsElement = keywordsExtension.GetObject<XElement>();
                            string keywords = keywordsElement.Value;
                            article.Keywords = keywords;

                        }

                        // Extract dc:creator
                        var creatorExtension = item.ElementExtensions.FirstOrDefault(ext => ext.OuterName == "creator" && ext.OuterNamespace == "http://purl.org/dc/elements/1.1/");
                        if (creatorExtension != null)
                        {
                            XElement creatorElement = creatorExtension.GetObject<XElement>();
                            string creator = creatorElement.Value;
                            article.Creator = creator;
                        }
                        articles.Add(article);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error reading the RSS feed from {rssUrl}. Error: {ex.Message}");
            }
        }


    }
}