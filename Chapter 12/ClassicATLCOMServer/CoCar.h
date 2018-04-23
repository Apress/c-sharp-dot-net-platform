// CoCar.h : Declaration of the CCoCar

#ifndef __COCAR_H_
#define __COCAR_H_

#include "resource.h"       // main symbols
#include "ClassicATLCOMServerCP.h"

/////////////////////////////////////////////////////////////////////////////
// CCoCar
class ATL_NO_VTABLE CCoCar : 
	public CComObjectRootEx<CComSingleThreadModel>,
	public CComCoClass<CCoCar, &CLSID_CoCar>,
	public ISupportErrorInfo,
	public IConnectionPointContainerImpl<CCoCar>,
	public IDispatchImpl<ICar, &IID_ICar, &LIBID_CLASSICATLCOMSERVERLib>,
	public CProxy_ICarEvents< CCoCar >,
	public IDispatchImpl<IDriverInfo, &IID_IDriverInfo, &LIBID_CLASSICATLCOMSERVERLib>
{
private:
	int curSpeed;
	int maxSpeed;
	bool dead;

public:
	CCoCar() : curSpeed(0), maxSpeed(200), dead(false), driverName("")
	{
	}

DECLARE_REGISTRY_RESOURCEID(IDR_COCAR)

DECLARE_PROTECT_FINAL_CONSTRUCT()

BEGIN_COM_MAP(CCoCar)
	COM_INTERFACE_ENTRY(ICar)
	COM_INTERFACE_ENTRY2(IDispatch, ICar)
	COM_INTERFACE_ENTRY(ISupportErrorInfo)
	COM_INTERFACE_ENTRY(IConnectionPointContainer)
	COM_INTERFACE_ENTRY_IMPL(IConnectionPointContainer)
	COM_INTERFACE_ENTRY(IDriverInfo)
END_COM_MAP()

BEGIN_CONNECTION_POINT_MAP(CCoCar)
	CONNECTION_POINT_ENTRY(DIID__ICarEvents)
END_CONNECTION_POINT_MAP()


// ISupportsErrorInfo
	STDMETHOD(InterfaceSupportsErrorInfo)(REFIID riid);

// ICar
public:
	STDMETHOD(GetCarType)(/*[out, retval]*/ CarType *ct);
	STDMETHOD(GetCurSpeed)(/*[out, retval]*/ int* currSp);
	STDMETHOD(GetEngine)(/*[out, retval]*/ IEngine** pEngine);
	STDMETHOD(SpeedUp)(/*[in]*/ int delta);

// IDriverInfo
	CComBSTR driverName;

	STDMETHOD(get_DriverName)(BSTR * pVal)
	{
		*pVal = driverName.Copy();
		
		return S_OK;
	}
	STDMETHOD(put_DriverName)(BSTR pVal)
	{
		driverName = pVal;

		return S_OK;
	}
};

#endif //__COCAR_H_
