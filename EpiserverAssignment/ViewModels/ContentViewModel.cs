using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EpiserverAssignment.Models;

namespace EpiserverAssignment.ViewModels
{
    public class ContentViewModel
    {
        public List<ContentModel> ContentList { get; set; }
        public string Heading { get; set; }
    }
}