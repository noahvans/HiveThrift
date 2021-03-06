/**
 * Autogenerated by Thrift Compiler (0.9.1)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;

using Thrift.Protocol;
using Thrift.Transport;

namespace Hive2
{
#if !SILVERLIGHT

#endif

    public partial class TGetOperationStatusReq : TBase
    {
        public TOperationHandle OperationHandle { get; set; }

        public TGetOperationStatusReq()
        {
        }

        public TGetOperationStatusReq(TOperationHandle operationHandle) : this()
        {
            this.OperationHandle = operationHandle;
        }

        public void Read(TProtocol iprot)
        {
            bool isset_operationHandle = false;
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
                        if (field.Type == TType.Struct)
                        {
                            OperationHandle = new TOperationHandle();
                            OperationHandle.Read(iprot);
                            isset_operationHandle = true;
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
            if (!isset_operationHandle)
                throw new TProtocolException(TProtocolException.INVALID_DATA);
        }

        public void Write(TProtocol oprot)
        {
            TStruct struc = new TStruct("TGetOperationStatusReq");
            oprot.WriteStructBegin(struc);
            TField field = new TField();
            field.Name = "operationHandle";
            field.Type = TType.Struct;
            field.ID = 1;
            oprot.WriteFieldBegin(field);
            OperationHandle.Write(oprot);
            oprot.WriteFieldEnd();
            oprot.WriteFieldStop();
            oprot.WriteStructEnd();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("TGetOperationStatusReq(");
            sb.Append("OperationHandle: ");
            sb.Append(OperationHandle == null ? "<null>" : OperationHandle.ToString());
            sb.Append(")");
            return sb.ToString();
        }
    }
}