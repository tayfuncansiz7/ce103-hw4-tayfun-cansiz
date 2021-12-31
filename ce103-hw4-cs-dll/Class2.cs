using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ce103_hw4_cs_dll
{
    public class Class2
    {
        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ce103_fibonacciNumber_cpp1(int fiIndex);

        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ce103_strrev_cpp1( char[] fiStr);

        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ce103_strlen_cpp1(string fiStr);

        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ce103_strcat_cpp1(char[] fiDest, char[] fiSrc);

        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ce103_strcmp_cpp1(string fiLhs, string fiRhs);

        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ce103_strcpy_cpp1(char[] foDestination, char[] fiSource);

        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ce103_hex2bin_cpp1(string fiHex, int fiHexLen, byte[] foBin);

        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ce103_bin2hex_cpp1([In] byte[] fiBin, int fiBinLen, [Out] char[] foHex);


        /**
        *
        *	  @name   fibonacciNumber (ce103_fibonacciNumber_cs_imported)
        *
        *	  @brief Fibonacci Number Calculator
        *
        *	  Calculates the fibonacci number in the given index and return as output
        *
        *	  @param  [in] fiIndex [\s int]  index of fibonacci number in the serie
        *
        *	  @retval [\s int] ce103_fibonacciNumber_cpp1
        **/
        public int ce103_fibonacciNumber_cs_imported(int fiIndex)
        {
            return ce103_fibonacciNumber_cpp1(fiIndex);
        }

       

        private static string PtrToStringUtf8(IntPtr ptrr) // aPtr is nul-terminated
        {
            if (ptrr == IntPtr.Zero)
                return "";
            int length = 0;
            while (System.Runtime.InteropServices.Marshal.ReadByte(ptrr, length) != 0)
                length++;
            if (length == 0)
                return "";
            byte[] array = new byte[length];
            System.Runtime.InteropServices.Marshal.Copy(ptrr, array, 0, length);
            return System.Text.Encoding.UTF8.GetString(array);
        }
        /**
           @name   strrev (ce103_strrev_cs_imported)

           @brief \s Reverse string

           Reverse given string

           @param [in] fiStr [\s string] The given string which is needed to be reversed.

           @retval [\s string] ce103_strrev_cpp1
        **/

        public string ce103_strrev_cs_imported(string fiStr)
        {

            var b = fiStr.ToCharArray();
            var c = new char[fiStr.Length+1];
            for (int i = 0; i < b.Length; i++)
            {
                c[i] = b[i];
            }
            c[fiStr.Length] = '\0';
            var x = ce103_strrev_cpp1(c); 
            return PtrToStringUtf8(x);
        }

        /**
	        @name   strlen (ce103_strlen_cs_imported)

	        @brief \s Get string length

            Get length of s string

	        Returns the length of the C sharp string str.

	        @param [in] fiStr [\s string] given string

	        @retval [\s int] ce103_strlen_cpp1
        **/
        public int ce103_strlen_cs_imported(string fiStr)
        {
            return ce103_strlen_cpp1(fiStr);
        }

        /**
            @name   strcat (ce103_strcat_cs_imported)

            @brief \s Concatenate strings

            Concatenate two strings

            @param  [in] fiDest [\s string] will be appended string

            @param  [in] fiSrc  [\s string] will be copy from this

            @retval [\s string] ce103_strcat_cpp1
        **/
        public string ce103_strcat_cs_imported(string fiDest, string fiSrc)
        {


            var h = fiDest.ToCharArray();
            var j = new char[fiDest.Length + 1];
            for (int i = 0; i < h.Length; i++)
            {
                j[i] = h[i];
            }
            j[fiDest.Length] = '\0';

            var s = fiSrc.ToCharArray();
            var p = new char[fiSrc.Length + 1];
            for (int i = 0; i <s.Length; i++)
            {
                p[i] = s[i];
            }
            p[fiSrc.Length] = '\0';





            var l = ce103_strcat_cpp1(j,p);
            return PtrToStringUtf8(l);
        }

        /**
            @name   strcmp (ce103_strcmp_cs_imported)

            @brief  \s Compare two strings

            Compare two strings

            @param  [in] fiLhs [\s string] string to compare

            @param  [in] fiRhs [\s string] string to compare

            @retval [\s int] ce103_strcmp_cpp1
        **/
        public int ce103_strcmp_cs_imported(string fiLhs, string fiRhs)
        {
            return ce103_strcmp_cpp1(fiLhs, fiRhs);
        }

        /**
            @name  strcpy (ce103_strcpy_cs_imported)

            @brief \s Copy string

            Copy string to another

            @param [out] foDestination	[\s string] destination string to copy

            @param [in]  fiSource		[\s string]	C sharp string to be copied.

            @retval [\s string] ce103_strcpy_cpp1
        **/
        public string ce103_strcpy_cs_imported(string foDestination, string fiSource)
        {
            var d = foDestination.ToCharArray();
            var n = new char[foDestination.Length + 1];
            for (int i = 0; i < d.Length; i++)
            {
                n[i] = d[i];
            }
            n[foDestination.Length] = '\0';

            var f = fiSource.ToCharArray();
            var u = new char[fiSource.Length + 1];
            for (int i = 0; i < f.Length; i++)
            {
                u[i] = f[i];
            }
            u[fiSource.Length] = '\0';

            var x = ce103_strcpy_cpp1(n, u);
            return PtrToStringUtf8(x);


        }

        /**
         * @name    hex2bin (ce103_hex2bin_cs_imported)
         * 
         * @brief   \s Hexadecimal string to byte array Conversion
         * 
         * Convert hex string to byte array
         *
         * @param   [in]  fiHex    [\s string] Ascii hex string.
         * 
         * @param   [in]  fiHexLen [\s int]     Ascii data length.
         * 
         * @param  [out]  foBin    [\s byte[]]   Convertion result as binary.
         **/
        public void ce103_hex2bin_cs_imported(string fiHex, int fiHexLen, byte[] foBin)
        {
            ce103_hex2bin_cpp1(fiHex, fiHexLen, foBin);
        }

        /**
        * @name    bin2hex (ce103_bin2hex_cs_imported)
        * 
        * @brief   \s Binary to Hexadecimal Conversion
        *
        * Unpacks alpha numeric value, Example: 0x12 0x34 = "1234".
        *
        * @param [in]  fiBin      [\s byte[]]    Binary data to be converted.
        * 
        * @param [in]  fiBinLen   [\s int]	 Binary data length.
        * 
        * @param [out] foHex      [\s char[]]	 Convertion result as ascii. Doubles the binary length.
        **/
        public void ce103_bin2hex_cs_imported([In] byte[] fiBin, int fiBinLen, [Out] char[] foHex)
        {
            ce103_bin2hex_cpp1(fiBin, fiBinLen, foHex);
        }
    }
}
