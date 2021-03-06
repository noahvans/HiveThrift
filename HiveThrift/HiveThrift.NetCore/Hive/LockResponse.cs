/**
 * Autogenerated by Thrift Compiler (0.9.1)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */

using System;
using System.Text;
using Thrift.Protocol;

namespace Hive
{
#if !SILVERLIGHT

    
#endif
    public partial class LockResponse : TBase
    {
        public long Lockid { get; set; }

        /// <summary>
        ///
        /// <seealso cref="LockState"/>
        /// </summary>
        public LockState State { get; set; }

        public LockResponse()
        {
        }

        public LockResponse(long lockid, LockState state)
            : this()
        {
            this.Lockid = lockid;
            this.State = state;
        }

        public void Read(TProtocol iprot)
        {
            bool isset_lockid = false;
            bool isset_state = false;
            TField field;
            iprot.ReadStructBegin();
            while (true)
            {
                field = iprot.ReadFieldBegin();
                if (field.Type == TType.Stop)
                {
                    break;
                }
                switch (field.ID)
                {
                    case 1:
                        if (field.Type == TType.I64)
                        {
                            Lockid = iprot.ReadI64();
                            isset_lockid = true;
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;

                    case 2:
                        if (field.Type == TType.I32)
                        {
                            State = (LockState)iprot.ReadI32();
                            isset_state = true;
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;

                    default:
                        TProtocolUtil.Skip(iprot, field.Type);
                        break;
                }
                iprot.ReadFieldEnd();
            }
            iprot.ReadStructEnd();
            if (!isset_lockid)
                throw new TProtocolException(TProtocolException.INVALID_DATA);
            if (!isset_state)
                throw new TProtocolException(TProtocolException.INVALID_DATA);
        }

        public void Write(TProtocol oprot)
        {
            TStruct struc = new TStruct("LockResponse");
            oprot.WriteStructBegin(struc);
            TField field = new TField();
            field.Name = "lockid";
            field.Type = TType.I64;
            field.ID = 1;
            oprot.WriteFieldBegin(field);
            oprot.WriteI64(Lockid);
            oprot.WriteFieldEnd();
            field.Name = "state";
            field.Type = TType.I32;
            field.ID = 2;
            oprot.WriteFieldBegin(field);
            oprot.WriteI32((int)State);
            oprot.WriteFieldEnd();
            oprot.WriteFieldStop();
            oprot.WriteStructEnd();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("LockResponse(");
            sb.Append("Lockid: ");
            sb.Append(Lockid);
            sb.Append(",State: ");
            sb.Append(State);
            sb.Append(")");
            return sb.ToString();
        }
    }
}