


















// Generated on 06/04/2015 18:44:23
using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.DofusProtocol.Types;
using Symbioz.Utils;

namespace Symbioz.DofusProtocol.Messages
{

public class MountEquipedErrorMessage : Message
{

public const ushort Id = 5963;
public override ushort MessageId
{
    get { return Id; }
}

public sbyte errorType;
        

public MountEquipedErrorMessage()
{
}

public MountEquipedErrorMessage(sbyte errorType)
        {
            this.errorType = errorType;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteSByte(errorType);
            

}

public override void Deserialize(ICustomDataInput reader)
{

errorType = reader.ReadSByte();
            if (errorType < 0)
                throw new Exception("Forbidden value on errorType = " + errorType + ", it doesn't respect the following condition : errorType < 0");
            

}


}


}