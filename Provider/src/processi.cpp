#pragma disable(warning:C4018)
#include "processi.h"
#include <stdio.h>

extern "C" __declspec(dllexport) pinfo* getProcesses(int *count){
	*count = 0;
	DWORD pids[1024], pcount;
	LPSTR pname;
	HANDLE handle;
	EnumProcesses(pids, sizeof(pids), &pcount);
	pcount = pcount / sizeof(DWORD);
	pinfo* src = new pinfo[pcount];
	for (int i = 0; i < pcount; i++){
		pname = new char[255];
		handle = OpenProcess(PROCESS_ALL_ACCESS, FALSE, pids[i]);
		if (handle == NULL) continue;
		if (GetProcessImageFileName(handle, pname, 255)){
			//if (GetModuleFileNameEx(handle, 0, pname, 255)){
			//if (*pname == '?') continue;
			pinfo* process = src + (*count)++;
			process->pid = pids[i];
			process->pname = pname;
		}
	}
	return src;
}

extern "C" __declspec(dllexport) char* gggg(DWORD pid, int addr, int length){
	const char *dllname = "C:\\Users\\Administrator\\Desktop\\GF\\Debug\\InjectModule.dll";
	int dlllength = strlen(dllname) + 1;
	HANDLE handle;
	LPVOID dllnameaddr;
	BOOL success;
	handle = OpenProcess(PROCESS_ALL_ACCESS | PROCESS_CREATE_THREAD | PROCESS_VM_OPERATION | PROCESS_VM_WRITE, FALSE, pid);
	dllnameaddr = VirtualAllocEx(handle, 0, dlllength, MEM_COMMIT, PAGE_EXECUTE_READWRITE);
	success = WriteProcessMemory(handle, dllnameaddr, dllname, dlllength, 0);

	char* chessdata = new char[dlllength];
	BOOL BBBB = ReadProcessMemory(handle, dllnameaddr, chessdata, dlllength, 0);
	if (BBBB){
		printf("123");
	}
	DWORD WORDSSS = GetLastError();
	LPTHREAD_START_ROUTINE ddd = (LPTHREAD_START_ROUTINE)LoadLibraryA;
	HANDLE hThreadHandle = CreateRemoteThread(handle, NULL, 0, ddd, dllnameaddr, 0, NULL);
	WORDSSS = GetLastError();
	WaitForSingleObject(hThreadHandle, INFINITE);
	return NULL;
}