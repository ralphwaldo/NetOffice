//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.OfficeApi
{
	///<summary>
	/// DispatchInterface SignatureProvider SupportByLibrary OF12 OF14 
	///</summary>
	[SupportByLibrary("OF12","OF14")]
	public class SignatureProvider : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SignatureProvider(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SignatureProvider(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SignatureProvider(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SignatureProvider()
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="siglnimg">LateBindingApi.OfficeApi.Enums.SignatureLineImage siglnimg</param>
		/// <param name="psigsetup">LateBindingApi.OfficeApi.SignatureSetup psigsetup</param>
		/// <param name="psiginfo">LateBindingApi.OfficeApi.SignatureInfo psiginfo</param>
		/// <param name="XmlDsigStream">object XmlDsigStream</param>
		[SupportByLibrary("OF12","OF14")]
		public stdole.Picture GenerateSignatureLineImage(LateBindingApi.OfficeApi.Enums.SignatureLineImage siglnimg, LateBindingApi.OfficeApi.SignatureSetup psigsetup, LateBindingApi.OfficeApi.SignatureInfo psiginfo, object xmlDsigStream)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(siglnimg, psigsetup, psiginfo, xmlDsigStream);
			object returnItem = Invoker.MethodReturn(this, "GenerateSignatureLineImage", paramsArray);
			stdole.Picture newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as stdole.Picture;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="ParentWindow">object ParentWindow</param>
		/// <param name="psigsetup">LateBindingApi.OfficeApi.SignatureSetup psigsetup</param>
		[SupportByLibrary("OF12","OF14")]
		public void ShowSignatureSetup(object parentWindow, LateBindingApi.OfficeApi.SignatureSetup psigsetup)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(parentWindow, psigsetup);
			Invoker.Method(this, "ShowSignatureSetup", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="ParentWindow">object ParentWindow</param>
		/// <param name="psigsetup">LateBindingApi.OfficeApi.SignatureSetup psigsetup</param>
		/// <param name="psiginfo">LateBindingApi.OfficeApi.SignatureInfo psiginfo</param>
		[SupportByLibrary("OF12","OF14")]
		public void ShowSigningCeremony(object parentWindow, LateBindingApi.OfficeApi.SignatureSetup psigsetup, LateBindingApi.OfficeApi.SignatureInfo psiginfo)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(parentWindow, psigsetup, psiginfo);
			Invoker.Method(this, "ShowSigningCeremony", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="QueryContinue">object QueryContinue</param>
		/// <param name="psigsetup">LateBindingApi.OfficeApi.SignatureSetup psigsetup</param>
		/// <param name="psiginfo">LateBindingApi.OfficeApi.SignatureInfo psiginfo</param>
		/// <param name="XmlDsigStream">object XmlDsigStream</param>
		[SupportByLibrary("OF12","OF14")]
		public void SignXmlDsig(object queryContinue, LateBindingApi.OfficeApi.SignatureSetup psigsetup, LateBindingApi.OfficeApi.SignatureInfo psiginfo, object xmlDsigStream)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(queryContinue, psigsetup, psiginfo, xmlDsigStream);
			Invoker.Method(this, "SignXmlDsig", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="ParentWindow">object ParentWindow</param>
		/// <param name="psigsetup">LateBindingApi.OfficeApi.SignatureSetup psigsetup</param>
		/// <param name="psiginfo">LateBindingApi.OfficeApi.SignatureInfo psiginfo</param>
		[SupportByLibrary("OF12","OF14")]
		public void NotifySignatureAdded(object parentWindow, LateBindingApi.OfficeApi.SignatureSetup psigsetup, LateBindingApi.OfficeApi.SignatureInfo psiginfo)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(parentWindow, psigsetup, psiginfo);
			Invoker.Method(this, "NotifySignatureAdded", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="QueryContinue">object QueryContinue</param>
		/// <param name="psigsetup">LateBindingApi.OfficeApi.SignatureSetup psigsetup</param>
		/// <param name="psiginfo">LateBindingApi.OfficeApi.SignatureInfo psiginfo</param>
		/// <param name="XmlDsigStream">object XmlDsigStream</param>
		/// <param name="pcontverres">LateBindingApi.OfficeApi.Enums.ContentVerificationResults pcontverres</param>
		/// <param name="pcertverres">LateBindingApi.OfficeApi.Enums.CertificateVerificationResults pcertverres</param>
		[SupportByLibrary("OF12","OF14")]
		public void VerifyXmlDsig(object queryContinue, LateBindingApi.OfficeApi.SignatureSetup psigsetup, LateBindingApi.OfficeApi.SignatureInfo psiginfo, object xmlDsigStream, LateBindingApi.OfficeApi.Enums.ContentVerificationResults pcontverres, LateBindingApi.OfficeApi.Enums.CertificateVerificationResults pcertverres)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(queryContinue, psigsetup, psiginfo, xmlDsigStream, pcontverres, pcertverres);
			Invoker.Method(this, "VerifyXmlDsig", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="ParentWindow">object ParentWindow</param>
		/// <param name="psigsetup">LateBindingApi.OfficeApi.SignatureSetup psigsetup</param>
		/// <param name="psiginfo">LateBindingApi.OfficeApi.SignatureInfo psiginfo</param>
		/// <param name="XmlDsigStream">object XmlDsigStream</param>
		/// <param name="pcontverres">LateBindingApi.OfficeApi.Enums.ContentVerificationResults pcontverres</param>
		/// <param name="pcertverres">LateBindingApi.OfficeApi.Enums.CertificateVerificationResults pcertverres</param>
		[SupportByLibrary("OF12","OF14")]
		public void ShowSignatureDetails(object parentWindow, LateBindingApi.OfficeApi.SignatureSetup psigsetup, LateBindingApi.OfficeApi.SignatureInfo psiginfo, object xmlDsigStream, LateBindingApi.OfficeApi.Enums.ContentVerificationResults pcontverres, LateBindingApi.OfficeApi.Enums.CertificateVerificationResults pcertverres)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(parentWindow, psigsetup, psiginfo, xmlDsigStream, pcontverres, pcertverres);
			Invoker.Method(this, "ShowSignatureDetails", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="sigprovdet">LateBindingApi.OfficeApi.Enums.SignatureProviderDetail sigprovdet</param>
		[SupportByLibrary("OF12","OF14")]
		public object GetProviderDetail(LateBindingApi.OfficeApi.Enums.SignatureProviderDetail sigprovdet)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sigprovdet);
			object returnItem = Invoker.MethodReturn(this, "GetProviderDetail", paramsArray);
			Type returnItemType = returnItem.GetType();
			if(true == returnItemType.IsCOMObject)
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="QueryContinue">object QueryContinue</param>
		/// <param name="Stream">object Stream</param>
		[SupportByLibrary("OF12","OF14")]
		public byte[] HashStream(object queryContinue, object stream)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(queryContinue, stream);
			object returnItem = (object)Invoker.MethodReturn(this, "HashStream", paramsArray);
			return (byte[])returnItem;
		}

		#endregion
		#pragma warning restore
	}
}