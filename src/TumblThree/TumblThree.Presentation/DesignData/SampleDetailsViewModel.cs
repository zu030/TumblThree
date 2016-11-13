﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TumblThree.Applications.ViewModels;
using TumblThree.Applications.Views;
using TumblThree.Domain.Models;

namespace TumblThree.Presentation.DesignData
{
    public class SampleDetailsViewModel : DetailsViewModel
    {
        public SampleDetailsViewModel() : base(new MockDetailsView(), null)
        {

            var BlogFile = new[]
            {
                new TumblrBlog
                {
                    Name = "Nature Wallpapers",
                    Url = "http://nature-wallpaper.tumblr.com/",
                    DownloadedImages = 123,
                    DateAdded = DateTime.Now,
                    Progress = 66,
                    TotalCount = 234,
                },
                new TumblrBlog
                {
                    Name = "Landscape Wallpapers",
                    Url = "http://landscape-wallpaper.tumblr.com/",
                    DownloadedImages = 17236,
                    DateAdded = DateTime.Now,
                    Progress = 95,
                    TotalCount = 15739,
                },
                new TumblrBlog
                {
                    Name = "FX Wallpapers",
                    Url = "http://nature-wallpaper.tumblr.com/",
                    DownloadedImages = 12845,
                    DateAdded = DateTime.Now,
                    Progress = 12,
                    TotalCount = 82453,
                }
            };
        }

        private class MockDetailsView : MockView, IDetailsView
        {
        }
    }
}