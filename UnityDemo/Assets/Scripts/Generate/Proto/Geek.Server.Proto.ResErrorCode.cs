//auto generated, do not modify it

using MessagePack;

namespace Geek.Server.Proto
{
	[MessagePackObject(true)]
	public class ResErrorCode : Geek.Server.Message
	{
		[IgnoreMember]
		public const int Sid = -138811813;

		[IgnoreMember]
		public const int MsgID = Sid;
		[IgnoreMember]
		public override int MsgId => MsgID;

        /// <summary>
        /// 0:表示无错误
        /// </summary>
        public long ErrCode { get; set; }
        /// <summary>
        /// 错误描述（不为0时有效）
        /// </summary>
        public string Desc { get; set; }
	}
}
