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
	/// DispatchInterface _MobileItem SupportByLibrary OL14 
	///</summary>
	[SupportByLibrary("OL14")]
	public class _MobileItem : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _MobileItem(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _MobileItem(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _MobileItem(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _MobileItem()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
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
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
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
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
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
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
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
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public LateBindingApi.OutlookApi.Actions Actions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Actions", paramsArray);
				LateBindingApi.OutlookApi.Actions newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi.Actions;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public LateBindingApi.OutlookApi.Attachments Attachments
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Attachments", paramsArray);
				LateBindingApi.OutlookApi.Attachments newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi.Attachments;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public string BillingInformation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BillingInformation", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BillingInformation", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public string Body
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Body", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Body", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public string Categories
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Categories", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Categories", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public string Companies
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Companies", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Companies", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public string ConversationIndex
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ConversationIndex", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public string ConversationTopic
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ConversationTopic", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public DateTime CreationTime
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CreationTime", paramsArray);
				return (DateTime)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
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
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public LateBindingApi.OutlookApi.FormDescription FormDescription
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FormDescription", paramsArray);
				LateBindingApi.OutlookApi.FormDescription newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi.FormDescription;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public LateBindingApi.OutlookApi._Inspector GetInspector
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GetInspector", paramsArray);
				LateBindingApi.OutlookApi._Inspector newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi._Inspector;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public LateBindingApi.OutlookApi.Enums.OlImportance Importance
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Importance", paramsArray);
				return (LateBindingApi.OutlookApi.Enums.OlImportance)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Importance", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public DateTime LastModificationTime
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LastModificationTime", paramsArray);
				return (DateTime)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
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
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public string MessageClass
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MessageClass", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MessageClass", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public string Mileage
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Mileage", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Mileage", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public bool NoAging
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NoAging", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NoAging", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public Int32 OutlookInternalVersion
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OutlookInternalVersion", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public string OutlookVersion
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OutlookVersion", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public bool Saved
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Saved", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public LateBindingApi.OutlookApi.Enums.OlSensitivity Sensitivity
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Sensitivity", paramsArray);
				return (LateBindingApi.OutlookApi.Enums.OlSensitivity)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Sensitivity", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public Int32 Size
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Size", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public string Subject
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Subject", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Subject", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public bool UnRead
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "UnRead", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "UnRead", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public LateBindingApi.OutlookApi.UserProperties UserProperties
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "UserProperties", paramsArray);
				LateBindingApi.OutlookApi.UserProperties newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi.UserProperties;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public string HTMLBody
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HTMLBody", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HTMLBody", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public LateBindingApi.OutlookApi.Enums.OlMobileFormat MobileFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MobileFormat", paramsArray);
				return (LateBindingApi.OutlookApi.Enums.OlMobileFormat)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public string SMILBody
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SMILBody", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SMILBody", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public LateBindingApi.OutlookApi.Recipients Recipients
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Recipients", paramsArray);
				LateBindingApi.OutlookApi.Recipients newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi.Recipients;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public string To
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "To", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "To", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public string ReplyRecipientNames
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ReplyRecipientNames", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public LateBindingApi.OutlookApi.Recipients ReplyRecipients
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ReplyRecipients", paramsArray);
				LateBindingApi.OutlookApi.Recipients newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi.Recipients;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public bool Submitted
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Submitted", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public LateBindingApi.OutlookApi.ItemProperties ItemProperties
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ItemProperties", paramsArray);
				LateBindingApi.OutlookApi.ItemProperties newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi.ItemProperties;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public DateTime ReceivedTime
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ReceivedTime", paramsArray);
				return (DateTime)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public LateBindingApi.OutlookApi.Account SendUsingAccount
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SendUsingAccount", paramsArray);
				LateBindingApi.OutlookApi.Account newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi.Account;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SendUsingAccount", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public bool Sent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Sent", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public DateTime SentOn
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SentOn", paramsArray);
				return (DateTime)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
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
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public string ReceivedByEntryID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ReceivedByEntryID", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public string ReceivedByName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ReceivedByName", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public string SenderEmailAddress
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SenderEmailAddress", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public string SenderEmailType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SenderEmailType", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public string SenderName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SenderName", paramsArray);
				return (string)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		/// <param name="SaveMode">LateBindingApi.OutlookApi.Enums.OlInspectorClose SaveMode</param>
		[SupportByLibrary("OL14")]
		public void Close(LateBindingApi.OutlookApi.Enums.OlInspectorClose saveMode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(saveMode);
			Invoker.Method(this, "Close", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public COMObject Copy()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Copy", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		/// <param name="Modal">optional object Modal</param>
		[SupportByLibrary("OL14")]
		public void Display(object modal)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(modal);
			Invoker.Method(this, "Display", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public void Display()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Display", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		/// <param name="DestFldr">LateBindingApi.OutlookApi.MAPIFolder DestFldr</param>
		[SupportByLibrary("OL14")]
		public COMObject Move(LateBindingApi.OutlookApi.MAPIFolder destFldr)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(destFldr);
			object returnItem = Invoker.MethodReturn(this, "Move", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public void PrintOut()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public void Save()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Save", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		/// <param name="Path">string Path</param>
		/// <param name="Type">optional object Type</param>
		[SupportByLibrary("OL14")]
		public void SaveAs(string path, object type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(path, type);
			Invoker.Method(this, "SaveAs", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		/// <param name="Path">string Path</param>
		[SupportByLibrary("OL14")]
		public void SaveAs(string path)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(path);
			Invoker.Method(this, "SaveAs", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public LateBindingApi.OutlookApi.MobileItem Reply()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Reply", paramsArray);
			LateBindingApi.OutlookApi.MobileItem newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OutlookApi.MobileItem;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public LateBindingApi.OutlookApi.MobileItem ReplyAll()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ReplyAll", paramsArray);
			LateBindingApi.OutlookApi.MobileItem newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OutlookApi.MobileItem;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		/// <param name="ForceSend">bool ForceSend</param>
		[SupportByLibrary("OL14")]
		public void Send(bool forceSend)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(forceSend);
			Invoker.Method(this, "Send", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public LateBindingApi.OutlookApi.MobileItem Forward()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Forward", paramsArray);
			LateBindingApi.OutlookApi.MobileItem newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OutlookApi.MobileItem;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}