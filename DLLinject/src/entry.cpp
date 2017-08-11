#include <stdio.h>  
#include <stdlib.h>  
#include <windows.h>  
#include <tlhelp32.h>  


extern "C" __declspec(dllexport) BOOL APIENTRY DllMain(HINSTANCE hinstDLL, DWORD fdwReason, LPVOID lpvReserved)
{
	//MessageBoxA(0, "I am a dll!", "DLL Message", MB_OK | MB_ICONINFORMATION);
	switch (fdwReason)
	{
	case DLL_PROCESS_ATTACH:
		// attach to process  
		// return FALSE to fail DLL load  
		MessageBoxA(0, "I am a dll!", "DLL Message", MB_OK | MB_ICONINFORMATION);
		break;

	case DLL_PROCESS_DETACH:
		// detach from process  
		break;

	case DLL_THREAD_ATTACH:
		// attach to thread  
		break;

	case DLL_THREAD_DETACH:
		// detach from thread  
		break;
	}
	return TRUE; // succesful  
}