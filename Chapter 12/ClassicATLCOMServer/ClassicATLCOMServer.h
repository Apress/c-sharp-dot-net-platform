/* this ALWAYS GENERATED file contains the definitions for the interfaces */


/* File created by MIDL compiler version 5.01.0164 */
/* at Mon May 06 23:10:17 2002
 */
/* Compiler settings for C:\Apress Books\C# Book First Edition\Labs\Chapter 12\ClassicATLCOMServer\ClassicATLCOMServer.idl:
    Oicf (OptLev=i2), W1, Zp8, env=Win32, ms_ext, c_ext
    error checks: allocation ref bounds_check enum stub_data 
*/
//@@MIDL_FILE_HEADING(  )


/* verify that the <rpcndr.h> version is high enough to compile this file*/
#ifndef __REQUIRED_RPCNDR_H_VERSION__
#define __REQUIRED_RPCNDR_H_VERSION__ 440
#endif

#include "rpc.h"
#include "rpcndr.h"

#ifndef __RPCNDR_H_VERSION__
#error this stub requires an updated version of <rpcndr.h>
#endif // __RPCNDR_H_VERSION__

#ifndef COM_NO_WINDOWS_H
#include "windows.h"
#include "ole2.h"
#endif /*COM_NO_WINDOWS_H*/

#ifndef __ClassicATLCOMServer_h__
#define __ClassicATLCOMServer_h__

