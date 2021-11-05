using System;
using Microsoft.AspNetCore.Http;

namespace Investments.Models
{
    public class DateIdea
    {
        public int ID { get; set; }
        public string NameOfEvent { get; set; }
        public string Address { get; set; }
        public DateTime DateOfEvent { get; set; }

        /*
         * Information for Link
         */
        public string Href { get; set; }
        public string LinkText { get; set; }

        /*
         *  IFormFile used when uploading an
         *  image to the menu item
         */
        public IFormFile ImageFile { get; set; }
        public string ImagePath { get; set; }

        public DateIdea()
        {
            
        }

        public DateIdea(int id, string nameOfEvent, string address, string href, string linkText, string imagePath)
        {
            ID = id;
            NameOfEvent = nameOfEvent;
            Address = address;
            Href = href;
            LinkText = linkText;
            ImagePath = imagePath;
        }

    }
}
