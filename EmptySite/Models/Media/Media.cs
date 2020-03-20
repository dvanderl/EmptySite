using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace EmptySite.Models.Media
{
    [ContentType(DisplayName = "Media", GUID = "886e004b-7736-445a-a869-dba28fa54c25", Description = "")]
    [MediaDescriptor(ExtensionString = "pdf,doc,docx,jpg,gif,png")]
    public class Media : MediaData
    {

        [CultureSpecific]
        [Editable(true)]
        [Display(
            Name = "Description",
            Description = "Description field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Description { get; set; }

    }
}