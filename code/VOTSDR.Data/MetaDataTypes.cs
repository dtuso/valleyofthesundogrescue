﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VOTSDR.Data
{

    #region SpecialNeedsStory

    [MetadataType(typeof(SpecialNeedsStory_Validation))]
    public partial class SpecialNeedsStory {}
    public class SpecialNeedsStory_Validation
    {
        [Required(ErrorMessage = "Story should be filled out.")]
        [Display(Name = "Story")]
        public bool Text { get; set; }

        [Required(ErrorMessage = "Date for sorting is required.")]
        [Display(Name = "Sorting Date")]
        public Nullable<DateTime> DateCreated { get; set; }
    }
    #endregion


    #region NewsStory
    [MetadataType(typeof(NewsStory_Validation))]
    public partial class NewsStory {}
    public class NewsStory_Validation
    {
        [StringLength(300, MinimumLength = 1)]
        [Required(ErrorMessage = "Friendly Date is required.")]
        [Display(Name = "Friendly Date")]
        public string Date { get; set; }

        [StringLength(100, MinimumLength = 1)]
        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Story is required.")]
        [Display(Name = "Story")]
        public string Text { get; set; }

        [Required(ErrorMessage = "Date for sorting is required.")]
        [Display(Name = "Sorting Date")]
        public Nullable<DateTime> DateCreated { get; set; }
    }
    #endregion


    #region Event
    [MetadataType(typeof(Event_Validation))]
    public partial class Event {}
    public class Event_Validation
    {
        [StringLength(100, MinimumLength = 1)]
        [Required(ErrorMessage = "Title is required.")]
        [Display(Name="Title")]
        public string Name { get; set; }

        [StringLength(4000, MinimumLength = 1)]
        [Required(ErrorMessage = "Location is required.")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }

        [StringLength(300, MinimumLength = 1)][Required()]
        public string Date { get; set; }

        [Required(ErrorMessage = "Date for sorting is required.")]
        [Display(Name = "Sorting Date")]
        public Nullable<DateTime> DateCreated { get; set; }
    }
    #endregion


    #region Dog
    [MetadataType(typeof(Dog_Validation))]
    public partial class Dog { }
    public class Dog_Validation
    {
        [StringLength(100)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Photo")]
        public Byte[] Image { get; set; }

        [Display(Name = "Gender (M/F)")]
        [StringLength(1, MinimumLength=1)]
        [Required(ErrorMessage = "Gender is required.")]
        public string Gender { get; set; }
        
        [Display(Name = "Adopted Date")]
        public string AdoptedDate { get; set; }

        [Display(Name = "Date Featured")]
        public string DateFeatured { get; set; }

        [Display(Name = "Adoption Story")]
        public string AdoptionStory { get; set; }

        [StringLength(250)]
        [Display(Name = "Breed")]
        [Required(ErrorMessage = "Breed is required.")]
        public string Breed { get; set; }
        
        [Required(ErrorMessage = "Profile is required.")]
        public string Profile { get; set; }

        [Required(ErrorMessage = "Birthday is required. Try to estimate")]
        public string Birthday { get; set; }
        
    }
    #endregion



    #region Content
    [MetadataType(typeof(Content_Validation))]
    public partial class Content { }
    public class Content_Validation
    {
        [StringLength(50, MinimumLength = 1)]
        [Required(ErrorMessage = "Area is required.")]
        public string Area { get; set; }

        [Required(ErrorMessage = "Markup is required.")]
        public string Markup { get; set; }

        [Display(Name = "Is Default")]
        public string IsDefault { get; set; }

        [Display(Name = "Publish On")]
        public string PublishOn { get; set; }

        [Display(Name = "Publish Until")]
        public string PublishUntil { get; set; }

    }
    #endregion


}