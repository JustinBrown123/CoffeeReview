using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeReview.Models
{
    public class ReviewModels
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string ImageUrl { get; set; }

        public string ReviewCategory { get; set; }

        public string Content { get; set; }

        public ReviewModels()
        {

        }

        public ReviewModels(int Id, string Title, string ImageUrl, string ReviewCategory, string Content, string ReviewModels)
        {
            Id = id;

            Title = title;

            ImageUrl = imageUrl;

            ReviewCategory = reviewCategory;

            Content = content;

            ReviewModels = reviewModels;

        }
    }
}