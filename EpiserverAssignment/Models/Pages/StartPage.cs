using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EpiserverAssignment.Models.Pages
{
    [ContentType(DisplayName = "StartPage", GUID = "27d5ef16-db2f-45a2-af44-77ec61f9683e", Description = "")]
    public class StartPage : PageData
    {
        [CultureSpecific]
        [Display(
            Name = "Heading",
            Description = "The Page Heading",
            GroupName = SystemTabNames.Content,
            Order = 0)]
        public virtual XhtmlString Heading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }
    }
}