#ifdef __cplusplus
extern "C"{
#endif 

/* Forward Declarations */ 

#ifndef __IEngine_FWD_DEFINED__
#define __IEngine_FWD_DEFINED__
typedef interface IEngine IEngine;
#endif 	/* __IEngine_FWD_DEFINED__ */


#ifndef __IDriverInfo_FWD_DEFINED__
#define __IDriverInfo_FWD_DEFINED__
typedef interface IDriverInfo IDriverInfo;
#endif 	/* __IDriverInfo_FWD_DEFINED__ */


#ifndef __ICar_FWD_DEFINED__
#define __ICar_FWD_DEFINED__
typedef interface ICar ICar;
#endif 	/* __ICar_FWD_DEFINED__ */


#ifndef __IParams_FWD_DEFINED__
#define __IParams_FWD_DEFINED__
typedef interface IParams IParams;
#endif 	/* __IParams_FWD_DEFINED__ */


#ifndef __ITurboEngine_FWD_DEFINED__
#define __ITurboEngine_FWD_DEFINED__
typedef interface ITurboEngine ITurboEngine;
#endif 	/* __ITurboEngine_FWD_DEFINED__ */


#ifndef ___ICarEvents_FWD_DEFINED__
#define ___ICarEvents_FWD_DEFINED__
typedef interface _ICarEvents _ICarEvents;
#endif 	/* ___ICarEvents_FWD_DEFINED__ */


#ifndef __CoCar_FWD_DEFINED__
#define __CoCar_FWD_DEFINED__

#ifdef __cplusplus
typedef class CoCar CoCar;
#else
typedef struct CoCar CoCar;
#endif /* __cplusplus */

#endif 	/* __CoCar_FWD_DEFINED__ */


#ifndef __CoEngine_FWD_DEFINED__
#define __CoEngine_FWD_DEFINED__

#ifdef __cplusplus
typedef class CoEngine CoEngine;
#else
typedef struct CoEngine CoEngine;
#endif /* __cplusplus */

#endif 	/* __CoEngine_FWD_DEFINED__ */


/* header files for imported files */
#include "oaidl.h"
#include "ocidl.h"

void __RPC_FAR * __RPC_USER MIDL_user_allocate(size_t);
void __RPC_USER MIDL_user_free( void __RPC_FAR * ); 

/* interface __MIDL_itf_ClassicATLCOMServer_0000 */
/* [local] */ 

typedef 
enum CarType
    {	Jetta	= 0,
	BMW	= Jetta + 1,
	Ford	= BMW + 1,
	Colt	= Ford + 1
    }	CarType;



extern RPC_IF_HANDLE __MIDL_itf_ClassicATLCOMServer_0000_v0_0_c_ifspec;
extern RPC_IF_HANDLE __MIDL_itf_ClassicATLCOMServer_0000_v0_0_s_ifspec;

#ifndef __IEngine_INTERFACE_DEFINED__
#define __IEngine_INTERFACE_DEFINED__

/* interface IEngine */
/* [unique][helpstring][dual][uuid][object] */ 


EXTERN_C const IID IID_IEngine;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("23D2BB87-A8F8-4301-BED5-9D0CA77AE403")
    IEngine : public IDispatch
    {
    public:
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE GetCylinders( 
            /* [retval][out] */ VARIANT __RPC_FAR *arCylinders) = 0;
        
    };
    
#else 	/* C style interface */

    typedef struct IEngineVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *QueryInterface )( 
            IEngine __RPC_FAR * This,
            /* [in] */ REFIID riid,
            /* [iid_is][out] */ void __RPC_FAR *__RPC_FAR *ppvObject);
        
        ULONG ( STDMETHODCALLTYPE __RPC_FAR *AddRef )( 
            IEngine __RPC_FAR * This);
        
        ULONG ( STDMETHODCALLTYPE __RPC_FAR *Release )( 
            IEngine __RPC_FAR * This);
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *GetTypeInfoCount )( 
            IEngine __RPC_FAR * This,
            /* [out] */ UINT __RPC_FAR *pctinfo);
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *GetTypeInfo )( 
            IEngine __RPC_FAR * This,
            /* [in] */ UINT iTInfo,
            /* [in] */ LCID lcid,
            /* [out] */ ITypeInfo __RPC_FAR *__RPC_FAR *ppTInfo);
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *GetIDsOfNames )( 
            IEngine __RPC_FAR * This,
            /* [in] */ REFIID riid,
            /* [size_is][in] */ LPOLESTR __RPC_FAR *rgszNames,
            /* [in] */ UINT cNames,
            /* [in] */ LCID lcid,
            /* [size_is][out] */ DISPID __RPC_FAR *rgDispId);
        
        /* [local] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *Invoke )( 
            IEngine __RPC_FAR * This,
            /* [in] */ DISPID dispIdMember,
            /* [in] */ REFIID riid,
            /* [in] */ LCID lcid,
            /* [in] */ WORD wFlags,
            /* [out][in] */ DISPPARAMS __RPC_FAR *pDispParams,
            /* [out] */ VARIANT __RPC_FAR *pVarResult,
            /* [out] */ EXCEPINFO __RPC_FAR *pExcepInfo,
            /* [out] */ UINT __RPC_FAR *puArgErr);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *GetCylinders )( 
            IEngine __RPC_FAR * This,
            /* [retval][out] */ VARIANT __RPC_FAR *arCylinders);
        
        END_INTERFACE
    } IEngineVtbl;

    interface IEngine
    {
        CONST_VTBL struct IEngineVtbl __RPC_FAR *lpVtbl;
    };

    

#ifdef COBJMACROS


#define IEngine_QueryInterface(This,riid,ppvObject)	\
    (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)

#define IEngine_AddRef(This)	\
    (This)->lpVtbl -> AddRef(This)

#define IEngine_Release(This)	\
    (This)->lpVtbl -> Release(This)


#define IEngine_GetTypeInfoCount(This,pctinfo)	\
    (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)

#define IEngine_GetTypeInfo(This,iTInfo,lcid,ppTInfo)	\
    (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)

#define IEngine_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)	\
    (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)

#define IEngine_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)	\
    (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)


#define IEngine_GetCylinders(This,arCylinders)	\
    (This)->lpVtbl -> GetCylinders(This,arCylinders)

#endif /* COBJMACROS */


#endif 	/* C style interface */



/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE IEngine_GetCylinders_Proxy( 
    IEngine __RPC_FAR * This,
    /* [retval][out] */ VARIANT __RPC_FAR *arCylinders);


void __RPC_STUB IEngine_GetCylinders_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);



#endif 	/* __IEngine_INTERFACE_DEFINED__ */


#ifndef __IDriverInfo_INTERFACE_DEFINED__
#define __IDriverInfo_INTERFACE_DEFINED__

