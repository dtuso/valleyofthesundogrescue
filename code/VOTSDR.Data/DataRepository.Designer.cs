﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace VOTSDR.Data
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class DataEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new DataEntities object using the connection string found in the 'DataEntities' section of the application configuration file.
        /// </summary>
        public DataEntities() : base("name=DataEntities", "DataEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DataEntities object.
        /// </summary>
        public DataEntities(string connectionString) : base(connectionString, "DataEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DataEntities object.
        /// </summary>
        public DataEntities(EntityConnection connection) : base(connection, "DataEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Dog> Dogs
        {
            get
            {
                if ((_Dogs == null))
                {
                    _Dogs = base.CreateObjectSet<Dog>("Dogs");
                }
                return _Dogs;
            }
        }
        private ObjectSet<Dog> _Dogs;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Event> Events
        {
            get
            {
                if ((_Events == null))
                {
                    _Events = base.CreateObjectSet<Event>("Events");
                }
                return _Events;
            }
        }
        private ObjectSet<Event> _Events;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<NewsStory> NewsStories
        {
            get
            {
                if ((_NewsStories == null))
                {
                    _NewsStories = base.CreateObjectSet<NewsStory>("NewsStories");
                }
                return _NewsStories;
            }
        }
        private ObjectSet<NewsStory> _NewsStories;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<SpecialNeedsStory> SpecialNeedsStories
        {
            get
            {
                if ((_SpecialNeedsStories == null))
                {
                    _SpecialNeedsStories = base.CreateObjectSet<SpecialNeedsStory>("SpecialNeedsStories");
                }
                return _SpecialNeedsStories;
            }
        }
        private ObjectSet<SpecialNeedsStory> _SpecialNeedsStories;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Dogs EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToDogs(Dog dog)
        {
            base.AddObject("Dogs", dog);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Events EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToEvents(Event @event)
        {
            base.AddObject("Events", @event);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the NewsStories EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToNewsStories(NewsStory newsStory)
        {
            base.AddObject("NewsStories", newsStory);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the SpecialNeedsStories EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToSpecialNeedsStories(SpecialNeedsStory specialNeedsStory)
        {
            base.AddObject("SpecialNeedsStories", specialNeedsStory);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="votsdradminModel", Name="Dog")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Dog : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Dog object.
        /// </summary>
        /// <param name="dogId">Initial value of the DogId property.</param>
        public static Dog CreateDog(global::System.Guid dogId)
        {
            Dog dog = new Dog();
            dog.DogId = dogId;
            return dog;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid DogId
        {
            get
            {
                return _DogId;
            }
            set
            {
                if (_DogId != value)
                {
                    OnDogIdChanging(value);
                    ReportPropertyChanging("DogId");
                    _DogId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("DogId");
                    OnDogIdChanged();
                }
            }
        }
        private global::System.Guid _DogId;
        partial void OnDogIdChanging(global::System.Guid value);
        partial void OnDogIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Profile
        {
            get
            {
                return _Profile;
            }
            set
            {
                OnProfileChanging(value);
                ReportPropertyChanging("Profile");
                _Profile = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Profile");
                OnProfileChanged();
            }
        }
        private global::System.String _Profile;
        partial void OnProfileChanging(global::System.String value);
        partial void OnProfileChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Story
        {
            get
            {
                return _Story;
            }
            set
            {
                OnStoryChanging(value);
                ReportPropertyChanging("Story");
                _Story = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Story");
                OnStoryChanged();
            }
        }
        private global::System.String _Story;
        partial void OnStoryChanging(global::System.String value);
        partial void OnStoryChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Age
        {
            get
            {
                return _Age;
            }
            set
            {
                OnAgeChanging(value);
                ReportPropertyChanging("Age");
                _Age = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Age");
                OnAgeChanged();
            }
        }
        private global::System.String _Age;
        partial void OnAgeChanging(global::System.String value);
        partial void OnAgeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> Birthday
        {
            get
            {
                return _Birthday;
            }
            set
            {
                OnBirthdayChanging(value);
                ReportPropertyChanging("Birthday");
                _Birthday = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Birthday");
                OnBirthdayChanged();
            }
        }
        private Nullable<global::System.DateTime> _Birthday;
        partial void OnBirthdayChanging(Nullable<global::System.DateTime> value);
        partial void OnBirthdayChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> AdoptedDate
        {
            get
            {
                return _AdoptedDate;
            }
            set
            {
                OnAdoptedDateChanging(value);
                ReportPropertyChanging("AdoptedDate");
                _AdoptedDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("AdoptedDate");
                OnAdoptedDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _AdoptedDate;
        partial void OnAdoptedDateChanging(Nullable<global::System.DateTime> value);
        partial void OnAdoptedDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.Byte[] Image
        {
            get
            {
                return StructuralObject.GetValidValue(_Image);
            }
            set
            {
                OnImageChanging(value);
                ReportPropertyChanging("Image");
                _Image = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Image");
                OnImageChanged();
            }
        }
        private global::System.Byte[] _Image;
        partial void OnImageChanging(global::System.Byte[] value);
        partial void OnImageChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ThumbnailUrl
        {
            get
            {
                return _ThumbnailUrl;
            }
            set
            {
                OnThumbnailUrlChanging(value);
                ReportPropertyChanging("ThumbnailUrl");
                _ThumbnailUrl = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ThumbnailUrl");
                OnThumbnailUrlChanged();
            }
        }
        private global::System.String _ThumbnailUrl;
        partial void OnThumbnailUrlChanging(global::System.String value);
        partial void OnThumbnailUrlChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String AdoptionStory
        {
            get
            {
                return _AdoptionStory;
            }
            set
            {
                OnAdoptionStoryChanging(value);
                ReportPropertyChanging("AdoptionStory");
                _AdoptionStory = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("AdoptionStory");
                OnAdoptionStoryChanged();
            }
        }
        private global::System.String _AdoptionStory;
        partial void OnAdoptionStoryChanging(global::System.String value);
        partial void OnAdoptionStoryChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> DateFeatured
        {
            get
            {
                return _DateFeatured;
            }
            set
            {
                OnDateFeaturedChanging(value);
                ReportPropertyChanging("DateFeatured");
                _DateFeatured = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DateFeatured");
                OnDateFeaturedChanged();
            }
        }
        private Nullable<global::System.DateTime> _DateFeatured;
        partial void OnDateFeaturedChanging(Nullable<global::System.DateTime> value);
        partial void OnDateFeaturedChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="votsdradminModel", Name="Event")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Event : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Event object.
        /// </summary>
        /// <param name="eventId">Initial value of the EventId property.</param>
        /// <param name="date">Initial value of the Date property.</param>
        public static Event CreateEvent(global::System.Guid eventId, global::System.DateTime date)
        {
            Event @event = new Event();
            @event.EventId = eventId;
            @event.Date = date;
            return @event;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid EventId
        {
            get
            {
                return _EventId;
            }
            set
            {
                if (_EventId != value)
                {
                    OnEventIdChanging(value);
                    ReportPropertyChanging("EventId");
                    _EventId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("EventId");
                    OnEventIdChanged();
                }
            }
        }
        private global::System.Guid _EventId;
        partial void OnEventIdChanging(global::System.Guid value);
        partial void OnEventIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Location
        {
            get
            {
                return _Location;
            }
            set
            {
                OnLocationChanging(value);
                ReportPropertyChanging("Location");
                _Location = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Location");
                OnLocationChanged();
            }
        }
        private global::System.String _Location;
        partial void OnLocationChanging(global::System.String value);
        partial void OnLocationChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime Date
        {
            get
            {
                return _Date;
            }
            set
            {
                OnDateChanging(value);
                ReportPropertyChanging("Date");
                _Date = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Date");
                OnDateChanged();
            }
        }
        private global::System.DateTime _Date;
        partial void OnDateChanging(global::System.DateTime value);
        partial void OnDateChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="votsdradminModel", Name="NewsStory")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class NewsStory : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new NewsStory object.
        /// </summary>
        /// <param name="newsStoryId">Initial value of the NewsStoryId property.</param>
        /// <param name="date">Initial value of the Date property.</param>
        public static NewsStory CreateNewsStory(global::System.Guid newsStoryId, global::System.DateTime date)
        {
            NewsStory newsStory = new NewsStory();
            newsStory.NewsStoryId = newsStoryId;
            newsStory.Date = date;
            return newsStory;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid NewsStoryId
        {
            get
            {
                return _NewsStoryId;
            }
            set
            {
                if (_NewsStoryId != value)
                {
                    OnNewsStoryIdChanging(value);
                    ReportPropertyChanging("NewsStoryId");
                    _NewsStoryId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("NewsStoryId");
                    OnNewsStoryIdChanged();
                }
            }
        }
        private global::System.Guid _NewsStoryId;
        partial void OnNewsStoryIdChanging(global::System.Guid value);
        partial void OnNewsStoryIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime Date
        {
            get
            {
                return _Date;
            }
            set
            {
                OnDateChanging(value);
                ReportPropertyChanging("Date");
                _Date = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Date");
                OnDateChanged();
            }
        }
        private global::System.DateTime _Date;
        partial void OnDateChanging(global::System.DateTime value);
        partial void OnDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Text
        {
            get
            {
                return _Text;
            }
            set
            {
                OnTextChanging(value);
                ReportPropertyChanging("Text");
                _Text = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Text");
                OnTextChanged();
            }
        }
        private global::System.String _Text;
        partial void OnTextChanging(global::System.String value);
        partial void OnTextChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="votsdradminModel", Name="SpecialNeedsStory")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class SpecialNeedsStory : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new SpecialNeedsStory object.
        /// </summary>
        /// <param name="specialNeedsStoryId">Initial value of the SpecialNeedsStoryId property.</param>
        /// <param name="isFeatured">Initial value of the IsFeatured property.</param>
        public static SpecialNeedsStory CreateSpecialNeedsStory(global::System.Guid specialNeedsStoryId, global::System.Boolean isFeatured)
        {
            SpecialNeedsStory specialNeedsStory = new SpecialNeedsStory();
            specialNeedsStory.SpecialNeedsStoryId = specialNeedsStoryId;
            specialNeedsStory.IsFeatured = isFeatured;
            return specialNeedsStory;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid SpecialNeedsStoryId
        {
            get
            {
                return _SpecialNeedsStoryId;
            }
            set
            {
                if (_SpecialNeedsStoryId != value)
                {
                    OnSpecialNeedsStoryIdChanging(value);
                    ReportPropertyChanging("SpecialNeedsStoryId");
                    _SpecialNeedsStoryId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("SpecialNeedsStoryId");
                    OnSpecialNeedsStoryIdChanged();
                }
            }
        }
        private global::System.Guid _SpecialNeedsStoryId;
        partial void OnSpecialNeedsStoryIdChanging(global::System.Guid value);
        partial void OnSpecialNeedsStoryIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.Byte[] Image
        {
            get
            {
                return StructuralObject.GetValidValue(_Image);
            }
            set
            {
                OnImageChanging(value);
                ReportPropertyChanging("Image");
                _Image = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Image");
                OnImageChanged();
            }
        }
        private global::System.Byte[] _Image;
        partial void OnImageChanging(global::System.Byte[] value);
        partial void OnImageChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> DateCreated
        {
            get
            {
                return _DateCreated;
            }
            set
            {
                OnDateCreatedChanging(value);
                ReportPropertyChanging("DateCreated");
                _DateCreated = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DateCreated");
                OnDateCreatedChanged();
            }
        }
        private Nullable<global::System.DateTime> _DateCreated;
        partial void OnDateCreatedChanging(Nullable<global::System.DateTime> value);
        partial void OnDateCreatedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean IsFeatured
        {
            get
            {
                return _IsFeatured;
            }
            set
            {
                OnIsFeaturedChanging(value);
                ReportPropertyChanging("IsFeatured");
                _IsFeatured = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IsFeatured");
                OnIsFeaturedChanged();
            }
        }
        private global::System.Boolean _IsFeatured;
        partial void OnIsFeaturedChanging(global::System.Boolean value);
        partial void OnIsFeaturedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Text
        {
            get
            {
                return _Text;
            }
            set
            {
                OnTextChanging(value);
                ReportPropertyChanging("Text");
                _Text = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Text");
                OnTextChanged();
            }
        }
        private global::System.String _Text;
        partial void OnTextChanging(global::System.String value);
        partial void OnTextChanged();

        #endregion
    
    }

    #endregion
    
}
