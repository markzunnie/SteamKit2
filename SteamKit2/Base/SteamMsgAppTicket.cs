﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: encrypted_app_ticket.proto
namespace SteamKit2
{
    [global::System.Serializable, global::ProtoBuf.ProtoContract( Name = @"EncryptedAppTicket" )]
    public partial class EncryptedAppTicket : global::ProtoBuf.IExtensible
    {
        public EncryptedAppTicket() { }


        private uint _ticket_version_no = default( uint );
        [global::ProtoBuf.ProtoMember( 1, IsRequired = false, Name = @"ticket_version_no", DataFormat = global::ProtoBuf.DataFormat.TwosComplement )]
        [global::System.ComponentModel.DefaultValue( default( uint ) )]
        public uint ticket_version_no
        {
            get { return _ticket_version_no; }
            set { _ticket_version_no = value; }
        }

        private uint _crc_encryptedticket = default( uint );
        [global::ProtoBuf.ProtoMember( 2, IsRequired = false, Name = @"crc_encryptedticket", DataFormat = global::ProtoBuf.DataFormat.TwosComplement )]
        [global::System.ComponentModel.DefaultValue( default( uint ) )]
        public uint crc_encryptedticket
        {
            get { return _crc_encryptedticket; }
            set { _crc_encryptedticket = value; }
        }

        private uint _cb_encrypteduserdata = default( uint );
        [global::ProtoBuf.ProtoMember( 3, IsRequired = false, Name = @"cb_encrypteduserdata", DataFormat = global::ProtoBuf.DataFormat.TwosComplement )]
        [global::System.ComponentModel.DefaultValue( default( uint ) )]
        public uint cb_encrypteduserdata
        {
            get { return _cb_encrypteduserdata; }
            set { _cb_encrypteduserdata = value; }
        }

        private uint _cb_encrypted_appownershipticket = default( uint );
        [global::ProtoBuf.ProtoMember( 4, IsRequired = false, Name = @"cb_encrypted_appownershipticket", DataFormat = global::ProtoBuf.DataFormat.TwosComplement )]
        [global::System.ComponentModel.DefaultValue( default( uint ) )]
        public uint cb_encrypted_appownershipticket
        {
            get { return _cb_encrypted_appownershipticket; }
            set { _cb_encrypted_appownershipticket = value; }
        }

        private byte[] _encrypted_ticket = null;
        [global::ProtoBuf.ProtoMember( 5, IsRequired = false, Name = @"encrypted_ticket", DataFormat = global::ProtoBuf.DataFormat.Default )]
        [global::System.ComponentModel.DefaultValue( null )]
        public byte[] encrypted_ticket
        {
            get { return _encrypted_ticket; }
            set { _encrypted_ticket = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject( bool createIfMissing )
        { return global::ProtoBuf.Extensible.GetExtensionObject( ref extensionObject, createIfMissing ); }
    }

}