/* interface IDriverInfo */
/* [unique][helpstring][dual][uuid][object] */ 


EXTERN_C const IID IID_IDriverInfo;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("3598361A-135C-4014-9B29-6CD239CA043D")
    IDriverInfo : public IDispatch
    {
    public:
        virtual /* [helpstring][propget][id] */ HRESULT STDMETHODCALLTYPE get_DriverName( 
            /* [retval][out] */ BSTR __RPC_FAR *pVal) = 0;
        
        virtual /* [helpstring][propput][id] */ HRESULT STDMETHODCALLTYPE put_DriverName( 
            /* [in] */ BSTR newVal) = 0;
        
    };
    
#else 	/* C style interface */

    typedef struct IDriverInfoVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *QueryInterface )( 
            IDriverInfo __RPC_FAR * This,
            /* [in] */ REFIID riid,
            /* [iid_is][out] */ void __RPC_FAR *__RPC_FAR *ppvObject);
        
        ULONG ( STDMETHODCALLTYPE __RPC_FAR *AddRef )( 
            IDriverInfo __RPC_FAR * This);
        
        ULONG ( STDMETHODCALLTYPE __RPC_FAR *Release )( 
            IDriverInfo __RPC_FAR * This);
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *GetTypeInfoCount )( 
            IDriverInfo __RPC_FAR * This,
            /* [out] */ UINT __RPC_FAR *pctinfo);
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *GetTypeInfo )( 
            IDriverInfo __RPC_FAR * This,
            /* [in] */ UINT iTInfo,
            /* [in] */ LCID lcid,
            /* [out] */ ITypeInfo __RPC_FAR *__RPC_FAR *ppTInfo);
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *GetIDsOfNames )( 
            IDriverInfo __RPC_FAR * This,
            /* [in] */ REFIID riid,
            /* [size_is][in] */ LPOLESTR __RPC_FAR *rgszNames,
            /* [in] */ UINT cNames,
            /* [in] */ LCID lcid,
            /* [size_is][out] */ DISPID __RPC_FAR *rgDispId);
        
        /* [local] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *Invoke )( 
            IDriverInfo __RPC_FAR * This,
            /* [in] */ DISPID dispIdMember,
            /* [in] */ REFIID riid,
            /* [in] */ LCID lcid,
            /* [in] */ WORD wFlags,
            /* [out][in] */ DISPPARAMS __RPC_FAR *pDispParams,
            /* [out] */ VARIANT __RPC_FAR *pVarResult,
            /* [out] */ EXCEPINFO __RPC_FAR *pExcepInfo,
            /* [out] */ UINT __RPC_FAR *puArgErr);
        
        /* [helpstring][propget][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *get_DriverName )( 
            IDriverInfo __RPC_FAR * This,
            /* [retval][out] */ BSTR __RPC_FAR *pVal);
        
        /* [helpstring][propput][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *put_DriverName )( 
            IDriverInfo __RPC_FAR * This,
            /* [in] */ BSTR newVal);
        
        END_INTERFACE
    } IDriverInfoVtbl;

    interface IDriverInfo
    {
        CONST_VTBL struct IDriverInfoVtbl __RPC_FAR *lpVtbl;
    };

    

#ifdef COBJMACROS


#define IDriverInfo_QueryInterface(This,riid,ppvObject)	\
    (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)

#define IDriverInfo_AddRef(This)	\
    (This)->lpVtbl -> AddRef(This)

#define IDriverInfo_Release(This)	\
    (This)->lpVtbl -> Release(This)


#define IDriverInfo_GetTypeInfoCount(This,pctinfo)	\
    (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)

#define IDriverInfo_GetTypeInfo(This,iTInfo,lcid,ppTInfo)	\
    (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)

#define IDriverInfo_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)	\
    (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)

#define IDriverInfo_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)	\
    (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)


#define IDriverInfo_get_DriverName(This,pVal)	\
    (This)->lpVtbl -> get_DriverName(This,pVal)

#define IDriverInfo_put_DriverName(This,newVal)	\
    (This)->lpVtbl -> put_DriverName(This,newVal)

