using System.Text;

namespace ExcelDataReader.Portable.Core.BinaryFormat
{
	/// <summary>
	/// Represents a string value of formula
	/// </summary>
	internal class XlsBiffFormulaString : XlsBiffRecord
	{
	    private XlsFormattedUnicodeString unicodeString;

		internal XlsBiffFormulaString(byte[] bytes, uint offset, ExcelBinaryReader reader)
			: base(bytes, offset, reader)
		{
		    unicodeString = new XlsFormattedUnicodeString(bytes, offset + 4); 
		}

	    /// <summary>
		/// Encoding used to deal with strings
		/// </summary>
		public Encoding UseEncoding
		{
			get { return unicodeString.UseEncoding; }
		}

		/// <summary>
		/// Length of the string
		/// </summary>
		public uint Length
		{
            get
            {
                return unicodeString.CharacterCount;
            }
		}

		/// <summary>
		/// String text
		/// </summary>
		public string Value
		{
			get
			{
			    return unicodeString.Value;
			}
		}
	}
}