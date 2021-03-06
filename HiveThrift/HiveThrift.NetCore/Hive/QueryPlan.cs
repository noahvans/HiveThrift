/**
 * Autogenerated by Thrift Compiler (0.9.1)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */

using System;
using System.Collections.Generic;
using System.Text;
using Thrift.Protocol;

namespace Hive
{
#if !SILVERLIGHT

    
#endif
    public partial class QueryPlan : TBase
    {
        private List<Query> _queries;
        private bool _done;
        private bool _started;

        public List<Query> Queries
        {
            get
            {
                return _queries;
            }
            set
            {
                __isset.queries = true;
                this._queries = value;
            }
        }

        public bool Done
        {
            get
            {
                return _done;
            }
            set
            {
                __isset.done = true;
                this._done = value;
            }
        }

        public bool Started
        {
            get
            {
                return _started;
            }
            set
            {
                __isset.started = true;
                this._started = value;
            }
        }

        public Isset __isset;
#if !SILVERLIGHT

        
#endif
        public struct Isset
        {
            public bool queries;
            public bool done;
            public bool started;
        }

        public QueryPlan()
        {
        }

        public void Read(TProtocol iprot)
        {
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
                        if (field.Type == TType.List)
                        {
                            {
                                Queries = new List<Query>();
                                TList _list64 = iprot.ReadListBegin();
                                for (int _i65 = 0; _i65 < _list64.Count; ++_i65)
                                {
                                    Query _elem66 = new Query();
                                    _elem66 = new Query();
                                    _elem66.Read(iprot);
                                    Queries.Add(_elem66);
                                }
                                iprot.ReadListEnd();
                            }
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;

                    case 2:
                        if (field.Type == TType.Bool)
                        {
                            Done = iprot.ReadBool();
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;

                    case 3:
                        if (field.Type == TType.Bool)
                        {
                            Started = iprot.ReadBool();
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
        }

        public void Write(TProtocol oprot)
        {
            TStruct struc = new TStruct("QueryPlan");
            oprot.WriteStructBegin(struc);
            TField field = new TField();
            if (Queries != null && __isset.queries)
            {
                field.Name = "queries";
                field.Type = TType.List;
                field.ID = 1;
                oprot.WriteFieldBegin(field);
                {
                    oprot.WriteListBegin(new TList(TType.Struct, Queries.Count));
                    foreach (Query _iter67 in Queries)
                    {
                        _iter67.Write(oprot);
                    }
                    oprot.WriteListEnd();
                }
                oprot.WriteFieldEnd();
            }
            if (__isset.done)
            {
                field.Name = "done";
                field.Type = TType.Bool;
                field.ID = 2;
                oprot.WriteFieldBegin(field);
                oprot.WriteBool(Done);
                oprot.WriteFieldEnd();
            }
            if (__isset.started)
            {
                field.Name = "started";
                field.Type = TType.Bool;
                field.ID = 3;
                oprot.WriteFieldBegin(field);
                oprot.WriteBool(Started);
                oprot.WriteFieldEnd();
            }
            oprot.WriteFieldStop();
            oprot.WriteStructEnd();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("QueryPlan(");
            sb.Append("Queries: ");
            sb.Append(Queries);
            sb.Append(",Done: ");
            sb.Append(Done);
            sb.Append(",Started: ");
            sb.Append(Started);
            sb.Append(")");
            return sb.ToString();
        }
    }
}