#endif /* COBJMACROS */


#endif 	/* C style interface */



/* [helpstring][propget][id] */ HRESULT STDMETHODCALLTYPE IDriverInfo_get_DriverName_Proxy( 
    IDriverInfo __RPC_FAR * This,
    /* [retval][out] */ BSTR __RPC_FAR *pVal);


void __RPC_STUB IDriverInfo_get_DriverName_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][propput][id] */ HRESULT STDMETHODCALLTYPE IDriverInfo_put_DriverName_Proxy( 
    IDriverInfo __RPC_FAR * This,
    /* [in] */ BSTR newVal);


void __RPC_STUB IDriverInfo_put_DriverName_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);



#endif 	/* __IDriverInfo_INTERFACE_DEFINED__ */


#ifndef __ICar_INTERFACE_DEFINED__
#define __ICar_INTERFACE_DEFINED__

/* interface ICar */
/* [unique][helpstring][dual][uuid][object] */ 


EXTERN_C const IID IID_ICar;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("A8E01A32-0300-402A-B1EC-ADCD2DC526B4")
    ICar : public IDispatch
    {
    public:
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE SpeedUp( 
            /* [in] */ int delta) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE GetCurSpeed( 
            /* [retval][out] */ int __RPC_FAR *currSp) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE GetEngine( 
            /* [retval][out] */ IEngine __RPC_FAR *__RPC_FAR *pEngine) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE GetCarType( 
            /* [retval][out] */ CarType __RPC_FAR *ct) = 0;
        
    };
    
#else 	/* C style interface */

    typedef struct ICarVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *QueryInterface )( 
            ICar __RPC_FAR * This,
            /* [in] */ REFIID riid,
            /* [iid_is][out] */ void __RPC_FAR *__RPC_FAR *ppvObject);
        
        ULONG ( STDMETHODCALLTYPE __RPC_FAR *AddRef )( 
            ICar __RPC_FAR * This);
        
        ULONG ( STDMETHODCALLTYPE __RPC_FAR *Release )( 
            ICar __RPC_FAR * This);
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *GetTypeInfoCount )( 
            ICar __RPC_FAR * This,
            /* [out] */ UINT __RPC_FAR *pctinfo);
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *GetTypeInfo )( 
            ICar __RPC_FAR * This,
            /* [in] */ UINT iTInfo,
            /* [in] */ LCID lcid,
            /* [out] */ ITypeInfo __RPC_FAR *__RPC_FAR *ppTInfo);
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *GetIDsOfNames )( 
            ICar __RPC_FAR * This,
            /* [in] */ REFIID riid,
            /* [size_is][in] */ LPOLESTR __RPC_FAR *rgszNames,
            /* [in] */ UINT cNames,
            /* [in] */ LCID lcid,
            /* [size_is][out] */ DISPID __RPC_FAR *rgDispId);
        
        /* [local] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *Invoke )( 
            ICar __RPC_FAR * This,
            /* [in] */ DISPID dispIdMember,
            /* [in] */ REFIID riid,
            /* [in] */ LCID lcid,
            /* [in] */ WORD wFlags,
            /* [out][in] */ DISPPARAMS __RPC_FAR *pDispParams,
            /* [out] */ VARIANT __RPC_FAR *pVarResult,
            /* [out] */ EXCEPINFO __RPC_FAR *pExcepInfo,
            /* [out] */ UINT __RPC_FAR *puArgErr);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *SpeedUp )( 
            ICar __RPC_FAR * This,
            /* [in] */ int delta);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *GetCurSpeed )( 
            ICar __RPC_FAR * This,
            /* [retval][out] */ int __RPC_FAR *currSp);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *GetEngine )( 
            ICar __RPC_FAR * This,
            /* [retval][out] */ IEngine __RPC_FAR *__RPC_FAR *pEngine);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *GetCarType )( 
            ICar __RPC_FAR * This,
            /* [retval][out] */ CarType __RPC_FAR *ct);
        
        END_INTERFACE
    } ICarVtbl;

    interface ICar
    {
        CONST_VTBL struct ICarVtbl __RPC_FAR *lpVtbl;
    };

    

