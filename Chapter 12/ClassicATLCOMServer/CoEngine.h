// CoEngine.h : Declaration of the CCoEngine

#ifndef __COENGINE_H_
#define __COENGINE_H_

#include "resource.h"       // main symbols

/////////////////////////////////////////////////////////////////////////////
// CCoEngine
class ATL_NO_VTABLE CCoEngine : 
	public CComObjectRootEx<CComSingleThreadModel>,
	public CComCoClass<CCoEngine, &CLSID_CoEngine>,
	public IDispatchImpl<IEngine, &IID_IEngine, &LIBID_CLASSICATLCOMSERVERLib>
{
public:
	CCoEngine()
	{
	}

DECLARE_REGISTRY_RESOURCEID(IDR_COENGINE)

DECLARE_PROTECT_FINAL_CONSTRUCT()

BEGIN_COM_MAP(CCoEngine)
	COM_INTERFACE_ENTRY(IDispatch)
	COM_INTERFACE_ENTRY(IEngine)
END_COM_MAP()

// IEngine
public:
	STDMETHOD(GetCylinders)(/*[out, retval]*/ VARIANT* arCylinders);
};

#endif //__COENGINE_H_
