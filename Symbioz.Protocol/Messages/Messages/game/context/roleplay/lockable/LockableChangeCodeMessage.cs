


















// Generated on 06/04/2015 18:44:30
using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.DofusProtocol.Types;
using Symbioz.Utils;

namespace Symbioz.DofusProtocol.Messages
{

public class LockableChangeCodeMessage : Message
{

public const ushort Id = 5666;
public override ushort MessageId
{
    get { return Id; }
}

public string code;
        

public LockableChangeCodeMessage()
{
}

public LockableChangeCodeMessage(string code)
        {
            this.code = code;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUTF(code);
            

}

public override void Deserialize(ICustomDataInput reader)
{

code = reader.ReadUTF();
            

}


}


}