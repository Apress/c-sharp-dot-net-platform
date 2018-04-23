// CoEngine.cpp : Implementation of CCoEngine
#include "stdafx.h"
#include "ClassicATLCOMServer.h"
#include "CoEngine.h"

/////////////////////////////////////////////////////////////////////////////
// CCoEngine


STDMETHODIMP CCoEngine::GetCylinders(VARIANT *arCylinders)
{

	// Init and set the type of variant.
	VariantInit(arCylinders);
	arCylinders->vt = VT_ARRAY | VT_BSTR;

	SAFEARRAY *pSA;
	SAFEARRAYBOUND bounds = {4, 0};
	
	// Create the array.
	pSA = SafeArrayCreate(VT_BSTR, 1, &bounds);

	// Fill the array.
	BSTR *theStrings;
	SafeArrayAccessData(pSA, (void**)&theStrings);
		theStrings[0] = SysAllocString(L"Grinder");
		theStrings[1] = SysAllocString(L"Oily");
		theStrings[2] = SysAllocString(L"Thumper");
		theStrings[3] = SysAllocString(L"Crusher");
	SafeArrayUnaccessData(pSA);

	// Set return value.
	arCylinders->parray = pSA;
	
	return S_OK;
}
