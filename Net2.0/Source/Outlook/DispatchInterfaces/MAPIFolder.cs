//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.OutlookApi
{
	///<summary>
	/// DispatchInterface MAPIFolder SupportByLibrary OL09 OL10 OL11 OL12 OL14 
	///</summary>
	[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
	public class MAPIFolder : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MAPIFolder(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MAPIFolder(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MAPIFolder(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MAPIFolder()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public LateBindingApi.OutlookApi._Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				LateBindingApi.OutlookApi._Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi._Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public LateBindingApi.OutlookApi.Enums.OlObjectClass Class
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Class", paramsArray);
				return (LateBindingApi.OutlookApi.Enums.OlObjectClass)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public LateBindingApi.OutlookApi._NameSpace Session
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Session", paramsArray);
				LateBindingApi.OutlookApi._NameSpace newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi._NameSpace;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public LateBindingApi.OutlookApi.Enums.OlItemType DefaultItemType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultItemType", paramsArray);
				return (LateBindingApi.OutlookApi.Enums.OlItemType)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public string DefaultMessageClass
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultMessageClass", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public string Description
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Description", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Description", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public string EntryID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EntryID", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public LateBindingApi.OutlookApi._Folders Folders
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Folders", paramsArray);
				LateBindingApi.OutlookApi._Folders newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi._Folders;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public LateBindingApi.OutlookApi._Items Items
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Items", paramsArray);
				LateBindingApi.OutlookApi._Items newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi._Items;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Name", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public string StoreID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "StoreID", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public Int32 UnReadItemCount
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "UnReadItemCount", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public COMObject UserPermissions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "UserPermissions", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public bool WebViewOn
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "WebViewOn", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "WebViewOn", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public string WebViewURL
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "WebViewURL", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "WebViewURL", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public bool WebViewAllowNavigation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "WebViewAllowNavigation", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "WebViewAllowNavigation", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public string AddressBookName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AddressBookName", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AddressBookName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public bool ShowAsOutlookAB
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowAsOutlookAB", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowAsOutlookAB", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public string FolderPath
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FolderPath", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public bool InAppFolderSyncObject
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "InAppFolderSyncObject", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "InAppFolderSyncObject", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public LateBindingApi.OutlookApi.View CurrentView
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CurrentView", paramsArray);
				LateBindingApi.OutlookApi.View newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi.View;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public bool CustomViewsOnly
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CustomViewsOnly", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CustomViewsOnly", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public LateBindingApi.OutlookApi._Views Views
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Views", paramsArray);
				LateBindingApi.OutlookApi._Views newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi._Views;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public COMObject MAPIOBJECT
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MAPIOBJECT", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public string FullFolderPath
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FullFolderPath", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL11","OL12","OL14")]
		public bool IsSharePointFolder
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsSharePointFolder", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL11","OL12","OL14")]
		public LateBindingApi.OutlookApi.Enums.OlShowItemCount ShowItemCount
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowItemCount", paramsArray);
				return (LateBindingApi.OutlookApi.Enums.OlShowItemCount)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowItemCount", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi.Store Store
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Store", paramsArray);
				LateBindingApi.OutlookApi.Store newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi.Store;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi.PropertyAccessor PropertyAccessor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PropertyAccessor", paramsArray);
				LateBindingApi.OutlookApi.PropertyAccessor newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi.PropertyAccessor;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi.UserDefinedProperties UserDefinedProperties
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "UserDefinedProperties", paramsArray);
				LateBindingApi.OutlookApi.UserDefinedProperties newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi.UserDefinedProperties;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		/// <param name="DestinationFolder">LateBindingApi.OutlookApi.MAPIFolder DestinationFolder</param>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public LateBindingApi.OutlookApi.MAPIFolder CopyTo(LateBindingApi.OutlookApi.MAPIFolder destinationFolder)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(destinationFolder);
			object returnItem = Invoker.MethodReturn(this, "CopyTo", paramsArray);
			LateBindingApi.OutlookApi.MAPIFolder newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OutlookApi.MAPIFolder;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public void Display()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Display", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		/// <param name="DisplayMode">optional object DisplayMode</param>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public LateBindingApi.OutlookApi._Explorer GetExplorer(object displayMode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(displayMode);
			object returnItem = Invoker.MethodReturn(this, "GetExplorer", paramsArray);
			LateBindingApi.OutlookApi._Explorer newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OutlookApi._Explorer;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public LateBindingApi.OutlookApi._Explorer GetExplorer()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetExplorer", paramsArray);
			LateBindingApi.OutlookApi._Explorer newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OutlookApi._Explorer;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		/// <param name="DestinationFolder">LateBindingApi.OutlookApi.MAPIFolder DestinationFolder</param>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public void MoveTo(LateBindingApi.OutlookApi.MAPIFolder destinationFolder)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(destinationFolder);
			Invoker.Method(this, "MoveTo", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public void AddToPFFavorites()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "AddToPFFavorites", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		/// <param name="fNoUI">optional object fNoUI</param>
		/// <param name="Name">optional object Name</param>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public void AddToFavorites(object fNoUI, object name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fNoUI, name);
			Invoker.Method(this, "AddToFavorites", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public void AddToFavorites()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "AddToFavorites", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		/// <param name="StorageIdentifier">string StorageIdentifier</param>
		/// <param name="StorageIdentifierType">LateBindingApi.OutlookApi.Enums.OlStorageIdentifierType StorageIdentifierType</param>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi._StorageItem GetStorage(string storageIdentifier, LateBindingApi.OutlookApi.Enums.OlStorageIdentifierType storageIdentifierType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(storageIdentifier, storageIdentifierType);
			object returnItem = Invoker.MethodReturn(this, "GetStorage", paramsArray);
			LateBindingApi.OutlookApi._StorageItem newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OutlookApi._StorageItem;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		/// <param name="Filter">optional object Filter</param>
		/// <param name="TableContents">optional object TableContents</param>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi.Table GetTable(object filter, object tableContents)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filter, tableContents);
			object returnItem = Invoker.MethodReturn(this, "GetTable", paramsArray);
			LateBindingApi.OutlookApi.Table newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OutlookApi.Table;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi.Table GetTable()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetTable", paramsArray);
			LateBindingApi.OutlookApi.Table newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OutlookApi.Table;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi.CalendarSharing GetCalendarExporter()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetCalendarExporter", paramsArray);
			LateBindingApi.OutlookApi.CalendarSharing newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OutlookApi.CalendarSharing;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public stdole.Picture GetCustomIcon()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetCustomIcon", paramsArray);
			stdole.Picture newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as stdole.Picture;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		/// <param name="Picture">stdole.Picture Picture</param>
		[SupportByLibrary("OL14")]
		public void SetCustomIcon(stdole.Picture picture)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(picture);
			Invoker.Method(this, "SetCustomIcon", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}