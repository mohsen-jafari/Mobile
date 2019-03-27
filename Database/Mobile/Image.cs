﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Mobile
{
    public class Image
    {
        public int Id { get; set; }
        public string ImageAddress { get; set; }

        public Image(string imageAddress)
        {
            ImageAddress = imageAddress;
        }
        public Image(int id)
        {
            Id = id;
        }
        public Image()
        {

        }
    }
}
