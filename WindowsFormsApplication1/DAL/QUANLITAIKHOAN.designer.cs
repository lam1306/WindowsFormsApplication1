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

namespace DAL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TaiKhoan")]
	public partial class QUANLITAIKHOANDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public QUANLITAIKHOANDataContext() : 
				base(global::DAL.Properties.Settings.Default.TaiKhoanConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QUANLITAIKHOANDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QUANLITAIKHOANDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QUANLITAIKHOANDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QUANLITAIKHOANDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TAIKHOAN> TAIKHOANs
		{
			get
			{
				return this.GetTable<TAIKHOAN>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TAIKHOAN")]
	public partial class TAIKHOAN
	{
		
		private string _TaiKhoan;
		
		private string _MatKhau;
		
		private string _Ten;
		
		private string _DienThoai;
		
		private string _Email;
		
		private string _GioiTinh;
		
		public TAIKHOAN()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaiKhoan", DbType="NVarChar(50)")]
		public string TaiKhoan
		{
			get
			{
				return this._TaiKhoan;
			}
			set
			{
				if ((this._TaiKhoan != value))
				{
					this._TaiKhoan = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhau", DbType="NVarChar(50)")]
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
					this._MatKhau = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ten", DbType="NVarChar(MAX)")]
		public string Ten
		{
			get
			{
				return this._Ten;
			}
			set
			{
				if ((this._Ten != value))
				{
					this._Ten = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DienThoai", DbType="NVarChar(MAX)")]
		public string DienThoai
		{
			get
			{
				return this._DienThoai;
			}
			set
			{
				if ((this._DienThoai != value))
				{
					this._DienThoai = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(MAX)")]
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
					this._Email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinh", DbType="NVarChar(MAX)")]
		public string GioiTinh
		{
			get
			{
				return this._GioiTinh;
			}
			set
			{
				if ((this._GioiTinh != value))
				{
					this._GioiTinh = value;
				}
			}
		}
	}
}
#pragma warning restore 1591