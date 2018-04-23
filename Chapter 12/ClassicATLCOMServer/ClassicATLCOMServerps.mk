
ClassicATLCOMServerps.dll: dlldata.obj ClassicATLCOMServer_p.obj ClassicATLCOMServer_i.obj
	link /dll /out:ClassicATLCOMServerps.dll /def:ClassicATLCOMServerps.def /entry:DllMain dlldata.obj ClassicATLCOMServer_p.obj ClassicATLCOMServer_i.obj \
		kernel32.lib rpcndr.lib rpcns4.lib rpcrt4.lib oleaut32.lib uuid.lib \

.c.obj:
	cl /c /Ox /DWIN32 /D_WIN32_WINNT=0x0400 /DREGISTER_PROXY_DLL \
		$<

clean:
	@del ClassicATLCOMServerps.dll
	@del ClassicATLCOMServerps.lib
	@del ClassicATLCOMServerps.exp
	@del dlldata.obj
	@del ClassicATLCOMServer_p.obj
	@del ClassicATLCOMServer_i.obj
