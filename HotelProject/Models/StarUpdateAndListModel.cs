﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelProject.Models
{
    public class StarUpdateAndListModel
    {
        public string ID { get; set; }
        [Display(Name = "Beğeni Sayısı ")]

        public int LikeCount { get; set; }
        [Display(Name = "Beğenmeme Sayısı ")]
        public int UnlikeCount { get; set; }
    }
}