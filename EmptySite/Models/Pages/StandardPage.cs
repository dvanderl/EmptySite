using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EmptySite.Models.Pages
{
    [ContentType(DisplayName = "StandardPage", GUID = "6a21a40c-99cf-48ff-96e8-1310ddde4fe9", Description = "")]
    public class StandardPage : PageData
    {
        [CultureSpecific]
        [Display(
            Name = "Heading",
            Description = "The Page Heading",
            GroupName = SystemTabNames.Content,
            Order = 0)]
        public virtual String Heading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Paragraph",
            Description = "This is a paragraph section.",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual XhtmlString Paragraph { get; set; }

    }
}