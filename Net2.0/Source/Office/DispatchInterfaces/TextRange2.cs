//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace LateBindingApi.OfficeApi
{
	///<summary>
	/// DispatchInterface TextRange2 SupportByLibrary OF12 OF14 
	///</summary>
	[SupportByLibrary("OF12","OF14")]
	public class TextRange2 : _IMsoDispObj ,IEnumerable
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TextRange2(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TextRange2(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TextRange2(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TextRange2()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public string Text
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Text", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Text", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
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
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
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
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="Start">Int32 Start</param>
		/// <param name="Length">Int32 Length</param>
		[SupportByLibrary("OF12","OF14")]
		public LateBindingApi.OfficeApi.TextRange2 get_Paragraphs(Int32 start, Int32 length)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(start, length);
			object returnItem = Invoker.PropertyGet(this, "Paragraphs", paramsArray);
			LateBindingApi.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="Start">Int32 Start</param>
		/// <param name="Length">Int32 Length</param>
		[SupportByLibrary("OF12","OF14")]
		public LateBindingApi.OfficeApi.TextRange2 get_Sentences(Int32 start, Int32 length)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(start, length);
			object returnItem = Invoker.PropertyGet(this, "Sentences", paramsArray);
			LateBindingApi.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="Start">Int32 Start</param>
		/// <param name="Length">Int32 Length</param>
		[SupportByLibrary("OF12","OF14")]
		public LateBindingApi.OfficeApi.TextRange2 get_Words(Int32 start, Int32 length)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(start, length);
			object returnItem = Invoker.PropertyGet(this, "Words", paramsArray);
			LateBindingApi.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="Start">Int32 Start</param>
		/// <param name="Length">Int32 Length</param>
		[SupportByLibrary("OF12","OF14")]
		public LateBindingApi.OfficeApi.TextRange2 get_Characters(Int32 start, Int32 length)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(start, length);
			object returnItem = Invoker.PropertyGet(this, "Characters", paramsArray);
			LateBindingApi.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="Start">Int32 Start</param>
		/// <param name="Length">Int32 Length</param>
		[SupportByLibrary("OF12","OF14")]
		public LateBindingApi.OfficeApi.TextRange2 get_Lines(Int32 start, Int32 length)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(start, length);
			object returnItem = Invoker.PropertyGet(this, "Lines", paramsArray);
			LateBindingApi.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="Start">Int32 Start</param>
		/// <param name="Length">Int32 Length</param>
		[SupportByLibrary("OF12","OF14")]
		public LateBindingApi.OfficeApi.TextRange2 get_Runs(Int32 start, Int32 length)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(start, length);
			object returnItem = Invoker.PropertyGet(this, "Runs", paramsArray);
			LateBindingApi.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public LateBindingApi.OfficeApi.ParagraphFormat2 ParagraphFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ParagraphFormat", paramsArray);
				LateBindingApi.OfficeApi.ParagraphFormat2 newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OfficeApi.ParagraphFormat2;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public LateBindingApi.OfficeApi.Font2 Font
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Font", paramsArray);
				LateBindingApi.OfficeApi.Font2 newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OfficeApi.Font2;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public Int32 Length
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Length", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public Int32 Start
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Start", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public Single BoundLeft
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BoundLeft", paramsArray);
				return (Single)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public Single BoundTop
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BoundTop", paramsArray);
				return (Single)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public Single BoundWidth
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BoundWidth", paramsArray);
				return (Single)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public Single BoundHeight
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BoundHeight", paramsArray);
				return (Single)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public LateBindingApi.OfficeApi.Enums.MsoLanguageID LanguageID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LanguageID", paramsArray);
				return (LateBindingApi.OfficeApi.Enums.MsoLanguageID)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LanguageID", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OF14 
		/// </summary>
		/// <param name="Start">Int32 Start</param>
		/// <param name="Length">Int32 Length</param>
		[SupportByLibrary("OF14")]
		public LateBindingApi.OfficeApi.TextRange2 get_MathZones(Int32 start, Int32 length)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(start, length);
			object returnItem = Invoker.PropertyGet(this, "MathZones", paramsArray);
			LateBindingApi.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OfficeApi.TextRange2;
			return newObject;
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("OF12","OF14")]
		public LateBindingApi.OfficeApi.TextRange2 Item(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
			LateBindingApi.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public LateBindingApi.OfficeApi.TextRange2 TrimText()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "TrimText", paramsArray);
			LateBindingApi.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="NewText">string NewText</param>
		[SupportByLibrary("OF12","OF14")]
		public LateBindingApi.OfficeApi.TextRange2 InsertAfter(string newText)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(newText);
			object returnItem = Invoker.MethodReturn(this, "InsertAfter", paramsArray);
			LateBindingApi.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="NewText">string NewText</param>
		[SupportByLibrary("OF12","OF14")]
		public LateBindingApi.OfficeApi.TextRange2 InsertBefore(string newText)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(newText);
			object returnItem = Invoker.MethodReturn(this, "InsertBefore", paramsArray);
			LateBindingApi.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="FontName">string FontName</param>
		/// <param name="CharNumber">Int32 CharNumber</param>
		/// <param name="Unicode">LateBindingApi.OfficeApi.Enums.MsoTriState Unicode</param>
		[SupportByLibrary("OF12","OF14")]
		public LateBindingApi.OfficeApi.TextRange2 InsertSymbol(string fontName, Int32 charNumber, LateBindingApi.OfficeApi.Enums.MsoTriState unicode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fontName, charNumber, unicode);
			object returnItem = Invoker.MethodReturn(this, "InsertSymbol", paramsArray);
			LateBindingApi.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public void Select()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Select", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public void Cut()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Cut", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public void Copy()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Copy", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public LateBindingApi.OfficeApi.TextRange2 Paste()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Paste", paramsArray);
			LateBindingApi.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="Format">LateBindingApi.OfficeApi.Enums.MsoClipboardFormat Format</param>
		[SupportByLibrary("OF12","OF14")]
		public LateBindingApi.OfficeApi.TextRange2 PasteSpecial(LateBindingApi.OfficeApi.Enums.MsoClipboardFormat format)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(format);
			object returnItem = Invoker.MethodReturn(this, "PasteSpecial", paramsArray);
			LateBindingApi.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="Type">LateBindingApi.OfficeApi.Enums.MsoTextChangeCase Type</param>
		[SupportByLibrary("OF12","OF14")]
		public void ChangeCase(LateBindingApi.OfficeApi.Enums.MsoTextChangeCase type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type);
			Invoker.Method(this, "ChangeCase", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public void AddPeriods()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "AddPeriods", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public void RemovePeriods()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "RemovePeriods", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="FindWhat">string FindWhat</param>
		/// <param name="After">Int32 After</param>
		/// <param name="MatchCase">LateBindingApi.OfficeApi.Enums.MsoTriState MatchCase</param>
		/// <param name="WholeWords">LateBindingApi.OfficeApi.Enums.MsoTriState WholeWords</param>
		[SupportByLibrary("OF12","OF14")]
		public LateBindingApi.OfficeApi.TextRange2 Find(string findWhat, Int32 after, LateBindingApi.OfficeApi.Enums.MsoTriState matchCase, LateBindingApi.OfficeApi.Enums.MsoTriState wholeWords)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findWhat, after, matchCase, wholeWords);
			object returnItem = Invoker.MethodReturn(this, "Find", paramsArray);
			LateBindingApi.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="FindWhat">string FindWhat</param>
		/// <param name="ReplaceWhat">string ReplaceWhat</param>
		/// <param name="After">Int32 After</param>
		/// <param name="MatchCase">LateBindingApi.OfficeApi.Enums.MsoTriState MatchCase</param>
		/// <param name="WholeWords">LateBindingApi.OfficeApi.Enums.MsoTriState WholeWords</param>
		[SupportByLibrary("OF12","OF14")]
		public LateBindingApi.OfficeApi.TextRange2 Replace(string findWhat, string replaceWhat, Int32 after, LateBindingApi.OfficeApi.Enums.MsoTriState matchCase, LateBindingApi.OfficeApi.Enums.MsoTriState wholeWords)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findWhat, replaceWhat, after, matchCase, wholeWords);
			object returnItem = Invoker.MethodReturn(this, "Replace", paramsArray);
			LateBindingApi.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="X1">ref Single X1</param>
		/// <param name="Y1">ref Single Y1</param>
		/// <param name="X2">ref Single X2</param>
		/// <param name="Y2">ref Single Y2</param>
		/// <param name="X3">ref Single X3</param>
		/// <param name="Y3">ref Single Y3</param>
		/// <param name="x4">ref Single x4</param>
		/// <param name="y4">ref Single y4</param>
		[SupportByLibrary("OF12","OF14")]
		public void RotatedBounds(ref Single x1, ref Single y1, ref Single x2, ref Single y2, ref Single x3, ref Single y3, ref Single x4, ref Single y4)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true,true,true,true,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(x1, y1, x2, y2, x3, y3, x4, y4);
			Invoker.Method(this, "RotatedBounds", paramsArray, modifiers);
			x1 = (Single)paramsArray[0];
			y1 = (Single)paramsArray[1];
			x2 = (Single)paramsArray[2];
			y2 = (Single)paramsArray[3];
			x3 = (Single)paramsArray[4];
			y3 = (Single)paramsArray[5];
			x4 = (Single)paramsArray[6];
			y4 = (Single)paramsArray[7];
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public void RtlRun()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "RtlRun", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public void LtrRun()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "LtrRun", paramsArray);
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("OF12","OF14")]
		public IEnumerator GetEnumerator()
		{
			object enumProxy = Invoker.PropertyGet(this, "_NewEnum");
			COMObject enumerator = new COMObject(this, enumProxy);
			Invoker.Method(enumerator, "Reset", null);
			bool isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
            while (true == isMoveNextTrue)
            {
                object itemProxy = Invoker.PropertyGet(enumerator, "Current", null);
                COMObject returnClass = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, itemProxy);
                isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
				yield return returnClass;
            }
        }

        #endregion
		#pragma warning restore
	}
}