#ifdef COBJMACROS


#define ICar_QueryInterface(This,riid,ppvObject)	\
    (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)

#define ICar_AddRef(This)	\
    (This)->lpVtbl -> AddRef(This)

#define ICar_Release(This)	\
    (This)->lpVtbl -> Release(This)


#define ICar_GetTypeInfoCount(This,pctinfo)	\
    (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)

#define ICar_GetTypeInfo(This,iTInfo,lcid,ppTInfo)	\
    (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)

#define ICar_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)	\
    (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)

#define ICar_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)	\
    (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)


#define ICar_SpeedUp(This,delta)	\
    (This)->lpVtbl -> SpeedUp(This,delta)

#define ICar_GetCurSpeed(This,currSp)	\
    (This)->lpVtbl -> GetCurSpeed(This,currSp)

#define ICar_GetEngine(This,pEngine)	\
    (This)->lpVtbl -> GetEngine(This,pEngine)

#define ICar_GetCarType(This,ct)	\
    (This)->lpVtbl -> GetCarType(This,ct)

#endif /* COBJMACROS */


#endif 	/* C style interface */



/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ICar_SpeedUp_Proxy( 
    ICar __RPC_FAR * This,
    /* [in] */ int delta);


void __RPC_STUB ICar_SpeedUp_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ICar_GetCurSpeed_Proxy( 
    ICar __RPC_FAR * This,
    /* [retval][out] */ int __RPC_FAR *currSp);


void __RPC_STUB ICar_GetCurSpeed_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ICar_GetEngine_Proxy( 
    ICar __RPC_FAR * This,
    /* [retval][out] */ IEngine __RPC_FAR *__RPC_FAR *pEngine);


void __RPC_STUB ICar_GetEngine_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ICar_GetCarType_Proxy( 
    ICar __RPC_FAR * This,
    /* [retval][out] */ CarType __RPC_FAR *ct);


void __RPC_STUB ICar_GetCarType_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);



#endif 	/* __ICar_INTERFACE_DEFINED__ */


#ifndef __IParams_INTERFACE_DEFINED__
#define __IParams_INTERFACE_DEFINED__

/* interface IParams */
/* [uuid][object] */ 


EXTERN_C const IID IID_IParams;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("2F79C93F-77D2-4797-BCCB-00D5378AB047")
    IParams : public IUnknown
    {
    public:
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE OnlyInParams( 
            /* [in] */ int x,
            /* [in] */ int y) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE OnlyOutParams( 
            /* [out] */ int __RPC_FAR *x,
            /* [out] */ int __RPC_FAR *y) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Retval( 
            /* [retval][out] */ int __RPC_FAR *answer) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE InAndOut( 
            /* [out][in] */ int __RPC_FAR *byRefParam) = 0;
        
    };
    
#else 	/* C style interface */

    typedef struct IParamsVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *QueryInterface )( 
            IParams __RPC_FAR * This,
            /* [in] */ REFIID riid,
            /* [iid_is][out] */ void __RPC_FAR *__RPC_FAR *ppvObject);
        
        ULONG ( STDMETHODCALLTYPE __RPC_FAR *AddRef )( 
            IParams __RPC_FAR * This);
        
        ULONG ( STDMETHODCALLTYPE __RPC_FAR *Release )( 
            IParams __RPC_FAR * This);
        
        /* [id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *OnlyInParams )( 
            IParams __RPC_FAR * This,
            /* [in] */ int x,
            /* [in] */ int y);
        
        /* [id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *OnlyOutParams )( 
            IParams __RPC_FAR * This,
            /* [out] */ int __RPC_FAR *x,
            /* [out] */ int __RPC_FAR *y);
        
        /* [id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *Retval )( 
            IParams __RPC_FAR * This,
            /* [retval][out] */ int __RPC_FAR *answer);
        
        /* [id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *InAndOut )( 
            IParams __RPC_FAR * This,
            /* [out][in] */ int __RPC_FAR *byRefParam);
        
        END_INTERFACE
    } IParamsVtbl;

    interface IParams
    {
        CONST_VTBL struct IParamsVtbl __RPC_FAR *lpVtbl;
    };

    

