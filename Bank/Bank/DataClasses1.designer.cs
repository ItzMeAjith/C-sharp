﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bank
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BANKING_SYSTEM")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertACCOUNTANT_DETAIL(ACCOUNTANT_DETAIL instance);
    partial void UpdateACCOUNTANT_DETAIL(ACCOUNTANT_DETAIL instance);
    partial void DeleteACCOUNTANT_DETAIL(ACCOUNTANT_DETAIL instance);
    partial void InsertUSER_REGISTRATION(USER_REGISTRATION instance);
    partial void UpdateUSER_REGISTRATION(USER_REGISTRATION instance);
    partial void DeleteUSER_REGISTRATION(USER_REGISTRATION instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::Bank.Properties.Settings.Default.BANKING_SYSTEMConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ACCOUNTANT_DETAIL> ACCOUNTANT_DETAILs
		{
			get
			{
				return this.GetTable<ACCOUNTANT_DETAIL>();
			}
		}
		
		public System.Data.Linq.Table<TRANSACTION_LOG> TRANSACTION_LOGs
		{
			get
			{
				return this.GetTable<TRANSACTION_LOG>();
			}
		}
		
		public System.Data.Linq.Table<USER_REGISTRATION> USER_REGISTRATIONs
		{
			get
			{
				return this.GetTable<USER_REGISTRATION>();
			}
		}
		
		public System.Data.Linq.Table<USER_TRANSACTION> USER_TRANSACTIONs
		{
			get
			{
				return this.GetTable<USER_TRANSACTION>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ACCOUNTANT_DETAILS")]
	public partial class ACCOUNTANT_DETAIL : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _UserID;
		
		private int _AccountNo;
		
		private string _Name;
		
		private System.Nullable<System.DateTime> _BirthDate;
		
		private System.Nullable<long> _PhoneNo;
		
		private string _MailID;
		
		private string _Address;
		
		private string _Photo;
		
		private EntityRef<USER_REGISTRATION> _USER_REGISTRATION;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIDChanging(string value);
    partial void OnUserIDChanged();
    partial void OnAccountNoChanging(int value);
    partial void OnAccountNoChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnBirthDateChanging(System.Nullable<System.DateTime> value);
    partial void OnBirthDateChanged();
    partial void OnPhoneNoChanging(System.Nullable<long> value);
    partial void OnPhoneNoChanged();
    partial void OnMailIDChanging(string value);
    partial void OnMailIDChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnPhotoChanging(string value);
    partial void OnPhotoChanged();
    #endregion
		
		public ACCOUNTANT_DETAIL()
		{
			this._USER_REGISTRATION = default(EntityRef<USER_REGISTRATION>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="VarChar(10)")]
		public string UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					if (this._USER_REGISTRATION.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountNo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int AccountNo
		{
			get
			{
				return this._AccountNo;
			}
			set
			{
				if ((this._AccountNo != value))
				{
					this.OnAccountNoChanging(value);
					this.SendPropertyChanging();
					this._AccountNo = value;
					this.SendPropertyChanged("AccountNo");
					this.OnAccountNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(30)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BirthDate", DbType="Date")]
		public System.Nullable<System.DateTime> BirthDate
		{
			get
			{
				return this._BirthDate;
			}
			set
			{
				if ((this._BirthDate != value))
				{
					this.OnBirthDateChanging(value);
					this.SendPropertyChanging();
					this._BirthDate = value;
					this.SendPropertyChanged("BirthDate");
					this.OnBirthDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNo", DbType="BigInt")]
		public System.Nullable<long> PhoneNo
		{
			get
			{
				return this._PhoneNo;
			}
			set
			{
				if ((this._PhoneNo != value))
				{
					this.OnPhoneNoChanging(value);
					this.SendPropertyChanging();
					this._PhoneNo = value;
					this.SendPropertyChanged("PhoneNo");
					this.OnPhoneNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MailID", DbType="VarChar(30)")]
		public string MailID
		{
			get
			{
				return this._MailID;
			}
			set
			{
				if ((this._MailID != value))
				{
					this.OnMailIDChanging(value);
					this.SendPropertyChanging();
					this._MailID = value;
					this.SendPropertyChanged("MailID");
					this.OnMailIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(50)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Photo", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string Photo
		{
			get
			{
				return this._Photo;
			}
			set
			{
				if ((this._Photo != value))
				{
					this.OnPhotoChanging(value);
					this.SendPropertyChanging();
					this._Photo = value;
					this.SendPropertyChanged("Photo");
					this.OnPhotoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="USER_REGISTRATION_ACCOUNTANT_DETAIL", Storage="_USER_REGISTRATION", ThisKey="UserID", OtherKey="UserID", IsForeignKey=true)]
		public USER_REGISTRATION USER_REGISTRATION
		{
			get
			{
				return this._USER_REGISTRATION.Entity;
			}
			set
			{
				USER_REGISTRATION previousValue = this._USER_REGISTRATION.Entity;
				if (((previousValue != value) 
							|| (this._USER_REGISTRATION.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._USER_REGISTRATION.Entity = null;
						previousValue.ACCOUNTANT_DETAILs.Remove(this);
					}
					this._USER_REGISTRATION.Entity = value;
					if ((value != null))
					{
						value.ACCOUNTANT_DETAILs.Add(this);
						this._UserID = value.UserID;
					}
					else
					{
						this._UserID = default(string);
					}
					this.SendPropertyChanged("USER_REGISTRATION");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TRANSACTION_LOG")]
	public partial class TRANSACTION_LOG
	{
		
		private int _TranID;
		
		private System.Nullable<int> _AccountNo;
		
		private string _action;
		
		private string _status;
		
		private System.Nullable<System.DateTime> _updatedon;
		
		public TRANSACTION_LOG()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TranID", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int TranID
		{
			get
			{
				return this._TranID;
			}
			set
			{
				if ((this._TranID != value))
				{
					this._TranID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountNo", DbType="Int")]
		public System.Nullable<int> AccountNo
		{
			get
			{
				return this._AccountNo;
			}
			set
			{
				if ((this._AccountNo != value))
				{
					this._AccountNo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_action", DbType="VarChar(20)")]
		public string action
		{
			get
			{
				return this._action;
			}
			set
			{
				if ((this._action != value))
				{
					this._action = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="VarChar(20)")]
		public string status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this._status = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_updatedon", DbType="DateTime")]
		public System.Nullable<System.DateTime> updatedon
		{
			get
			{
				return this._updatedon;
			}
			set
			{
				if ((this._updatedon != value))
				{
					this._updatedon = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.USER_REGISTRATION")]
	public partial class USER_REGISTRATION : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _UserID;
		
		private string _MailID;
		
		private string _Password;
		
		private EntitySet<ACCOUNTANT_DETAIL> _ACCOUNTANT_DETAILs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIDChanging(string value);
    partial void OnUserIDChanged();
    partial void OnMailIDChanging(string value);
    partial void OnMailIDChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
		
		public USER_REGISTRATION()
		{
			this._ACCOUNTANT_DETAILs = new EntitySet<ACCOUNTANT_DETAIL>(new Action<ACCOUNTANT_DETAIL>(this.attach_ACCOUNTANT_DETAILs), new Action<ACCOUNTANT_DETAIL>(this.detach_ACCOUNTANT_DETAILs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MailID", DbType="VarChar(30)")]
		public string MailID
		{
			get
			{
				return this._MailID;
			}
			set
			{
				if ((this._MailID != value))
				{
					this.OnMailIDChanging(value);
					this.SendPropertyChanging();
					this._MailID = value;
					this.SendPropertyChanged("MailID");
					this.OnMailIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="USER_REGISTRATION_ACCOUNTANT_DETAIL", Storage="_ACCOUNTANT_DETAILs", ThisKey="UserID", OtherKey="UserID")]
		public EntitySet<ACCOUNTANT_DETAIL> ACCOUNTANT_DETAILs
		{
			get
			{
				return this._ACCOUNTANT_DETAILs;
			}
			set
			{
				this._ACCOUNTANT_DETAILs.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_ACCOUNTANT_DETAILs(ACCOUNTANT_DETAIL entity)
		{
			this.SendPropertyChanging();
			entity.USER_REGISTRATION = this;
		}
		
		private void detach_ACCOUNTANT_DETAILs(ACCOUNTANT_DETAIL entity)
		{
			this.SendPropertyChanging();
			entity.USER_REGISTRATION = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.USER_TRANSACTION")]
	public partial class USER_TRANSACTION
	{
		
		private System.Nullable<int> _AccountNo;
		
		private System.Nullable<decimal> _Balance;
		
		public USER_TRANSACTION()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountNo", DbType="Int")]
		public System.Nullable<int> AccountNo
		{
			get
			{
				return this._AccountNo;
			}
			set
			{
				if ((this._AccountNo != value))
				{
					this._AccountNo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Balance", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> Balance
		{
			get
			{
				return this._Balance;
			}
			set
			{
				if ((this._Balance != value))
				{
					this._Balance = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
