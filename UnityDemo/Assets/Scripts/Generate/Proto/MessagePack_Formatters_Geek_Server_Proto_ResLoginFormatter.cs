// <auto-generated>
// THIS (.cs) FILE IS GENERATED BY MPC(MessagePack-CSharp). DO NOT CHANGE IT.
// </auto-generated>

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168
#pragma warning disable CS1591 // document public APIs

#pragma warning disable SA1129 // Do not use default value type constructor
#pragma warning disable SA1309 // Field names should not begin with underscore
#pragma warning disable SA1312 // Variable names should begin with lower-case letter
#pragma warning disable SA1403 // File may only contain a single namespace
#pragma warning disable SA1649 // File name should match first type name

namespace MessagePack.Formatters.Geek.Server.Proto
{
    public sealed class ResLoginFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::Geek.Server.Proto.ResLogin>
    {

        public void Serialize(ref global::MessagePack.MessagePackWriter writer, global::Geek.Server.Proto.ResLogin value, global::MessagePack.MessagePackSerializerOptions options)
        {
            if (value == null)
            {
                writer.WriteNil();
                return;
            }

            global::MessagePack.IFormatterResolver formatterResolver = options.Resolver;
            writer.WriteArrayHeader(3);
            writer.Write(value.UniId);
            writer.Write(value.Code);
            global::MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<global::Geek.Server.Proto.UserInfo>(formatterResolver).Serialize(ref writer, value.UserInfo, options);
        }

        public global::Geek.Server.Proto.ResLogin Deserialize(ref global::MessagePack.MessagePackReader reader, global::MessagePack.MessagePackSerializerOptions options)
        {
            if (reader.TryReadNil())
            {
                return null;
            }

            options.Security.DepthStep(ref reader);
            global::MessagePack.IFormatterResolver formatterResolver = options.Resolver;
            var length = reader.ReadArrayHeader();
            var ____result = new global::Geek.Server.Proto.ResLogin();

            for (int i = 0; i < length; i++)
            {
                switch (i)
                {
                    case 0:
                        ____result.UniId = reader.ReadInt32();
                        break;
                    case 1:
                        ____result.Code = reader.ReadInt32();
                        break;
                    case 2:
                        ____result.UserInfo = global::MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<global::Geek.Server.Proto.UserInfo>(formatterResolver).Deserialize(ref reader, options);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }

            reader.Depth--;
            return ____result;
        }
    }

}

#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612

#pragma warning restore SA1129 // Do not use default value type constructor
#pragma warning restore SA1309 // Field names should not begin with underscore
#pragma warning restore SA1312 // Variable names should begin with lower-case letter
#pragma warning restore SA1403 // File may only contain a single namespace
#pragma warning restore SA1649 // File name should match first type name
