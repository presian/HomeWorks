namespace ConcatenateStrings
{
    using System;
    using System.Data.SqlTypes;
    using System.IO;
    using System.Text;
    using Microsoft.SqlServer.Server;

    [Serializable]
    [SqlUserDefinedAggregate(
       Format.UserDefined,
       IsInvariantToDuplicates = false, 
       IsInvariantToNulls = false,      
       IsInvariantToOrder = true,       
       IsNullIfEmpty = true,
       MaxByteSize = -1,                
       Name = "ConcatStrings"           
    )]
    public class StringConcatenator : IBinarySerialize
    {
        private StringBuilder intermediateResult;

        internal string IntermediateResult
        {
            get
            {
                return intermediateResult.ToString();
            }
        }

        public void Init()
        {
            intermediateResult = new StringBuilder();
        }

        public void Accumulate(SqlString value)
        {
            if (value.IsNull)
            {
                return;
            }

            intermediateResult.Append(string.Format("{0}, ", value.Value));
        }

        public void Merge(StringConcatenator concatenatedString)
        {
            if (concatenatedString == null)
            {
                return;
            }

            intermediateResult.Append(concatenatedString.intermediateResult + ", ");
        }

        public SqlString Terminate()
        {
            var outputString = string.Empty;

            if (intermediateResult != null && intermediateResult.Length > 0)
            {
                outputString = intermediateResult.ToString(0, intermediateResult.Length - 1);  
            }

            return new SqlString(outputString);
        }

        public void Read(BinaryReader reader)
        {
            if (reader == null)
            {
                throw new ArgumentNullException("reader");   
            }

            intermediateResult = new StringBuilder(reader.ReadString());
        }

        public void Write(BinaryWriter writer)
        {
            if (writer == null)
            {
                throw new ArgumentNullException("writer"); 
            } 

            writer.Write(intermediateResult.ToString());
        }
    }
}