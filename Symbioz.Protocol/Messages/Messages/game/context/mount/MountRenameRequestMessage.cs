


















// Generated on 06/04/2015 18:44:23
using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.DofusProtocol.Types;
using Symbioz.Utils;

namespace Symbioz.DofusProtocol.Messages
{

public class MountRenameRequestMessage : Message
{

public const ushort Id = 5987;
public override ushort MessageId
{
    get { return Id; }
}

public string name;
        public int mountId;
        

public MountRenameRequestMessage()
{
}

public MountRenameRequestMessage(string name, int mountId)
        {
            this.name = name;
            this.mountId = mountId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUTF(name);
            writer.WriteVarInt(mountId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

name = reader.ReadUTF();
            mountId = reader.ReadVarInt();
            

}


}


}