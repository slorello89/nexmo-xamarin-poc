using ObjCRuntime;
namespace NexmoXamarinIOS
{
	[Native]
	public enum NXMConnectionStatus : long
	{
		Disconnected,
		Connecting,
		Connected
	}

	[Native]
	public enum NXMConnectionStatusReason : long
	{
		Unknown,
		Login,
		Logout,
		TokenRefreshed,
		TokenInvalid,
		TokenExpired,
		UserNotFound,
		Terminated
	}

	[Native]
	public enum NXMPushTemplate : long
	{
		Default,
		Custom
	}

	[Native]
	public enum NXMMemberUpdateType : long
	{
		State,
		Media,
		Leg
	}

	[Native]
	public enum NXMMediaType : long
	{
		None = (0),
		Audio = (1L << 0),
		Video = (1L << 1)
	}

	[Native]
	public enum NXMEventType : long
	{
		General,
		Custom,
		Text,
		Image,
		MessageStatus,
		TextTyping,
		Media,
		Member,
		Sip,
		Dtmf,
		LegStatus,
		Unknown
	}

	[Native]
	public enum NXMSipStatus : long
	{
		Ringing,
		Answered,
		Status,
		Hangup
	}

	[Native]
	public enum NXMMessageStatusType : long
	{
		None,
		Seen,
		Delivered,
		Deleted
	}

	[Native]
	public enum NXMTextTypingEventStatus : long
	{
		n,
		ff
	}

	[Native]
	public enum NXMMemberState : long
	{
		Invited,
		Joined,
		Left
	}

	[Native]
	public enum NXMDirectionType : long
	{
		App,
		Phone,
		Sip,
		Websocket,
		Vbc,
		Unknown
	}

	[Native]
	public enum NXMMediaStreamType : long
	{
		None,
		Send,
		Receive,
		SendReceive
	}

	[Native]
	public enum NXMLegStatus : long
	{
		Ringing,
		Started,
		Answered,
		Canceled,
		Failed,
		Busy,
		Timeout,
		Rejected,
		Completed
	}

	[Native]
	public enum NXMLegType : long
	{
		App,
		Phone,
		Unknown
	}

	[Native]
	public enum NXMPageOrder : long
	{
		Asc,
		Desc
	}

	[Native]
	public enum NXMImageSize : long
	{
		Medium,
		Original,
		Thumbnail
	}

	[Native]
	public enum NXMAttachmentType : long
	{
		NXMAttachmentTypeImage
	}

	[Native]
	public enum NXMCallMemberStatus : long
	{
		Ringing,
		Started,
		Answered,
		Canceled,
		Failed,
		Busy,
		Timeout,
		Rejected,
		Completed
	}

	[Native]
	public enum NXMCallHandler : long
	{
		InApp,
		Server
	}

	[Native]
	public enum NXMErrorCode : long
	{
		None,
		Unknown,
		SessionUnknown,
		SessionInvalid,
		SessionDisconnected,
		MaxOpenedSessions,
		TokenUnknown,
		TokenInvalid,
		TokenExpired,
		MemberUnknown,
		MemberNotFound,
		MemberAlreadyRemoved,
		NotAMemberOfTheConversation,
		EventUnknown,
		EventUserNotFound,
		EventUserAlreadyJoined,
		EventInvalid,
		EventBadPermission,
		EventNotFound,
		EventsPageNotFound,
		ConversationRetrievalFailed,
		ConversationNotFound,
		ConversationInvalidMember,
		ConversationExpired,
		ConversationsPageNotFound,
		MediaNotSupported,
		MediaNotFound,
		InvalidMediaRequest,
		MediaTooManyRequests,
		MediaBadRequest,
		MediaInternalError,
		PushNotANexmoPush,
		PushParsingFailed,
		NotImplemented,
		MissingDelegate,
		PayloadTooBig,
		SDKDisconnected,
		UserNotFound,
		DTMFIllegal
	}

	[Native]
	public enum NXMLoggerLevel : long
	{
		None,
		Error,
		Debug,
		Info,
		Verbose
	}

}
