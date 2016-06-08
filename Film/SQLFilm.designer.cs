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

namespace Film
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SQLFILM")]
	public partial class SQLFilmDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertThongTinCaNhan(ThongTinCaNhan instance);
    partial void UpdateThongTinCaNhan(ThongTinCaNhan instance);
    partial void DeleteThongTinCaNhan(ThongTinCaNhan instance);
    partial void InsertQuanLyNhanSu(QuanLyNhanSu instance);
    partial void UpdateQuanLyNhanSu(QuanLyNhanSu instance);
    partial void DeleteQuanLyNhanSu(QuanLyNhanSu instance);
    #endregion
		
		public SQLFilmDataContext() : 
				base(global::Film.Properties.Settings.Default.SQLFILMConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SQLFilmDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SQLFilmDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SQLFilmDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SQLFilmDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ThongTinCaNhan> ThongTinCaNhans
		{
			get
			{
				return this.GetTable<ThongTinCaNhan>();
			}
		}
		
		public System.Data.Linq.Table<QuanLyNhanSu> QuanLyNhanSus
		{
			get
			{
				return this.GetTable<QuanLyNhanSu>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ThongTinCaNhan")]
	public partial class ThongTinCaNhan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _TenDangNhap;
		
		private string _HoTen;
		
		private System.Nullable<System.DateTime> _NgaySinh;
		
		private string _DiaChi;
		
		private System.Nullable<int> _CMND;
		
		private System.Nullable<int> _SDT;
		
		private string _Email;
		
		private System.Data.Linq.Binary _ImageByte;
		
		private EntityRef<QuanLyNhanSu> _QuanLyNhanSu;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTenDangNhapChanging(string value);
    partial void OnTenDangNhapChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnNgaySinhChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaySinhChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnCMNDChanging(System.Nullable<int> value);
    partial void OnCMNDChanged();
    partial void OnSDTChanging(System.Nullable<int> value);
    partial void OnSDTChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnImageByteChanging(System.Data.Linq.Binary value);
    partial void OnImageByteChanged();
    #endregion
		
		public ThongTinCaNhan()
		{
			this._QuanLyNhanSu = default(EntityRef<QuanLyNhanSu>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDangNhap", DbType="NVarChar(30) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TenDangNhap
		{
			get
			{
				return this._TenDangNhap;
			}
			set
			{
				if ((this._TenDangNhap != value))
				{
					if (this._QuanLyNhanSu.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTenDangNhapChanging(value);
					this.SendPropertyChanging();
					this._TenDangNhap = value;
					this.SendPropertyChanged("TenDangNhap");
					this.OnTenDangNhapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this.OnHoTenChanging(value);
					this.SendPropertyChanging();
					this._HoTen = value;
					this.SendPropertyChanged("HoTen");
					this.OnHoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="Date")]
		public System.Nullable<System.DateTime> NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this.OnNgaySinhChanging(value);
					this.SendPropertyChanging();
					this._NgaySinh = value;
					this.SendPropertyChanged("NgaySinh");
					this.OnNgaySinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(100)")]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CMND", DbType="Int")]
		public System.Nullable<int> CMND
		{
			get
			{
				return this._CMND;
			}
			set
			{
				if ((this._CMND != value))
				{
					this.OnCMNDChanging(value);
					this.SendPropertyChanging();
					this._CMND = value;
					this.SendPropertyChanged("CMND");
					this.OnCMNDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="Int")]
		public System.Nullable<int> SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImageByte", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary ImageByte
		{
			get
			{
				return this._ImageByte;
			}
			set
			{
				if ((this._ImageByte != value))
				{
					this.OnImageByteChanging(value);
					this.SendPropertyChanging();
					this._ImageByte = value;
					this.SendPropertyChanged("ImageByte");
					this.OnImageByteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="QuanLyNhanSu_ThongTinCaNhan", Storage="_QuanLyNhanSu", ThisKey="TenDangNhap", OtherKey="TenDangNhap", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public QuanLyNhanSu QuanLyNhanSu
		{
			get
			{
				return this._QuanLyNhanSu.Entity;
			}
			set
			{
				QuanLyNhanSu previousValue = this._QuanLyNhanSu.Entity;
				if (((previousValue != value) 
							|| (this._QuanLyNhanSu.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._QuanLyNhanSu.Entity = null;
						previousValue.ThongTinCaNhan = null;
					}
					this._QuanLyNhanSu.Entity = value;
					if ((value != null))
					{
						value.ThongTinCaNhan = this;
						this._TenDangNhap = value.TenDangNhap;
					}
					else
					{
						this._TenDangNhap = default(string);
					}
					this.SendPropertyChanged("QuanLyNhanSu");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.QuanLyNhanSu")]
	public partial class QuanLyNhanSu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _TenDangNhap;
		
		private string _MatKhau;
		
		private string _PhanQuyen;
		
		private string _TrangThai;
		
		private EntityRef<ThongTinCaNhan> _ThongTinCaNhan;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTenDangNhapChanging(string value);
    partial void OnTenDangNhapChanged();
    partial void OnMatKhauChanging(string value);
    partial void OnMatKhauChanged();
    partial void OnPhanQuyenChanging(string value);
    partial void OnPhanQuyenChanged();
    partial void OnTrangThaiChanging(string value);
    partial void OnTrangThaiChanged();
    #endregion
		
		public QuanLyNhanSu()
		{
			this._ThongTinCaNhan = default(EntityRef<ThongTinCaNhan>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDangNhap", DbType="NVarChar(30) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TenDangNhap
		{
			get
			{
				return this._TenDangNhap;
			}
			set
			{
				if ((this._TenDangNhap != value))
				{
					this.OnTenDangNhapChanging(value);
					this.SendPropertyChanging();
					this._TenDangNhap = value;
					this.SendPropertyChanged("TenDangNhap");
					this.OnTenDangNhapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhau", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string MatKhau
		{
			get
			{
				return this._MatKhau;
			}
			set
			{
				if ((this._MatKhau != value))
				{
					this.OnMatKhauChanging(value);
					this.SendPropertyChanging();
					this._MatKhau = value;
					this.SendPropertyChanged("MatKhau");
					this.OnMatKhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhanQuyen", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string PhanQuyen
		{
			get
			{
				return this._PhanQuyen;
			}
			set
			{
				if ((this._PhanQuyen != value))
				{
					this.OnPhanQuyenChanging(value);
					this.SendPropertyChanging();
					this._PhanQuyen = value;
					this.SendPropertyChanged("PhanQuyen");
					this.OnPhanQuyenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TrangThai", DbType="VarChar(20)")]
		public string TrangThai
		{
			get
			{
				return this._TrangThai;
			}
			set
			{
				if ((this._TrangThai != value))
				{
					this.OnTrangThaiChanging(value);
					this.SendPropertyChanging();
					this._TrangThai = value;
					this.SendPropertyChanged("TrangThai");
					this.OnTrangThaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="QuanLyNhanSu_ThongTinCaNhan", Storage="_ThongTinCaNhan", ThisKey="TenDangNhap", OtherKey="TenDangNhap", IsUnique=true, IsForeignKey=false)]
		public ThongTinCaNhan ThongTinCaNhan
		{
			get
			{
				return this._ThongTinCaNhan.Entity;
			}
			set
			{
				ThongTinCaNhan previousValue = this._ThongTinCaNhan.Entity;
				if (((previousValue != value) 
							|| (this._ThongTinCaNhan.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ThongTinCaNhan.Entity = null;
						previousValue.QuanLyNhanSu = null;
					}
					this._ThongTinCaNhan.Entity = value;
					if ((value != null))
					{
						value.QuanLyNhanSu = this;
					}
					this.SendPropertyChanged("ThongTinCaNhan");
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
}
#pragma warning restore 1591
