FOR %%f in ("*.in.txt") DO (
	SETLOCAL EnableDelayedExpansion
    SET "file=%%f"
    joro.exe < "%%f" > "!file:.in.txt=.out.txt!"
)
