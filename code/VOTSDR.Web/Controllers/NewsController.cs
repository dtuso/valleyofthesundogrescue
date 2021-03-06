﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VOTSDR.Data;
using VOTSDR.Web.Models;
using System.Web.Hosting;

namespace VOTSDR.Web.Controllers
{
    public class NewsController : BaseController
    {
        public ActionResult Index()
        {
            var entities = new DataEntities();
            var news =
                from article in entities
                    .NewsStories
                    .OrderByDescending(s => s.DateCreated)
                    .Take(10)
                    .ToList()
                select new NewsOrEventViewModel
                {
                    Id = article.NewsStoryId,
                    Date = article.Date,
                    Title = article.Title,
                    Summary = article.Text,
                    IsEvent = false,
                    SortDate = article.DateCreated
                };

            var events =
                from evt in entities
                    .Events
                    .OrderByDescending(e => e.DateCreated)
                    .Take(10)
                    .ToList()
                select new NewsOrEventViewModel
                {
                    Id = evt.EventId,
                    Date = evt.Date,
                    Location = evt.Location,
                    Title = evt.Name,
                    Summary = evt.Description,
                    IsEvent = true,
                    IsUpcoming = 
                        evt.DateCreated.HasValue 
                        && evt.DateCreated > DateTime.Now,
                    SortDate = evt.DateCreated
                };

            return View(
                events
                    .Concat(news)
                    .OrderByDescending(i => i.SortDate)
                    .Take(10));
        }

        public ActionResult SpecialNeedsImage(Guid id)
        {
            var story = new DataEntities()
                .SpecialNeedsStories
                .FirstOrDefault(s => s.SpecialNeedsStoryId == id);
            if (story == null || story.Image == null)
            {
                return HttpNotFound();
            }
            else
            {
                return File(story.Image, "image/jpeg");
            }
        }

        public ActionResult FidoFestRegistrationForm()
        {
            return Redirect("./Content/RegistrationformFidoFestWalkforRescue.doc");
            
        }
    }
}