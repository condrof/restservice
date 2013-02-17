﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace LottoService
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class bookDBEntities1 : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new bookDBEntities1 object using the connection string found in the 'bookDBEntities1' section of the application configuration file.
        /// </summary>
        public bookDBEntities1() : base("name=bookDBEntities1", "bookDBEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new bookDBEntities1 object.
        /// </summary>
        public bookDBEntities1(string connectionString) : base(connectionString, "bookDBEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new bookDBEntities1 object.
        /// </summary>
        public bookDBEntities1(EntityConnection connection) : base(connection, "bookDBEntities1")
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
        public ObjectSet<Book> Books
        {
            get
            {
                if ((_Books == null))
                {
                    _Books = base.CreateObjectSet<Book>("Books");
                }
                return _Books;
            }
        }
        private ObjectSet<Book> _Books;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Books EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToBooks(Book book)
        {
            base.AddObject("Books", book);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="bookDBModel", Name="Book")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Book : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Book object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="price">Initial value of the Price property.</param>
        public static Book CreateBook(global::System.Int32 id, global::System.Decimal price)
        {
            Book book = new Book();
            book.Id = id;
            book.Price = price;
            return book;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Boolean> Paperback
        {
            get
            {
                return _Paperback;
            }
            set
            {
                OnPaperbackChanging(value);
                ReportPropertyChanging("Paperback");
                _Paperback = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Paperback");
                OnPaperbackChanged();
            }
        }
        private Nullable<global::System.Boolean> _Paperback;
        partial void OnPaperbackChanging(Nullable<global::System.Boolean> value);
        partial void OnPaperbackChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Pages
        {
            get
            {
                return _Pages;
            }
            set
            {
                OnPagesChanging(value);
                ReportPropertyChanging("Pages");
                _Pages = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Pages");
                OnPagesChanged();
            }
        }
        private Nullable<global::System.Int32> _Pages;
        partial void OnPagesChanging(Nullable<global::System.Int32> value);
        partial void OnPagesChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal Price
        {
            get
            {
                return _Price;
            }
            set
            {
                OnPriceChanging(value);
                ReportPropertyChanging("Price");
                _Price = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Price");
                OnPriceChanged();
            }
        }
        private global::System.Decimal _Price;
        partial void OnPriceChanging(global::System.Decimal value);
        partial void OnPriceChanged();

        #endregion

    
    }

    #endregion

    
}