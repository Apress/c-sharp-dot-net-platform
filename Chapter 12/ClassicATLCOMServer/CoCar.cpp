// CoCar.cpp : Implementation of CCoCar
#include "stdafx.h"
#include "ClassicATLCOMServer.h"
#include "CoCar.h"
#include "CoEngine.h"

/////////////////////////////////////////////////////////////////////////////
// CCoCar

STDMETHODIMP CCoCar::InterfaceSupportsErrorInfo(REFIID riid)
{
	static const IID* arr[] = 
	{
		&IID_ICar
	};
	for (int i=0; i < sizeof(arr) / sizeof(arr[0]); i++)
	{
		if (InlineIsEqualGUID(*arr[i],riid))
			return S_OK;
	}
	return S_FALSE;
}

STDMETHODIMP CCoCar::SpeedUp(int delta)
{
	// Add delta and check for event condition.
	curSpeed += delta;

	if(curSpeed >= maxSpeed && !dead)
	{
		CComBSTR msg("You are toast...");
		Fire_Exploded(msg.Detach());
		curSpeed = maxSpeed;
		dead = true;
	}

	return S_OK;
}

STDMETHODIMP CCoCar::GetEngine(IEngine **pEngine)
{
	// Create a CoEngine and then return the IEngine
	// interface to the client.

	CComObject<CCoEngine> *pEng;
	CComObject<CCoEngine>::CreateInstance(&pEng);
	pEng->QueryInterface(IID_IEngine, (void**)pEngine);

	return S_OK;
}

STDMETHODIMP CCoCar::GetCurSpeed(int *currSp)
{
	// Return speed but send error if dead.
	if(!dead)
	{
		*currSp = curSpeed;
		return S_OK;
	}
	else
	{
		*currSp = 0;
		Error("Sorry, this car has met it's maker");
		return E_FAIL;
	}
}

STDMETHODIMP CCoCar::GetCarType(CarType *ct)
{
	*ct = Colt;
	return S_OK;
}
