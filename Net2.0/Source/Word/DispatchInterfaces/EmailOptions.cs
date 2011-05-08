//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.WordApi
{
	///<summary>
	/// DispatchInterface EmailOptions SupportByLibrary WD09 WD10 WD11 WD12 WD14 
	///</summary>
	[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
	public class EmailOptions : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public EmailOptions(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public EmailOptions(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public EmailOptions(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public EmailOptions()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public LateBindingApi.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				LateBindingApi.WordApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
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
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public bool UseThemeStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "UseThemeStyle", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "UseThemeStyle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public string MarkCommentsWith
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MarkCommentsWith", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MarkCommentsWith", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public bool MarkComments
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MarkComments", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MarkComments", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public LateBindingApi.WordApi.EmailSignature EmailSignature
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EmailSignature", paramsArray);
				LateBindingApi.WordApi.EmailSignature newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.EmailSignature;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public LateBindingApi.WordApi.Style ComposeStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ComposeStyle", paramsArray);
				LateBindingApi.WordApi.Style newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.Style;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public LateBindingApi.WordApi.Style ReplyStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ReplyStyle", paramsArray);
				LateBindingApi.WordApi.Style newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.Style;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public string ThemeName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ThemeName", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ThemeName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public bool Dummy1
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Dummy1", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public bool Dummy2
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Dummy2", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public bool NewColorOnReply
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NewColorOnReply", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NewColorOnReply", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public LateBindingApi.WordApi.Style PlainTextStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PlainTextStyle", paramsArray);
				LateBindingApi.WordApi.Style newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.Style;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public bool UseThemeStyleOnReply
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "UseThemeStyleOnReply", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "UseThemeStyleOnReply", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public bool AutoFormatAsYouTypeApplyHeadings
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoFormatAsYouTypeApplyHeadings", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutoFormatAsYouTypeApplyHeadings", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public bool AutoFormatAsYouTypeApplyBorders
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoFormatAsYouTypeApplyBorders", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutoFormatAsYouTypeApplyBorders", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public bool AutoFormatAsYouTypeApplyBulletedLists
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoFormatAsYouTypeApplyBulletedLists", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutoFormatAsYouTypeApplyBulletedLists", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public bool AutoFormatAsYouTypeApplyNumberedLists
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoFormatAsYouTypeApplyNumberedLists", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutoFormatAsYouTypeApplyNumberedLists", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public bool AutoFormatAsYouTypeReplaceQuotes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoFormatAsYouTypeReplaceQuotes", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutoFormatAsYouTypeReplaceQuotes", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public bool AutoFormatAsYouTypeReplaceSymbols
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoFormatAsYouTypeReplaceSymbols", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutoFormatAsYouTypeReplaceSymbols", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public bool AutoFormatAsYouTypeReplaceOrdinals
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoFormatAsYouTypeReplaceOrdinals", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutoFormatAsYouTypeReplaceOrdinals", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public bool AutoFormatAsYouTypeReplaceFractions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoFormatAsYouTypeReplaceFractions", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutoFormatAsYouTypeReplaceFractions", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public bool AutoFormatAsYouTypeReplacePlainTextEmphasis
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoFormatAsYouTypeReplacePlainTextEmphasis", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutoFormatAsYouTypeReplacePlainTextEmphasis", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public bool AutoFormatAsYouTypeFormatListItemBeginning
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoFormatAsYouTypeFormatListItemBeginning", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutoFormatAsYouTypeFormatListItemBeginning", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public bool AutoFormatAsYouTypeDefineStyles
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoFormatAsYouTypeDefineStyles", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutoFormatAsYouTypeDefineStyles", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public bool AutoFormatAsYouTypeReplaceHyperlinks
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoFormatAsYouTypeReplaceHyperlinks", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutoFormatAsYouTypeReplaceHyperlinks", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public bool AutoFormatAsYouTypeApplyTables
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoFormatAsYouTypeApplyTables", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutoFormatAsYouTypeApplyTables", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public bool AutoFormatAsYouTypeApplyFirstIndents
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoFormatAsYouTypeApplyFirstIndents", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutoFormatAsYouTypeApplyFirstIndents", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public bool AutoFormatAsYouTypeApplyDates
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoFormatAsYouTypeApplyDates", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutoFormatAsYouTypeApplyDates", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public bool AutoFormatAsYouTypeApplyClosings
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoFormatAsYouTypeApplyClosings", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutoFormatAsYouTypeApplyClosings", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public bool AutoFormatAsYouTypeMatchParentheses
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoFormatAsYouTypeMatchParentheses", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutoFormatAsYouTypeMatchParentheses", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public bool AutoFormatAsYouTypeReplaceFarEastDashes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoFormatAsYouTypeReplaceFarEastDashes", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutoFormatAsYouTypeReplaceFarEastDashes", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public bool AutoFormatAsYouTypeDeleteAutoSpaces
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoFormatAsYouTypeDeleteAutoSpaces", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutoFormatAsYouTypeDeleteAutoSpaces", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public bool AutoFormatAsYouTypeInsertClosings
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoFormatAsYouTypeInsertClosings", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutoFormatAsYouTypeInsertClosings", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public bool AutoFormatAsYouTypeAutoLetterWizard
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoFormatAsYouTypeAutoLetterWizard", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutoFormatAsYouTypeAutoLetterWizard", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public bool AutoFormatAsYouTypeInsertOvers
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoFormatAsYouTypeInsertOvers", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutoFormatAsYouTypeInsertOvers", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public bool RelyOnCSS
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RelyOnCSS", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RelyOnCSS", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public LateBindingApi.WordApi.Enums.WdEmailHTMLFidelity HTMLFidelity
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HTMLFidelity", paramsArray);
				return (LateBindingApi.WordApi.Enums.WdEmailHTMLFidelity)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HTMLFidelity", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public bool EmbedSmartTag
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EmbedSmartTag", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "EmbedSmartTag", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public bool TabIndentKey
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TabIndentKey", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TabIndentKey", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public void Dummy3()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Dummy3", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}