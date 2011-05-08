//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.PowerPointApi
{
	///<summary>
	/// DispatchInterface MediaFormat SupportByLibrary PP14 
	///</summary>
	[SupportByLibrary("PP14")]
	public class MediaFormat : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MediaFormat(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MediaFormat(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MediaFormat(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MediaFormat()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public LateBindingApi.PowerPointApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				LateBindingApi.PowerPointApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.PowerPointApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
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
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public Single Volume
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Volume", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Volume", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public bool Muted
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Muted", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Muted", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
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
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public Int32 StartPoint
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "StartPoint", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "StartPoint", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public Int32 EndPoint
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EndPoint", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "EndPoint", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public Int32 FadeInDuration
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FadeInDuration", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FadeInDuration", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public Int32 FadeOutDuration
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FadeOutDuration", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FadeOutDuration", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public LateBindingApi.PowerPointApi.MediaBookmarks MediaBookmarks
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MediaBookmarks", paramsArray);
				LateBindingApi.PowerPointApi.MediaBookmarks newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.PowerPointApi.MediaBookmarks;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public LateBindingApi.PowerPointApi.Enums.PpMediaTaskStatus ResamplingStatus
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ResamplingStatus", paramsArray);
				return (LateBindingApi.PowerPointApi.Enums.PpMediaTaskStatus)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public bool IsLinked
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsLinked", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public bool IsEmbedded
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsEmbedded", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public Int32 AudioSamplingRate
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AudioSamplingRate", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public Int32 VideoFrameRate
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "VideoFrameRate", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public Int32 SampleHeight
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SampleHeight", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public Int32 SampleWidth
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SampleWidth", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public string VideoCompressionType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "VideoCompressionType", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public string AudioCompressionType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AudioCompressionType", paramsArray);
				return (string)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		/// <param name="Position">Int32 Position</param>
		[SupportByLibrary("PP14")]
		public void SetDisplayPicture(Int32 position)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(position);
			Invoker.Method(this, "SetDisplayPicture", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		/// <param name="FilePath">string FilePath</param>
		[SupportByLibrary("PP14")]
		public void SetDisplayPictureFromFile(string filePath)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filePath);
			Invoker.Method(this, "SetDisplayPictureFromFile", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		/// <param name="Trim">bool Trim</param>
		/// <param name="SampleHeight">Int32 SampleHeight</param>
		/// <param name="SampleWidth">Int32 SampleWidth</param>
		/// <param name="VideoFrameRate">Int32 VideoFrameRate</param>
		/// <param name="AudioSamplingRate">Int32 AudioSamplingRate</param>
		/// <param name="VideoBitRate">Int32 VideoBitRate</param>
		[SupportByLibrary("PP14")]
		public void Resample(bool trim, Int32 sampleHeight, Int32 sampleWidth, Int32 videoFrameRate, Int32 audioSamplingRate, Int32 videoBitRate)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(trim, sampleHeight, sampleWidth, videoFrameRate, audioSamplingRate, videoBitRate);
			Invoker.Method(this, "Resample", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		/// <param name="profile">LateBindingApi.PowerPointApi.Enums.PpResampleMediaProfile profile</param>
		[SupportByLibrary("PP14")]
		public void ResampleFromProfile(LateBindingApi.PowerPointApi.Enums.PpResampleMediaProfile profile)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(profile);
			Invoker.Method(this, "ResampleFromProfile", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}