#ifdef COBJMACROS


#define IParams_QueryInterface(This,riid,ppvObject)	\
    (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)

#define IParams_AddRef(This)	\
    (This)->lpVtbl -> AddRef(This)

#define IParams_Release(This)	\
    (This)->lpVtbl -> Release(This)


#define IParams_OnlyInParams(This,x,y)	\
    (This)->lpVtbl -> OnlyInParams(This,x,y)

#define IParams_OnlyOutParams(This,x,y)	\
    (This)->lpVtbl -> OnlyOutParams(This,x,y)

#define IParams_Retval(This,answer)	\
    (This)->lpVtbl -> Retval(This,answer)

#define IParams_InAndOut(This,byRefParam)	\
    (This)->lpVtbl -> InAndOut(This,byRefParam)

#endif /* COBJMACROS */


#endif 	/* C style interface */



/* [id] */ HRESULT STDMETHODCALLTYPE IParams_OnlyInParams_Proxy( 
    IParams __RPC_FAR * This,
    /* [in] */ int x,
    /* [in] */ int y);


void __RPC_STUB IParams_OnlyInParams_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [id] */ HRESULT STDMETHODCALLTYPE IParams_OnlyOutParams_Proxy( 
    IParams __RPC_FAR * This,
    /* [out] */ int __RPC_FAR *x,
    /* [out] */ int __RPC_FAR *y);


void __RPC_STUB IParams_OnlyOutParams_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [id] */ HRESULT STDMETHODCALLTYPE IParams_Retval_Proxy( 
    IParams __RPC_FAR * This,
    /* [retval][out] */ int __RPC_FAR *answer);


void __RPC_STUB IParams_Retval_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [id] */ HRESULT STDMETHODCALLTYPE IParams_InAndOut_Proxy( 
    IParams __RPC_FAR * This,
    /* [out][in] */ int __RPC_FAR *byRefParam);


void __RPC_STUB IParams_InAndOut_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);



#endif 	/* __IParams_INTERFACE_DEFINED__ */


#ifndef __ITurboEngine_INTERFACE_DEFINED__
#define __ITurboEngine_INTERFACE_DEFINED__

/* interface ITurboEngine */
/* [uuid][object] */ 


EXTERN_C const IID IID_ITurboEngine;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("5AC4FD17-C14E-44c1-B761-024D3E6E1A40")
    ITurboEngine : public IEngine
    {
    public:
        virtual HRESULT STDMETHODCALLTYPE PowerBoost( void) = 0;
        
    };
    
#else 	/* C style interface */

    typedef struct ITurboEngineVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *QueryInterface )( 
            ITurboEngine __RPC_FAR * This,
            /* [in] */ REFIID riid,
            /* [iid_is][out] */ void __RPC_FAR *__RPC_FAR *ppvObject);
        
        ULONG ( STDMETHODCALLTYPE __RPC_FAR *AddRef )( 
            ITurboEngine __RPC_FAR * This);
        
        ULONG ( STDMETHODCALLTYPE __RPC_FAR *Release )( 
            ITurboEngine __RPC_FAR * This);
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *GetTypeInfoCount )( 
            ITurboEngine __RPC_FAR * This,
            /* [out] */ UINT __RPC_FAR *pctinfo);
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *GetTypeInfo )( 
            ITurboEngine __RPC_FAR * This,
            /* [in] */ UINT iTInfo,
            /* [in] */ LCID lcid,
            /* [out] */ ITypeInfo __RPC_FAR *__RPC_FAR *ppTInfo);
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *GetIDsOfNames )( 
            ITurboEngine __RPC_FAR * This,
            /* [in] */ REFIID riid,
            /* [size_is][in] */ LPOLESTR __RPC_FAR *rgszNames,
            /* [in] */ UINT cNames,
            /* [in] */ LCID lcid,
            /* [size_is][out] */ DISPID __RPC_FAR *rgDispId);
        
        /* [local] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *Invoke )( 
            ITurboEngine __RPC_FAR * This,
            /* [in] */ DISPID dispIdMember,
            /* [in] */ REFIID riid,
            /* [in] */ LCID lcid,
            /* [in] */ WORD wFlags,
            /* [out][in] */ DISPPARAMS __RPC_FAR *pDispParams,
            /* [out] */ VARIANT __RPC_FAR *pVarResult,
            /* [out] */ EXCEPINFO __RPC_FAR *pExcepInfo,
            /* [out] */ UINT __RPC_FAR *puArgErr);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *GetCylinders )( 
            ITurboEngine __RPC_FAR * This,
            /* [retval][out] */ VARIANT __RPC_FAR *arCylinders);
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *PowerBoost )( 
            ITurboEngine __RPC_FAR * This);
        
        END_INTERFACE
    } ITurboEngineVtbl;

    interface ITurboEngine
    {
        CONST_VTBL struct ITurboEngineVtbl __RPC_FAR *lpVtbl;
    };

    

