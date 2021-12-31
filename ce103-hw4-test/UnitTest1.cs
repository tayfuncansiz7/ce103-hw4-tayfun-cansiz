using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce103_hw4_cs_dll;
using System.Text;

namespace ce103_hw4_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ce103_fibonacciNumber_cs_test_1()
        {
            Class1 fibo = new Class1();
            int result = fibo.ce103_fibonacciNumber_cs1(12);
            Assert.AreEqual(result, 89);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_cs_imported_test_1()
        {
            Class2 fibo = new Class2();
            int result = fibo.ce103_fibonacciNumber_cs_imported(12);
            Assert.AreEqual(result, 89);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_importedcppcs_test_1()
        {
            Class1 fibo = new Class1();
            int result = fibo.ce103_fibonacciNumber_cs1(12);
            Class2 fiboo = new Class2();
            int result2 = fiboo.ce103_fibonacciNumber_cs_imported(12);
            Assert.AreEqual(result, result2);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_cs_test_2()
        {
            Class1 fibo = new Class1();
            int result = fibo.ce103_fibonacciNumber_cs1(34);
            Assert.AreEqual(result, 3524578);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_cs_imported_test_2()
        {
            Class2 fibo = new Class2();
            int result = fibo.ce103_fibonacciNumber_cs_imported(34);
            Assert.AreEqual(result, 3524578);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_importedcppcs_test_2()
        {
            Class1 fibo = new Class1();
            int result = fibo.ce103_fibonacciNumber_cs1(34);
            Class2 fiboo = new Class2();
            int result2 = fiboo.ce103_fibonacciNumber_cs_imported(34);
            Assert.AreEqual(result, result2);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_cs_test_3()
        {
            Class1 fibo = new Class1();
            int result = fibo.ce103_fibonacciNumber_cs1(3);
            Assert.AreEqual(result, 1);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_cs_imported_test_3()
        {
            Class2 fibo = new Class2();
            int result = fibo.ce103_fibonacciNumber_cs_imported(4);
            Assert.AreEqual(result, 2);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_importedcppcs_test_3()
        {
            Class1 fibo = new Class1();
            int result = fibo.ce103_fibonacciNumber_cs1(4);
            Class2 fiboo = new Class2();
            int result2 = fiboo.ce103_fibonacciNumber_cs_imported(4);
            Assert.AreEqual(result, result2);
        }
        [TestMethod]
        public void ce103_strrev_cs_test_1()
        {
            Class1 strrev = new Class1();
            Assert.AreEqual(strrev.ce103_strrev_cs1("School"), "loohcS");
        }
  
        [TestMethod]
        public void ce103_strrev_cs_test_2()
        {
            Class1 strrev = new Class1();
            Assert.AreEqual(strrev.ce103_strrev_cs1("New Lesson"), "nosseL weN");
        }
    
        [TestMethod]
        public void ce103_strrev_cs_test_3()
        {
            Class1 strrev = new Class1();
            Assert.AreEqual(strrev.ce103_strrev_cs1("HiTayfun"), "nufyaTiH");         
        }
     
        [TestMethod]
        public void ce103_strlen_cs_test_1()
        {
            Class1 strlen = new Class1();
            Assert.AreEqual(strlen.ce103_strlen_cs1("Java"), 4);
        }

        [TestMethod]
        public void ce103_strlen_cs_test_2()
        {
            Class1 strlen = new Class1();
            Assert.AreEqual(strlen.ce103_strlen_cs1("Fundamental Lessons"), 19);
        }
    
        [TestMethod]
        public void ce103_strlen_cs_test_3()
        {
            Class1 strlen = new Class1();
            Assert.AreEqual(strlen.ce103_strlen_cs1("Computer Simulation"), 19);
        }

        [TestMethod]
        public void ce103_strcat_cs_test_1()
        {
            Class1 strcat = new Class1();
            Assert.AreEqual(strcat.ce103_strcat_cs1("Hi","Mars"),"HiMars");
        }
  
        [TestMethod]
        public void ce103_strcat_cs_test_2()
        {
            Class1 strcat = new Class1();
            Assert.AreEqual(strcat.ce103_strcat_cs1("Rte","University"),"RteUniversity");
        }
 
        [TestMethod]
        public void ce103_strcat_cs_test_3()
        {
            Class1 strcat = new Class1();
            Assert.AreEqual(strcat.ce103_strcat_cs1("Hardware","System"),"HardwareSystem");
        }

        [TestMethod]
        public void ce103_strcmp_cs_test_1()
        {
            Class1 strcmp = new Class1();
            Assert.AreEqual(strcmp.ce103_strcmp_cs1("Computer", "Computer"), 0);
        }
 
        [TestMethod]
        public void ce103_strcmp_cs_test_2()
        {
            Class1 strcmp = new Class1();
            Assert.AreNotEqual(strcmp.ce103_strcmp_cs1("Computer", "Engineering"), 0);
        }

        [TestMethod]
        public void ce103_strcmp_cs_test_3()
        {
            Class1 strcmp = new Class1();
            Assert.AreNotEqual(strcmp.ce103_strcmp_cs1("Hello", "World"), 0);
        }
 
        [TestMethod]
        public void ce103_strcpy_cs_test_1()
        {
            Class1 strcpy = new Class1();
            Assert.AreEqual(strcpy.ce103_strcpy_cs1("Capital", "Ankara"), "Ankara");
        }
 
        [TestMethod]
        public void ce103_strcpy_cs_test_2()
        {
            Class1 strcpy = new Class1();
            Assert.AreEqual(strcpy.ce103_strcpy_cs1("Hardware", "Lessons"), "Lessons");
        }
 
        [TestMethod]
        public void ce103_strcpy_cs_test_3()
        {
            Class1 strcpy = new Class1();
            Assert.AreEqual(strcpy.ce103_strcpy_cs1("Bayburt", "Hi"), "Hi");
        }
     
        [TestMethod]
        public void ce103_strrev_cs_imported_test_1()
        {
            Class2 strrev = new Class2();
            Assert.AreEqual(strrev.ce103_strrev_cs_imported("School"), "loohcS");
        }
        [TestMethod]
        public void ce103_strrev_importedcppcs_test_1()
        {
            Class1 strrev = new Class1();
            Class2 Strrev = new Class2();
            Assert.AreEqual(strrev.ce103_strrev_cs1("School"), "loohcS", Strrev.ce103_strrev_cs_imported("School"), "loohcS");
        }
 
        [TestMethod]
        public void ce103_strrev_cs_imported_test_2()
        {
            Class2 strrev = new Class2();
            Assert.AreEqual(strrev.ce103_strrev_cs_imported("New Lesson"), "nosseL weN");
        }
        [TestMethod]
        public void ce103_strrev_importedcppcs_test_2()
        {
            Class1 strrev = new Class1();
            Class2 Strrev = new Class2();
            Assert.AreEqual(strrev.ce103_strrev_cs1("New Lesson"), "nosseL weN", Strrev.ce103_strrev_cs_imported("New Lesson"), "nosseL weN");
        }
     
        [TestMethod]
        public void ce103_strrev_cs_imported_test_3()
        {
            Class2 strrev = new Class2();
            Assert.AreEqual(strrev.ce103_strrev_cs_imported("HiTayfun"), "nufyaTiH");
        }
        [TestMethod]
        public void ce103_strrev_importedcppcs_test_3()
        {
            Class1 strrev = new Class1();
            Class2 Strrev = new Class2();
            Assert.AreEqual(strrev.ce103_strrev_cs1("HiTayfun"), "nufyaTiH", Strrev.ce103_strrev_cs_imported("HiTayfun"), "nufyaTiH");
        }
       
        [TestMethod]
        public void ce103_strcat_cs_imported_test_1()
        {
            Class2 strcat = new Class2();
            Assert.AreEqual(strcat.ce103_strcat_cs_imported("Hi", "Mars"), "HiMars");
        }
        [TestMethod]
        public void ce103_strcat_importedcppcs_test_1()
        {
            Class1 strcat = new Class1();
            Class2 Strcat = new Class2();
            Assert.AreEqual(strcat.ce103_strcat_cs1("Hi", "Mars"), "HiMars", Strcat.ce103_strcat_cs_imported("Hi", "Mars"), "HiMars");
        }
      
        [TestMethod]
        public void ce103_strcat_cs_imported_test_2()
        {
            Class2 strcat = new Class2();
            Assert.AreEqual(strcat.ce103_strcat_cs_imported("Rte", "University"), "RteUniversity");
        }
        [TestMethod]
        public void ce103_strcat_importedcppcs_test_2()
        {
            Class1 strcat = new Class1();
            Class2 Strcat = new Class2();
            Assert.AreEqual(strcat.ce103_strcat_cs1("Rte", "University"), "RteUniversity", Strcat.ce103_strcat_cs_imported("Rte", "University"), "RteUniversity");
        }
        
        [TestMethod]
        public void ce103_strcat_cs_imported_test_3()
        {
            Class2 strcat = new Class2();
            Assert.AreEqual(strcat.ce103_strcat_cs_imported("Hardware", "System"), "HardwareSystem");
        }
        [TestMethod]
        public void ce103_strcat_importedcppcs_test_3()
        {
            Class1 strcat = new Class1();
            Class2 Strcat = new Class2();
            Assert.AreEqual(strcat.ce103_strcat_cs1("Hardware", "System"), "HardwareSystem", Strcat.ce103_strcat_cs_imported("Hardware", "System"), "HardwareSystem");
        }
    
        [TestMethod]
        public void ce103_strlen_cs_imported_test_1()
        {
            Class2 strlen = new Class2();
            Assert.AreEqual(strlen.ce103_strlen_cs_imported("Java"), 4);
        }
        [TestMethod]
        public void ce103_strlen_importedcppcs_test_1()
        {
            Class1 strlen = new Class1();
            Class2 Strlen = new Class2();
            Assert.AreEqual(strlen.ce103_strlen_cs1("Java"), 4, Strlen.ce103_strlen_cs_imported("Java"));
        }
    
        [TestMethod]
        public void ce103_strlen_cs_imported_test_2()
        {
            Class2 strlen = new Class2();
            Assert.AreEqual(strlen.ce103_strlen_cs_imported("Fundamental Lessons"), 19);
        }
        [TestMethod]
        public void ce103_strlen_importedcppcs_test_2()
        {
            Class1 strlen = new Class1();
            Class2 Strlen = new Class2();
            Assert.AreEqual(strlen.ce103_strlen_cs1("Fundamental Lessons"), 19, Strlen.ce103_strlen_cs_imported("Fundamental Lessons"));
        }
  
        [TestMethod]
        public void ce103_strlen_cs_imported_test_3()
        {
            Class2 strlen = new Class2();
            Assert.AreEqual(strlen.ce103_strlen_cs_imported("Computer Simulation"), 19);
        }
        [TestMethod]
        public void ce103_strlen_importedcppcs_test_3()
        {
            Class1 strlen = new Class1();
            Class2 Strlen = new Class2();
            Assert.AreEqual(strlen.ce103_strlen_cs1("Computer Simulation"), 19, Strlen.ce103_strlen_cs_imported("Computer Simulation"));
        }

        [TestMethod]
        public void ce103_strcmp_cs_imported_test_1()
        {
            Class2 strcmp = new Class2();
            Assert.AreEqual(strcmp.ce103_strcmp_cs_imported("Computer", "Computer"), 0);
        }
        [TestMethod]
        public void ce103_strcmp_importedcppcs_test_1()
        {
            Class1 strcmp = new Class1();
            Class2 Strcmp = new Class2();
            Assert.AreEqual(strcmp.ce103_strcmp_cs1("Computer", "Computer"), 0, Strcmp.ce103_strcmp_cs_imported("Computer", "Computer"));
        }
     
        [TestMethod]
        public void ce103_strcmp_cs_imported_test_2()
        {
            Class2 strcmp = new Class2();
            Assert.AreNotEqual(strcmp.ce103_strcmp_cs_imported("Computer", "Engineering"), 0);
        }
        [TestMethod]
        public void ce103_strcmp_importedcppcs_test_2()
        {
            Class1 strcmp = new Class1();
            Class2 Strcmp = new Class2();
            Assert.AreNotEqual(strcmp.ce103_strcmp_cs1("Computer", "Engineering"), 0, Strcmp.ce103_strcmp_cs_imported("Computer", "Engineering"));
        }
 
        [TestMethod]
        public void ce103_strcmp_cs_imported_test_3()
        {
            Class2 strcmp = new Class2();
            Assert.AreNotEqual(strcmp.ce103_strcmp_cs_imported("Hello", "World"), 0);
        }
        [TestMethod]
        public void ce103_strcmp_importedcppcs_test_3()
        {
            Class1 strcmp = new Class1();
            Class2 Strcmp = new Class2();
            Assert.AreNotEqual(strcmp.ce103_strcmp_cs1("Hello", "World"), 0, Strcmp.ce103_strcmp_cs_imported("Hello", "World"));
        }

        [TestMethod]
        public void ce103_strcpy_cs_imported_test_1()
        {
            Class2 strcpy = new Class2();
            Assert.AreEqual(strcpy.ce103_strcpy_cs_imported("Capital", "Ankara"), "Ankara");
        }
        [TestMethod]
        public void ce103_strcpy_importedcppcs_test_1()
        {
            Class1 strcpy = new Class1();
            Class2 Strcpy = new Class2();
            Assert.AreEqual(strcpy.ce103_strcpy_cs1("Capital", "Ankara"), "Ankara", Strcpy.ce103_strcpy_cs_imported("Capital", "Ankara"), "Ankara");
        }
 
        [TestMethod]
        public void ce103_strcpy_cs_imported_test_2()
        {
            Class2 strcpy = new Class2();
            Assert.AreEqual(strcpy.ce103_strcpy_cs_imported("Hardware", "Lessons"), "Lessons");
        }
        [TestMethod]
        public void ce103_strcpy_importedcppcs_test_2()
        {
            Class1 strcpy = new Class1();
            Class2 Strcpy = new Class2();
            Assert.AreEqual(strcpy.ce103_strcpy_cs1("Hardware", "Lessons"), "Lessons", Strcpy.ce103_strcpy_cs_imported("Hardware", "Lessons"), "Lessons");
        }
     
        [TestMethod]
        public void ce103_strcpy_cs_imported_test_3()
        {
            Class2 strcpy = new Class2();
            Assert.AreEqual(strcpy.ce103_strcpy_cs_imported("Bayburt", "Hi"), "Hi");
        }
        [TestMethod]
        public void ce103_strcpy_importedcppcs_test_3()
        {
            Class1 strcpy = new Class1();
            Class2 Strcpy = new Class2();
            Assert.AreEqual(strcpy.ce103_strcpy_cs1("Bayburt", "Hi"), "Hi", Strcpy.ce103_strcpy_cs_imported("Bayburt", "Hi"), "Hi");
        }
        [TestMethod]
        public void ce103_bin2hex_cs_test1()
        {
            Class1 bin2hex = new Class1();
            byte[] bin = { 0xDD, 0xFC, 0xAF, 0x58, 0x34, 0x53 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'D', 'D', 'F', 'C', 'A', 'F', '5', '8', '3', '4', '5', '3' };

            bin2hex.ce103_bin2hex_cs1(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_imported_test1()
        {
            Class2 imported = new Class2();
            byte[] bin = { 0xFB, 0xFB, 0xFB, 0xFB, 0xFB, 0xFB, 0xFB, 0xFB };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'F', 'B', 'F', 'B', 'F', 'B', 'F', 'B', 'F', 'B', 'F', 'B', 'F', 'B', 'F', 'B' };

            imported.ce103_bin2hex_cs_imported(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_importedcppcs_test1()
        {
            Class1 bin2hex = new Class1();
            Class2 imported = new Class2();
            byte[] bin = { 0xDD, 0xFC, 0xAF, 0x58, 0x34, 0x53 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring1 = new char[bin.Length * 2];
            bin2hex.ce103_bin2hex_cs1(bin, bin.Length, hexstring1);
            imported.ce103_bin2hex_cs_imported(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring1, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_cs_test2()
        {
            Class1 bin2hex = new Class1();
            byte[] bin = { 0x33, 0x33, 0x33, 0x33, 0x33 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { '3', '3', '3', '3', '3', '3', '3', '3', '3', '3' };

            bin2hex.ce103_bin2hex_cs1(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_imported_test2()
        {
            Class2 imported = new Class2();
            byte[] bin = { 0x33, 0x33, 0x33, 0x33, 0x33 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { '3', '3', '3', '3', '3', '3', '3', '3', '3', '3' };

            imported.ce103_bin2hex_cs_imported(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_importedcppcs_test2()
        {
            Class1 bin2hex = new Class1();
            Class2 imported = new Class2();
            byte[] bin = { 0xCC, 0xAB, 0xEF, 0x22, 0x59, 0x41 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring1 = new char[bin.Length * 2];
            bin2hex.ce103_bin2hex_cs1(bin, bin.Length, hexstring1);
            imported.ce103_bin2hex_cs_imported(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring1, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_cs_test3()
        {
            Class1 bin2hex = new Class1();
            byte[] bin = { 0xAE, 0xAE, 0xAE, 0xAE, 0xAE, 0xAE, 0xAE, 0xAE };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'A', 'E', 'A', 'E', 'A', 'E', 'A', 'E', 'A', 'E', 'A', 'E', 'A', 'E', 'A', 'E' };

            bin2hex.ce103_bin2hex_cs1(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_imported_test3()
        {
            Class2 imported = new Class2();
            byte[] bin = { 0xCC, 0xAB, 0xEF, 0x22, 0x59, 0x41 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'C', 'C', 'A', 'B', 'E', 'F', '2', '2', '5', '9', '4', '1' };

            imported.ce103_bin2hex_cs_imported(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_importedcppcs_test3()
        {
            Class1 bin2hex = new Class1();
            Class2 imported = new Class2();
            byte[] bin = { 0xBB, 0xBB, 0xBB, 0xBB, 0xBB, 0xBB, 0xBB, 0xBB, 0xBB };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring1 = new char[bin.Length * 2];
            bin2hex.ce103_bin2hex_cs1(bin, bin.Length, hexstring1);
            imported.ce103_bin2hex_cs_imported(bin, bin.Length, hexstring2);
            CollectionAssert.AreEqual(hexstring1, hexstring2);
        }
        [TestMethod]
        public void ce103_hex2bin_cs_test1()
        {
            Class1 hex2bin = new Class1();
            string hexstring = "5858585858585858";
            byte[] expectedArr = { 0x58, 0x58, 0x58, 0x58, 0x58, 0x58, 0x58, 0x58 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs1(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void ce103_hex2bin_imported_test1()
        {
            Class2 hex2bin = new Class2();
            string hexstring = "CCABEF225941";
            byte[] expectedArr = { 0xCC, 0xAB, 0xEF, 0x22, 0x59, 0x41 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs_imported(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void ce103_hex2bin_importedcppcs_test1()
        {
            Class2 imported = new Class2();
            Class1 hex2bin = new Class1();
            string hexstring = "FFFFFFFFFF";

            byte[] hexArr = new byte[hexstring.Length / 2];
            imported.ce103_hex2bin_cs_imported(hexstring, hexstring.Length, hexArr);

            byte[] hexArr2 = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs1(hexstring, hexstring.Length, hexArr2);

            // assert by sequence
            CollectionAssert.AreEqual(hexArr, hexArr2);
        }
        [TestMethod]
        public void ce103_hex2bin_cs_test2()
        {
            Class1 hex2bin = new Class1();
            string hexstring = "7777777777777777";
            byte[] expectedArr = { 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs1(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void ce103_hex2bin_imported_test2()
        {
            Class2 hex2bin = new Class2();
            string hexstring = "3450921542582771876253";
            byte[] expectedArr = { 0x34, 0x50, 0x92, 0x15, 0x42, 0x58, 0x27, 0x71, 0x87, 0x62, 0x53 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs_imported(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void ce103_hex2bin_importedcppcs_test2()
        {
            Class2 imported = new Class2();
            Class1 hex2bin = new Class1();
            string hexstring = "FBEABCCE";
            byte[] expectedArr = { 0xFB, 0xEA, 0xBC, 0xCE };

            byte[] hexArr = new byte[hexstring.Length / 2];
            imported.ce103_hex2bin_cs_imported(hexstring, hexstring.Length, hexArr);

            byte[] hexArr2 = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs1(hexstring, hexstring.Length, hexArr2);

            // assert by sequence
            CollectionAssert.AreEqual(hexArr, hexArr2);
        }
        [TestMethod]
        public void ce103_hex2bin_cs_test3()
        {
            Class1 hex2bin = new Class1();
            string hexstring = "BCBCBCBCBCBCBCBC";
            byte[] expectedArr = { 0xBC, 0xBC, 0xBC, 0xBC, 0xBC, 0xBC, 0xBC, 0xBC };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs1(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void ce103_hex2bin_imported_test3()
        {
            Class2 hex2bin = new Class2();
            string hexstring = "3434343434343434343434";
            byte[] expectedArr = { 0x34, 0x34, 0x34, 0x34, 0x34, 0x34, 0x34, 0x34, 0x34, 0x34, 0x34 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs_imported(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void ce103_hex2bin_importedcppcs_test3()
        {
            Class2 imported = new Class2();
            Class1 hex2bin = new Class1();
            string hexstring = "32245DA14B258431FB";
            byte[] expectedArr = { 0x32, 0x24, 0x5D, 0xA1, 0x4B, 0x25, 0x84, 0x31, 0xFB };

            byte[] hexArr = new byte[hexstring.Length / 2];
            imported.ce103_hex2bin_cs_imported(hexstring, hexstring.Length, hexArr);

            byte[] hexArr2 = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs1(hexstring, hexstring.Length, hexArr2);

            // assert by sequence
            CollectionAssert.AreEqual(hexArr, hexArr2);
        }
    }
}
