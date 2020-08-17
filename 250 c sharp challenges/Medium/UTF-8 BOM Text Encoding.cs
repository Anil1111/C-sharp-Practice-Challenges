/*

UTF-8 BOM Text Encoding
Before Unicode became standard, text files and string data were encoded in different 8-bit based code pages, each different between Germany, Spain, Italy, Sweden, etc. Nowadays, UTF-8 is the mostly used standard for sending text in network communication and when saving text data to files.

UTF-8 encoded text files have a prefix that defines that the file is encoded in UTF-8. It is called a BOM (byte order mark). Use the .Net framework to determine the sequence for the UTF-8 BOM.

Examples
GetUTF8BOM() ➞ { 0xef, 0xbb, 0xbf } (byte array)
Notes
Use the class UTF8Encoding in the System.Text namespace.

*/








/*

Solution 1

*/


using System.Text;
public class Program
{
	public static byte[] GetUTF8BOM() => UTF8Encoding.UTF8.GetPreamble();
}

/*

Solution 2

*/

using System.Text;
public class Program
{
	public static byte[] GetUTF8BOM() => new UTF8Encoding(true).GetPreamble();
}