#ifdef COBJMACROS


#define ITurboEngine_QueryInterface(This,riid,ppvObject)	\
    (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)

#define ITurboEngine_AddRef(This)	\
    (This)->lpVtbl -> AddRef(This)

#define ITurboEngine_Release(This)	\
    (This)->lpVtbl -> Release(This)


#define ITurboEngine_GetTypeInfoCount(This,pctinfo)	\
    (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)

#define ITurboEngine_GetTypeInfo(This,iTInfo,lcid,ppTInfo)	\
    (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)

#define ITurboEngine_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)	\
    (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)

#define ITurboEngine_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)	\
    (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)


#define ITurboEngine_GetCylinders(This,arCylinders)	\
    (This)->lpVtbl -> GetCylinders(This,arCylinders)


#define ITurboEngine_PowerBoost(This)	\
    (This)->lpVtbl -> PowerBoost(This)

#endif /* COBJMACROS */


#endif 	/* C style interface */



HRESULT STDMETHODCALLTYPE ITurboEngine_PowerBoost_Proxy( 
    ITurboEngine __RPC_FAR * This);


void __RPC_STUB ITurboEngine_PowerBoost_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);



#endif 	/* __ITurboEngine_INTERFACE_DEFINED__ */



#ifndef __CLASSICATLCOMSERVERLib_LIBRARY_DEFINED__
#define __CLASSICATLCOMSERVERLib_LIBRARY_DEFINED__

/* library CLASSICATLCOMSERVERLib */
/* [helpstring][version][uuid] */ 


EXTERN_C const IID LIBID_CLASSICATLCOMSERVERLib;

#ifndef ___ICarEvents_DISPINTERFACE_DEFINED__
#define ___ICarEvents_DISPINTERFACE_DEFINED__

/* dispinterface _ICarEvents */
/* [helpstring][uuid] */ 


EXTERN_C const IID DIID__ICarEvents;

#if defined(__cplusplus) && !defined(CINTERFACE)

    MIDL_INTERFACE("E88DA278-AD04-407F-9BBB-D8C00AFE7984")
    _ICarEvents : public IDispatch
    {
    };
    
