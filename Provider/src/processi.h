#include <Windows.h>
#include <Psapi.h>

struct pinfo
{
	unsigned long pid;
	char* pname;
};
extern "C" __declspec(dllexport) pinfo* getProcesses(int *count);

extern "C" __declspec(dllexport) char* gggg(DWORD pid, int addr, int length);