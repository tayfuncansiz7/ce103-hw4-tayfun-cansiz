#include "ce103-hw4-c-dll.h"

__declspec(dllexport) int ce103_fibonacciNumber(int fiIndex)
{
	fiIndex = fiIndex - 1;
	//First, let's define our integers.
	int t1 = 0, y1 = 1, nextTerm = 0;
	int returnNumber;
	//This if statement implicitly checks "is not 0", so we reverse that to mean "is 0".
	if (fiIndex <= 0)
	{
		// if index is lower than 1 function will return 0
		return 0;
	}
	//I used "for" because there are repetitive processes here.
	//In this part, if i=1 and i<= fiIndex, the following is done.
	for (int i = 1; i <= fiIndex; ++i)
	{
		t1 = y1;
		y1 = nextTerm;
		nextTerm = t1 + y1;
		returnNumber = nextTerm;
		//returnnumber or if the nextTerm is less than 0
		if (returnNumber < 0)
		{
			//if index is higher than 46 function will return -2 
			return -2;
		}

	}
	//fiIndex' th fibonacci number
	return returnNumber;
}

__declspec(dllexport) char* ce103_strrev(char* fiStr)
{
	//We are assigning the i and j variables.
	int i, j = ce103_strlen(fiStr) - 1, ch;
	//The char variable is used to hold letters or names.
	for (i = 0; i < j; i++, j--) {
		//Local variables are used in variables defined in functions.
		//In this section, I defined the fiStr[i] parameter to the ch local variable. This parameter I defined will give me a return value.
		ch = fiStr[i];
		fiStr[i] = fiStr[j];
		fiStr[j] = ch;
	}
	//The return value of the reverse of the string you typed.
	return fiStr;
}

__declspec(dllexport) int ce103_strlen(const char* fiStr)
{
	//We assign an initial value to the count variable.
	//If count is not initialized, our loop will run incorrectly.
	int count = 0;
	//'\0' is a character literal. In C, it is implemented as int, so, it's the same as 0
	//Null characters are used. The variable '\0' is the last term defined for the fiStr char.
	while (fiStr[count] != '\0')
		count++;
	//Return value of length found
	return count;
}

__declspec(dllexport) char* ce103_strcat(char* fiDest, char* fiSrc)
{
	/*The variables i and j are defined.*/
	int i = ce103_strlen(fiDest), j = 0;
	/*fiSrc non-zero condition.*/
	/*i and j are incremented by 1*/
	while (fiSrc[j] != '\0')
	{
		fiDest[i] = fiSrc[j];
		i++;
		j++;
	}
	fiDest[i] = '\0';
	/*declaring the end of the string*/
	return fiDest;
}

__declspec(dllexport) int ce103_strcmp(const char* fiLhs, const char* fiRhs)
{
	//Let's assign the variable i.
	int i;

	for (i = 0; fiLhs[i] == fiRhs[i]; i++) {
		//if fiLhs[i] is equal to NULL, our return value is 0.
		if (fiLhs[i] == '\0')
			return 0;
	}
	if ((unsigned char)fiLhs[i] < (unsigned char)fiRhs[i])
		//if our fiLhs[i] char is less than our fiRhs[i] char, our return value is -1 or 1.
		return -1;
	else
		return 1;
}

__declspec(dllexport) char* ce103_strcpy(char* foDestination, const char* fiSource)
{
	// return if no memory is allocated to the destination
	/*if (foDestination == null) {
		return NULL;
	}*/

	// take a pointer pointing to the beginning of the destination string
	char* ptr = foDestination;
	char* x = fiSource;

	// copy the C-string pointed by source into the array
	// pointed by destination
	//if the pointer fiSource is equal to NULL
	while (*x != '\0')
	{
		//The pointer we send to foDestination is equal to the pointer we send to fiSource.
		//This equality happens thanks to the code we wrote in the while loop.
		*ptr = *x;
		ptr++;
		x++;
	}

	// include the terminating null character
	//if the pointer foDestination is  equal to NULL
	*ptr = '\0';

	// the destination is returned by standard `strcpy()`
	//it returns pointer to the destination array where the content is to be copied.
	return foDestination;
}

__declspec(dllexport) void ce103_hex2bin(char* fiHex, int fiHexLen, unsigned char* foBin)
{
	/*two variables defined in one line*/
	int x, y;

	for (;;) {
		x = *fiHex++; if (x == 0) break;
		/*If length of the input string is less than the fiHexLen,remaining bytes is not filled.*/
		if (x > 96) x -= 87;
		else if (x > 64) x -= 55;
		else x -= 48;
		y = *fiHex++; if (y == 0) { *foBin = x << 4; break; }
		/*If odd number of characters processed, last nibble is padded with 0*/
		if (y > 96) y -= 87;
		else if (y > 64) y -= 55;
		else y -= 48;
		*foBin++ = (x << 4) | y;
	}
	return fiHex;
}

__declspec(dllexport) void ce103_bin2hex(unsigned char* fiBin, int fiBinLen, char* foHex)
{
	int x, y, * end = fiBin + fiBinLen;
	/*We set our condition for fibin < end.*/
	while (fiBin < end) {
		x = *(fiBin++);
		y = x >> 4;
		*(foHex++) = y + (y > 9 ? 55 : 48);
		y = x & 15;
		*(foHex++) = y + (y > 9 ? 55 : 48);
	}
	*foHex = 0;

	return fiBin;
}