#else 	/* C style interface */

    typedef struct _ICarEventsVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *QueryInterface )( 
            _ICarEvents __RPC_FAR * This,
            /* [in] */ REFIID riid,
            /* [iid_is][out] */ void __RPC_FAR *__RPC_FAR *ppvObject);
        
        ULONG ( STDMETHODCALLTYPE __RPC_FAR *AddRef )( 
            _ICarEvents __RPC_FAR * This);
        
        ULONG ( STDMETHODCALLTYPE __RPC_FAR *Release )( 
            _ICarEvents __RPC_FAR * This);
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *GetTypeInfoCount )( 
            _ICarEvents __RPC_FAR * This,
            /* [out] */ UINT __RPC_FAR *pctinfo);
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *GetTypeInfo )( 
            _ICarEvents __RPC_FAR * This,
            /* [in] */ UINT iTInfo,
            /* [in] */ LCID lcid,
            /* [out] */ ITypeInfo __RPC_FAR *__RPC_FAR *ppTInfo);
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *GetIDsOfNames )( 
            _ICarEvents __RPC_FAR * This,
            /* [in] */ REFIID riid,
            /* [size_is][in] */ LPOLESTR __RPC_FAR *rgszNames,
            /* [in] */ UINT cNames,
            /* [in] */ LCID lcid,
            /* [size_is][out] */ DISPID __RPC_FAR *rgDispId);
        
        /* [local] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *Invoke )( 
            _ICarEvents __RPC_FAR * This,
            /* [in] */ DISPID dispIdMember,
            /* [in] */ REFIID riid,
            /* [in] */ LCID lcid,
            /* [in] */ WORD wFlags,
            /* [out][in] */ DISPPARAMS __RPC_FAR *pDispParams,
            /* [out] */ VARIANT __RPC_FAR *pVarResult,
            /* [out] */ EXCEPINFO __RPC_FAR *pExcepInfo,
            /* [out] */ UINT __RPC_FAR *puArgErr);
        
        END_INTERFACE
    } _ICarEventsVtbl;

    interface _ICarEvents
    {
        CONST_VTBL struct _ICarEventsVtbl __RPC_FAR *lpVtbl;
    };

    

#ifdef COBJMACROS


#define _ICarEvents_QueryInterface(This,riid,ppvObject)	\
    (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)

#define _ICarEvents_AddRef(This)	\
    (This)->lpVtbl -> AddRef(This)

#define _ICarEvents_Release(This)	\
    (This)->lpVtbl -> Release(This)


#define _ICarEvents_GetTypeInfoCount(This,pctinfo)	\
    (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)

#define _ICarEvents_GetTypeInfo(This,iTInfo,lcid,ppTInfo)	\
    (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)

#define _ICarEvents_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)	\
    (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)

#define _ICarEvents_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)	\
    (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)

#endif /* COBJMACROS */


#endif 	/* C style interface */


#endif 	/* ___ICarEvents_DISPINTERFACE_DEFINED__ */


EXTERN_C const CLSID CLSID_CoCar;

#ifdef __cplusplus

class DECLSPEC_UUID("8FB4E170-A7E0-4F46-8508-DFFD7DA1D669")
CoCar;
#endif

EXTERN_C const CLSID CLSID_CoEngine;

#ifdef __cplusplus

class DECLSPEC_UUID("32C07E17-F966-4EFD-B301-9729FE2D60B5")
CoEngine;
#endif
#endif /* __CLASSICATLCOMSERVERLib_LIBRARY_DEFINED__ */

/* Additional Prototypes for ALL interfaces */

unsigned long             __RPC_USER  BSTR_UserSize(     unsigned long __RPC_FAR *, unsigned long            , BSTR __RPC_FAR * ); 
unsigned char __RPC_FAR * __RPC_USER  BSTR_UserMarshal(  unsigned long __RPC_FAR *, unsigned char __RPC_FAR *, BSTR __RPC_FAR * ); 
unsigned char __RPC_FAR * __RPC_USER  BSTR_UserUnmarshal(unsigned long __RPC_FAR *, unsigned char __RPC_FAR *, BSTR __RPC_FAR * ); 
void                      __RPC_USER  BSTR_UserFree(     unsigned long __RPC_FAR *, BSTR __RPC_FAR * ); 

unsigned long             __RPC_USER  VARIANT_UserSize(     unsigned long __RPC_FAR *, unsigned long            , VARIANT __RPC_FAR * ); 
unsigned char __RPC_FAR * __RPC_USER  VARIANT_UserMarshal(  unsigned long __RPC_FAR *, unsigned char __RPC_FAR *, VARIANT __RPC_FAR * ); 
unsigned char __RPC_FAR * __RPC_USER  VARIANT_UserUnmarshal(unsigned long __RPC_FAR *, unsigned char __RPC_FAR *, VARIANT __RPC_FAR * ); 
void                      __RPC_USER  VARIANT_UserFree(     unsigned long __RPC_FAR *, VARIANT __RPC_FAR * ); 

/* end of Additional Prototypes */

#ifdef __cplusplus
}
#endif

#endif
