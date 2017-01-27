using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ClientApplication.Model
{
    class BinarySerializer
    {
        private Stream _serializationStream = null;
        private BinaryFormatter _formatter;
        public BinaryFormatter Formatter { get { return _formatter; } set { if ( _formatter != value ) _formatter = value; } }
        private Header[] headers;
        
        [Serializable()]
        class Test
        {
            public int var1;
            public int var2 = 10;
            [NonSerialized()] public int varS = 500;
            public Test( ) {
                var1 = 5;
            }
        }

        Test test = new Test( );

        public void Serialize( ) {
            Formatter = new BinaryFormatter( );
            Formatter.Serialize( _serializationStream, test );
            //_serializationStream.Close( );
            Console.WriteLine(test.var1);
        }


    }
}
